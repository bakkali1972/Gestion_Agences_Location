//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Agences_Location.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRAT
    {
        public int IDCONTRAT { get; set; }
        public string NUMERO_CONTRAT { get; set; }
        public System.DateTime DATEDEBUT { get; set; }
        public int DUREE { get; set; }
        public int IDAGENCE { get; set; }
        public int IDLOCAUX { get; set; }
        public string CNIECLIENT { get; set; }
        public double PRIX { get; set; }
    
        public virtual Agence Agence { get; set; }
        public virtual CLIENT CLIENT { get; set; }
        public virtual LOCAUX LOCAUX { get; set; }
    }
}
