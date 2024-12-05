using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{

    //erstelle ein Programm, in dem ein User seinen Namen eingeben kann
    //erstelle eine Klasse Person, mit den Feldern Name, Alter und Beruf
    //Klasse hat zwei Methoden, einmal Methode "Begruessen", die den User mit seinem Namen begrüßt und sich selbst vorstellt.
    //zweite Methode "Info" und gibt im Format Name:... Alter:... Beruf:... die Informationen über das jeweilige Objekt aus(Person)
    //erstelle aus der Klasse Person zwei Objekte und befülle die Felder
    //erstelle dann ein Menü, in dem man auf jedes Objekt zugreifen kann und die Methode von diesen Objekten ausführen kann

    public class Person
    {
        public string Name;
        public int Alter;
        public string Beruf;
    



    public Person(string name, int alter, string beruf) 
    {
        Name = name;
        Alter = alter;
        Beruf = beruf;
    }   
            
   
    public void Begruessen(string userName)
    {
            Console.WriteLine($"Hallo User: {userName}");
            Console.WriteLine($"Ich bin {Name}");
            
    }

    public void Info()
    {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Alter: {Alter}");
            Console.WriteLine($"Beruf: {Beruf}");
            
    }  

    }
}
