using System;

namespace Patron_Prototype
{
    public class Person
    {
        public int Age;
        public DateTime dateNaissance;
        public string Nom;
        public IdInfo IdInfo;
        //copy standar
        public Person Copy()
        {
            return (Person)this.MemberwiseClone();
        }
        //copy profonde
        public Person CopyTotal()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Nom = string.Copy(Nom);
            return clone;
        }
    }
    public class IdInfo
    {
        public int IdNumber;
        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 30;
            p1.dateNaissance = Convert.ToDateTime("1990-05-31");
            p1.Nom = "Billy Kid";
            p1.IdInfo = new IdInfo(13);

            Person p2 = p1.Copy();

            Person p3 = p1.CopyTotal();

            Console.WriteLine("valeur p1:");
            affichage(p1);
            Console.WriteLine("valeur p2:");
            affichage(p2);
            Console.WriteLine("valeur p3:");
            affichage(p3);

            // modification de p1 et réaffichage
            p1.Age = 45;
            p1.dateNaissance = Convert.ToDateTime("1975-05-10");
            p1.Nom=("Jack");
            p1.IdInfo.IdNumber = 40;
            Console.WriteLine("\n modfication de p1");
            Console.WriteLine("valeur p1:");
            affichage(p1);
            Console.WriteLine("valeur p2:(id change)");
            affichage(p2);
            Console.WriteLine("valeur p3:(copy profonde ne change pas)");
            affichage(p3);


        }

        public static void affichage(Person p)
        {
            Console.WriteLine("      Nom: {0:s}, Age: {1:d}, Date de Naissance: {2:MM/dd/yy}",
                p.Nom, p.Age, p.dateNaissance);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }

}

