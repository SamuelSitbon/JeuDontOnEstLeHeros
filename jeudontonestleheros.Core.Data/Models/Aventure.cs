﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés
        // C'est l'id de chaque aventure
        public int Id { get; set; }
        // C'est le titre de chaque aventure 
        public string Titre { get; set; }
        #endregion
    }
}
