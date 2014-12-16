using dllLoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TP_Memory
{
    public partial class Memory : Form
    {
        // Déclaration des variables globales du jeu

        int nbCartesDansSabot;  // Nombre de cartes dans le sabot (en fait nombre d'images dans le réservoir)
        int nbCartesSurTapis;   // Nombre de cartes sur le tapis


        private void Distribution_Aleatoire()
        {
            // On utilise la LotoMachine pour générer une série aléatoire
            LotoMachine hasard = new LotoMachine(nbCartesDansSabot);
            // On veut une série de nbCartesSurTapis cartes parmi celles 
            // du réservoir
            int[] tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis, false);
            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"

            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                carte = (PictureBox) tlpTapisDeCartes.Controls[i_carte];
                i_image = tImagesCartes[i_carte + 1]; // i_carte + 1 à cause
                // des pbs d'indices
                carte.Image = ilSabotDeCartes.Images[i_image];
            }
        }




    }
}
