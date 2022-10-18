using System.Data;

namespace SolFormatif1A22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void q2()
        {
            Random random = new Random();
            int dommagesPikachu = 0;
            int niveauTauros = random.Next(1, 100);

            if (niveauTauros < 50)
            {
                dommagesPikachu = 100;
            }
            else if (niveauTauros < 70)
            {
                dommagesPikachu = 150;
            }
            else if (niveauTauros < 90)
            {
                dommagesPikachu = 200;
            }
            else
            {
                dommagesPikachu = 250;
            }

            Console.WriteLine("Dommages : " + dommagesPikachu);

        }
        static void q5()
        {
            int angle = 0;
            string message = "";

            Console.WriteLine("Entrer un angle (Entier) : ");
            int.TryParse(Console.ReadLine(), out angle);

            if (angle < 0)
            {
                message = "Robot hors contôle";
            }
            else if (angle < 40)
            {
                message = "Main fermée";
            }
            else if (angle < 90)
            {
                message = "Main agrippe";
            }
            else if (angle <= 180)
            {
                message = "Main ouverte";
            }
            else 
            {
                message = "Robot hors contôle";

            }

            Console.WriteLine(message);
        }

        static void raspiBot()
        {
            double total = 0.0;
            string controleur = "Pi";
            int nbMoteurs = 2;
            string cameraUSB = "oui";
            string leds = "oui";
            string message = "";

            Console.WriteLine("Choisir Pi ou Pi Zero");
            controleur = Console.ReadLine();

            if (controleur == "Pi")
            {
                total += 55;
                message = "Contrôleur : " + controleur;
            }
            else 
            {
                total += 15;
            }

            Console.WriteLine("Combien de moteurs (2 à 24)");
            int.TryParse(Console.ReadLine(), out nbMoteurs);

            total = total + nbMoteurs * 5;
            message = message + " Nb moteurs : " + nbMoteurs;

            Console.WriteLine("Camera USB oui/non");
            cameraUSB = Console.ReadLine();

            if (cameraUSB == "oui")
            {
                total = total + 35;
                message = message + " Camera USB";
            }
            else
            {
                message = message + " Pas de camera";
            }

            Console.WriteLine("Matrice LEDS oui/non");
            leds = Console.ReadLine();

            if (leds == "oui")
            {
                total = total + 10;
                message = message + " Matrice de LEDS";
            }
            else 
            {
                message = message + " Pas de matrice";
            }

            total = total + 20 + 15;

            Console.WriteLine(message);
            Console.WriteLine("Prix : " + total);
            total = total * 1.15;
            Console.WriteLine("Prix livré : " + total);
        }
    }
}