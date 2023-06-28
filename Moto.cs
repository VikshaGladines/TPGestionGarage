using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    internal class Moto
    {
        private string nom;
        public string Nom { get => nom; set => nom = value; }


        private decimal prix;
        public decimal Prix { get => prix; set => prix = value; }


        private string marque;
        public string Marque { get => marque; set => marque = value; }


        private string moteur;
        public string Moteur { get => moteur; set => moteur = value; }


        private string option;
        public string Option { get => option; set => option = value; }


        private string cylindree;
        public string Cylindree { get => cylindree; set => cylindree = value; }

    }
}
