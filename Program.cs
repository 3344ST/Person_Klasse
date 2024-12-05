using System.ComponentModel.Design;

namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erstelle ein Programm, in dem ein User seinen Namen eingeben kann
            //erstelle eine Klasse Person, mit den Feldern Name, Alter und Beruf
            //Klasse hat zwei Methoden, einmal Methode "Begruessen", die den User mit seinem Namen begrüßt und sich selbst vorstellt.
            //zweite Methode "Info" und gibt im Format Name:... Alter:... Beruf:... die Informationen über das jeweilige Objekt aus(Person)
            //erstelle aus der Klasse Person zwei Objekte und befülle die Felder
            //erstelle dann ein Menü, in dem man auf jedes Objekt zugreifen kann und die Methode von diesen Objekten ausführen kann

            Console.WriteLine("Geben Sie Ihren Namen an: ");
            string userName = Console.ReadLine();

            Person user1 = new Person("Katharina", 41, "Fachinformatikerin");
            Person user2 = new Person("Bernd", 57, "Kleintierzüchter");



            while (true)     //Menü Erstellung
            {
                Console.WriteLine($"Wähle eine Person aus (1 - 2):\n\n1. {user1.Name}\n2. {user2.Name}");
                string input = Console.ReadLine();

                if (input == "1") Menu(user1, userName);
                else if (input == "2") Menu(user2, userName);
                else 
                {
                    Console.WriteLine("Ergebnis war nicht korrekt");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
            //user1.Begruessen(userName);
            //user1.Info();

            //user2.Begruessen(userName);
            //user2.Info();

        }

        //Methode für Menü

        public static void Menu(Person user, string userName)     //static damit ohne objektinstanzierung aufgerufen werden kann
        {
            Console.Clear();
            Console.WriteLine("Soll die Person dich begrüßen oder sollen ihre Infos ausgegeben werden (1 - 2):\n1. Begrüßung\n2. Infos");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                user.Begruessen(userName);
                Console.ReadKey();
            }
            else if (input == "2")
            {
                Console.Clear();
                user.Info();
                Console.ReadKey();
            }
        }

    }
}
