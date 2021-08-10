using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Agences_Location.Controllers;
using Gestion_Agences_Location.Models;

namespace Gestion_Agences_Location.Controllers
{
    class Controller_Ville
    {
        List<Ville> lisetVille = new List<Ville>();

        public List<Ville> getAll()
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                lisetVille = _context.Villes.ToList();
            }
            return lisetVille;
        }


        public List<Ville> getByName(string nom)
        {
            
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                lisetVille = _context.Villes.Where(e => e.NOM.Contains(nom)).ToList();
            }
            return lisetVille;
        }


        public Ville getById(int idville)
        {
            Ville ville = new Ville();
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                ville = _context.Villes.FirstOrDefault(e => e.IDVILLE == idville);
            }
            return ville;
        }


        

        public bool Modifier(Ville ville)
        {
            bool done = false;
          Ville _ville = new Ville();
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                _ville = _context.Villes.FirstOrDefault(e => e.IDVILLE == ville.IDVILLE);
                if (_ville != null)
                {
                    _ville.NOM = ville.NOM;
                    _context.SaveChanges();
                    done = true;
                }
            }
            return done;
        }

        public bool Suprimer(string nomVille)
        {
            bool done = false;

            Ville _ville = new Ville();
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                _ville = _context.Villes.FirstOrDefault(e => e.NOM == nomVille);
                if (_ville != null)
                {
                    _context.Villes.Remove(_ville);
                    _context.SaveChanges();
                    done = true;
                }
            }
            return done;
        }

        public bool Ajoutter(Ville ville)
        {
            bool existe = false;
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                Ville v = _context.Villes.FirstOrDefault(e => e.NOM == ville.NOM);
                if (v == null)
                {
                    existe = true;
                    _context.Villes.Add(ville);
                    _context.SaveChanges();
                }
            }
            return existe;
        }

    }
}
