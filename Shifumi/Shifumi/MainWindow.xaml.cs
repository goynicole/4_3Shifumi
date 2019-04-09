using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shifumi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int counter = 0;
        int win = 0;
        int lose = 0;
        int user;//saisie de l'utilisateur
        string[] choice = new string[] { "Pierre", "Feuille", "Ciseaux" }; //Déclaration d'un tableau contenant les choix possibles

        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void BtnPierre_Click(object sender, RoutedEventArgs e)
        {
            user = 0;
        }

        private void BtnFeuille_Click(object sender, RoutedEventArgs e)
        {
            user = 1;
        }

        private void BtnCiseaux_Click(object sender, RoutedEventArgs e)
        {
            user = 2;
        }

        private void BtnJouer_Click(object sender, RoutedEventArgs e)
        {
            //Ramdom position directement dans le bouton jouer pour que le choix aléatoire se fasse à chaque fois
            Random random = new Random();
            int computer = random.Next(0, 3); 

            //Vérification que l'utilisateur a bien fait un choix
            if (user < 3)
            {
                //incrémentation du compteur
                ++counter;
                // Comparaison des résultats pierre feuille ciseaux, incrémentation du score ,toute les possibilité du jeu
                //si gagne
                if ((user == 0 && computer == 2) || (user == 1 && computer == 0) || (user == 2 && computer == 1))
                {
                    win++;
                    textBlockinfo.Text = $"Vous avez choisi { choice[user]}...\nL'ordinateur avait choisi :{choice[computer]} !";
                }
                //si perd
                else if ((user == 0 && computer == 1) || (user == 1 && computer == 2) || (user == 2 && computer == 0))
                {
                    lose++;
                    textBlockinfo.Text = $"Vous avez Perdu avec { choice[user]}...\nl'ordinateur avait choisi :{choice[computer]} !";
                }
                //si égalité
                else
                {
                    textBlockinfo.Text = $"Egalité avec { choice[user]}...\nl'ordinateur avait choisi :{choice[computer]} !";
                }
                textBlockCounter.Text = $"Victoire {win}, \nPartie perdu {lose}, \nNombre de partie {counter}";
                Pourcentage.Text = "Pourcentage de victoire " + win*100/counter + " %";
            }
        }
    }
}
