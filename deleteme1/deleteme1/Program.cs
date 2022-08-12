using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// UserStory: Benutzer hat wenn das Programm ausgeführt wird, die Möglichkeit auszuwählen, was er berechnen möchte.
/// Auswahl zwischen:
/// Grundrechenarten (Addition / Subtraktion / Multiplikation und Division)
/// Flächenberechnung
/// Volumenberechnung


namespace deleteme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Warte auf Eingabe vom Benutzer

            RechenMethodeAuswahl();
            
        }

        // Frage den Benutzer durch die Methode "RechenMethodeAuswahl" was er berechnen möchte 

        static string RechenMethodeAuswahl()
        {

            Console.WriteLine("Was möchtest du Berechnen?");
            Console.WriteLine("1 - Grundrechenarten ( + | - | / | * | / )");
            Console.WriteLine("2 - Flächenberechnung");
            Console.WriteLine("3 - Volumen berechnen");
            Console.WriteLine("");
            Console.WriteLine("0 - Programm beenden");

            string rechenAuswahl = " - ";
            rechenAuswahl = Console.ReadLine();

        // rechenAuswahl == 1 : Der Benutzer kann nun die Grundrechenarten benutzen. (Addition / Subtraktion / Multiplikation und Division)

            if (rechenAuswahl == "1")
            {
                Console.WriteLine("Du kannst jetzt ( + | - | / | * | / ) rechnen.");

                string ersterWertAlsString = BenutzerEingabe("Gib den ersten Wert als Zahl ein: ");
                string zweiterWertAlsString = BenutzerEingabe("Gib den zweiten Wert als Zahl ein: ");
                string operation = BenutzerEingabe("+ , - , * , / rechnen?: ");


        // Convertierung der beiden Werte von String zu Double

                double ersterWert = Convert.ToDouble(ersterWertAlsString);
                double zweiterWert = Convert.ToDouble(zweiterWertAlsString);

        // Abfrage der "operation" nach (+ | - | * | / )
        // Führe je nach Eingabe der "operation" die entsprechende Methode aus, z. B. "Addieren"
        // Berechnung des Resultates "resultat" und gebe dieses anschnließend als Zeichenkette aus

                double resultat = 0;
                if (operation == "+")
                {
                    resultat = Addieren(ersterWert, zweiterWert);
                    Console.WriteLine("Die Summe lautet: {0}", resultat);
                }
                else if (operation == "-")
                {
                    resultat = Subtrahieren(ersterWert, zweiterWert);
                    Console.WriteLine("Die Differenz lautet: {0}", resultat);
                }
                else if (operation == "*")
                {
                    resultat = Multiplizieren(ersterWert, zweiterWert);
                    Console.WriteLine("Das Produkt lautet: {0}", resultat);
                }
                else if (operation == "/")
                {
                    resultat = Dividieren(ersterWert, zweiterWert);
                    Console.WriteLine("Die Differenz lautet: {0}", resultat);
                }
                else
                {
                    Console.WriteLine("Bitte überprüfe deine Eingaben. Es wird nur ( + | - | / | * | / ) unterstützt.");
                }


        // Ergebnis ausgeben (ähnlich wie oben, nur andere Schreibweise)

                Console.WriteLine("oder andere Schreibweise... ");
                Console.WriteLine("Das Ergebnis lautet: {0}", resultat);
                Console.WriteLine("");

        // Nachdem das Resultat ausgegeben wurde, wird der Benutzer durch die Methode "FrageNachWeitererBerechnung" gefragt, ob er eine weitere Berechnung durchführen möchte

                FrageNachWeitererBerechnung();

            }

        // rechenAuswahl == 2 : Der Benutzer kann nun die Flächenberechnung nutzen. (Fläche = Länge * Breite)

            else if (rechenAuswahl == "2")
            {
                
                Console.WriteLine("Du kannst jetzt Flächen berechnen.");
                string laengeAlsString = BenutzerEingabe("Gib die Länge ein: ");
                string breiteAlsString = BenutzerEingabe("Gib die Breite ein: ");

        // Convertierung der Werte Länge und Breite als String zu Double

                double laenge = Convert.ToDouble(laengeAlsString);
                double breite = Convert.ToDouble(breiteAlsString);

        // Berechnung der beiden Werte Länge und Breite

                double flaeche = FlaecheBerechnen(laenge,breite);
                Console.WriteLine("Die Fläche beträgt: {0}", flaeche);


        // Nachdem das Resultat ausgegeben wurde, wird der Benutzer durch die Methode "FrageNachWeitererBerechnung" gefragt, ob er eine weitere Berechnung durchführen möchte

                FrageNachWeitererBerechnung();

            }

        // rechenAuswahl == 3 : Der Benutzer kann nun die Volumenberechnung nutzen. (Volumen = Länge * Breite * Höhe)

            else if (rechenAuswahl == "3")
            {
                Console.WriteLine("Du kannst jetzt Volumen berechnen.");
                string laengeAlsString = BenutzerEingabe("Gib die Länge ein: ");
                string breiteAlsString = BenutzerEingabe("Gib die Breite ein: ");
                string hoeheAlsString = BenutzerEingabe("Gib die Höhe ein: ");


        // Convertierung der Werte Länge, Breite, Höhe von String zu Double

                double laenge = Convert.ToDouble(laengeAlsString);
                double breite = Convert.ToDouble(breiteAlsString);
                double hoehe = Convert.ToDouble(hoeheAlsString);


        // Ausführung der Berechnung

                double volumen = laenge * breite * hoehe;
                Console.WriteLine("Das Volumen beträgt: {0}", volumen);

        // Nachdem das Resultat ausgegeben wurde, wird der Benutzer durch die Methode "FrageNachWeitererBerechnung" gefragt, ob er eine weitere Berechnung durchführen möchte

                FrageNachWeitererBerechnung();

            }


        // Beendet das Programm

            else if (rechenAuswahl == "0")
            {
                BeendeProgramm();
            }


        // Wenn ein anderer Wert als (1 | 2 | 3 | 0) eingegeben wurde, bekommt der Benutzer den Hinweis, dass nur die Werte  (1 | 2 | 3) benutzt werden können

            else
            {
                Console.Clear();
                Console.WriteLine("Bitte überprüfe deine Eingaben. Achte dass du bei der Eingabe die Werte 0 - 3 verwendest.");
                Console.WriteLine("");
                RechenMethodeAuswahl();
            }
      
            string methodeAuswahl = Console.ReadLine();
            return methodeAuswahl;
        }

        // Warte auf Eingabe des Benutzers

        static string BenutzerEingabe(string textAusgabe)
        {
            Console.Write(textAusgabe);
            string benutzerEingabe = Console.ReadLine();
            return benutzerEingabe;
        }

        // Fragt den Benutzer ob er eine weitere Berechnung durchführen möchte
        // Ja = Der Inhalt der Console wird gelöscht und das Programm fragt den Benutzer wie zu Anfang des Programms, was er berechnen möchte
        // Nein = Das Programm wird beendet

        static string FrageNachWeitererBerechnung()
        {
            Console.WriteLine("Möchtest du eine erneute Berechnung durchführen?");

            string benutzerEingabe = BenutzerEingabe("Ja | Nein: ");
            
            if (benutzerEingabe == "Ja")
            {
                Console.Clear();
                RechenMethodeAuswahl();
            }
            else if (benutzerEingabe == "Nein")
            {
                BeendeProgramm();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe, bitte überprüfe deine Eingaben.");
                FrageNachWeitererBerechnung();
            }
            return benutzerEingabe;
        }

        // Methode um den ersten Summanden mit dem zweiten Summanden zu addieren. Das Ergebnis ist hier die Summe

        static double Addieren(double ersterSummand, double zweiterSummand)
        {
            double summe = (ersterSummand + zweiterSummand);
            return summe;
        }

        // Methode um den Minuend von dem Subtrahend abzuziehen. Das Ergebnis ist hier die Differenz

        static double Subtrahieren(double minuend, double subtrahend)
        {
            double differenz = (minuend - subtrahend);
            return differenz;
        }

        // Methode um den Dividend durch den Divisor zu teilen. Das Ergebnis ist hier der Quotient
        
        static double Dividieren(double dividend, double divisor)
        {
            double quotient = (dividend / divisor);
            return quotient;
        }

        // Methode um den Faktor A mit dem Faktor B zu multiplizieren. Das Ergebnis ist hier das Produkt

        static double Multiplizieren(double faktorA, double faktorB)
        {
            double produkt = (faktorA * faktorB);
            return produkt;
        }

        // Methode um die Fläche zu berechnen

        static double FlaecheBerechnen(double laenge, double breite)
        {
            double flaeche = (laenge * breite);
            return flaeche;
        }

        // Methode um das Volumen zu berechnen

        static double Volumen(double laenge, double breite, double hoehe)
        {
            double volumen = (laenge * breite * hoehe);
            return volumen;
        }

        // Beendet das Programm nach drücken der Enter Taste

        static void BeendeProgramm()
        {
            Console.WriteLine("Drücke Enter um das Programm zu beenden...");
        }

    }
}
