using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Question
    {
        #region Propriétés
        // ID de l'instance
        public int Id { get; set; }
        // C'est le titre de la question
        public string Titre { get; set; }
        // Liste des réponses possibles
        public List<Reponse> MesReponses { get; set; }
        #endregion
    }
}
