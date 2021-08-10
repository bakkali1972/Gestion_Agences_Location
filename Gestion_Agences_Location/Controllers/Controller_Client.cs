using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Agences_Location.Models;
using Gestion_Agences_Location.Controllers;


namespace Gestion_Agences_Location.Controllers
{
    class Controller_Client
    {
        List<CLIENT> ListClient = new List<CLIENT>();

        public List<CLIENT> GetAll()
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                ListClient = _context.CLIENTs.ToList();
            }
            return ListClient;
        }


        public List<CLIENT> getByCnie(string cnie)
        {
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                ListClient = _context.CLIENTs.Where(e => e.CNIE ==cnie).ToList();
            }
            return ListClient;
        }

        public bool Modifier(CLIENT client)
        {
            CLIENT _client = new CLIENT();
            bool done = false;
             using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
                {
                _client = _context.CLIENTs.FirstOrDefault(e => e.CNIE == client.CNIE);
                if (_client != null)
                {
                    _client.NOM_PRENOM = client.NOM_PRENOM;
                    _client.ADRESSE = _client.ADRESSE;
                    _client.TELE = _client.TELE;
                }
                return true;
            }
        }

        public bool Suprimer(string cnie)
        {
            CLIENT _client = new CLIENT();
            bool done = false;
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                _client = _context.CLIENTs.FirstOrDefault(e => e.CNIE == cnie);
                if (_client != null)
                {
                    _context.CLIENTs.Remove(_client);
                    _context.SaveChanges();
                    done = true;
                }
            }
            return done;
        }

        public bool Ajoutter(CLIENT client)
        {
            bool existe = false;
            using (Gestion_Agence_LocationEntities _context = new Gestion_Agence_LocationEntities())
            {
                CLIENT _client = _context.CLIENTs.FirstOrDefault(e => e.CNIE == client.CNIE);
                if (_client == null)
                {
                    existe = true;
                    _context.CLIENTs.Add(client);
                    _context.SaveChanges();
                }
            }
            return existe;
        }


    }
}
