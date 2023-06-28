using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    internal class Camion
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


        private decimal nbEssieux;
        public decimal NbEssieux { get => nbEssieux; set => nbEssieux = value; }


        private decimal poidCharge;
        public decimal PoidCharge { get => poidCharge; set => poidCharge = value; }


        private decimal volumeCharge;
        public decimal VolumeCharge { get => volumeCharge; set => volumeCharge = value; }

    }
}
