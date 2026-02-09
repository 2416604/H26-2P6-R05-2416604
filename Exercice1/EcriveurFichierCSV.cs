using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercice1
{
    internal class EcriveurFichierCSV
    {
        // Constantes
        public const string CHEMIN_PAR_DEFAUT = @"C:\EspaceLabo";
        public const string NOM_FICHIER_DEFAUT = "monFichier.csv";


        public enum TypeDelimiteur { Virgule, PointVirgule, LigneVerticale }
        // Champs 
        private string cheminAcces;
        private string nomFichier;
        private TypeDelimiteur _typeDelimiteur;

        //Propriétés
        public string CheminAccess { get; private set; }
        public string NomFichier { get; private set; }
        private TypeDelimiteur DelimiteurChoisi { get; set; }

        //Méthodes
        public void EcrireLignr(string[] colonnes) { }

        public EcriveurFichierCSV(string cheminAcces, string nomFichier, TypeDelimiteur delimiteur){ }

    }

    
}
