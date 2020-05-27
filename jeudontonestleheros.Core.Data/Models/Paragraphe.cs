using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Paragraphe
    {
        #region Propriétés
        // ID venant de la base
        public int Id { get; set; }
        // Numéro à afficher pour le jeu
        public int Numero { get; set; }
        // C'est le titre du paragraphe
        public string Titre { get; set; }
        // Description du paragraphe
        public string Description { get; set; }
        //Question du paragraphe
        public Question MaQuestion { get; set; }
        #endregion
    }
}
