using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Agences_Location.Models;

namespace Gestion_Agences_Location.Controllers
{
    class Controller_Responsable
    {


        List<Responsable> listeResponsable = new List<Responsable>();

        public List<Responsable> getAll()
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                listeResponsable = _context.Responsables.ToList();
            }
            return listeResponsable;
        }

        public List<Responsable> getByName(string nom)
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                listeResponsable = _context.Responsables.Where(e => e.NOM_PRENOM.Contains(nom)).ToList();
            }
            return listeResponsable;
        }

        public List<Responsable> getByIdResponsable(int idResponsable)
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                listeResponsable = _context.Responsables.Where(e => e.IDRESPONSABLE == idResponsable).ToList();
            }
            return listeResponsable;
        }





        public bool Modifier(Responsable responsable)
        {
            Responsable _responsable = new Responsable();
            bool done = false;
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                _responsable = _context.Responsables.FirstOrDefault(e => e.NOM_PRENOM == responsable.NOM_PRENOM);
                if (_responsable != null)
                {
                    _responsable.NOM_PRENOM = responsable.NOM_PRENOM;
                    _responsable.Ville = responsable.Ville;
                    _responsable.TELE = responsable.TELE;
                    done = true;
                }
            }
            return true;
        }

        public bool Suprimer(int idResponsable)
        {
            Responsable _responsable = new Responsable();
            bool done = false;
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                _responsable = _context.Responsables.FirstOrDefault(e => e.IDRESPONSABLE == idResponsable);
                if (_responsable != null)
                {
                    _context.Responsables.Remove(_responsable);
                    _context.SaveChanges();
                    done = true;
                }
            }
            return done;
        }

    }
}
