//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace application_adoption
{
    using System;
    using System.Collections.Generic;
    
    public partial class detail_adopt
    {
        public int id_adopt { get; set; }
        public int id_animal { get; set; }
        public int nbr_animaux { get; set; }
    
        public virtual adopt adopt { get; set; }
        public virtual animal animal { get; set; }
    }
}
