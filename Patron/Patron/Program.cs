using System;
using System.Runtime.InteropServices;

namespace Patron
{
    // patron Fabrique
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var procduct = FactoryMethod();

            var result = "Créateur : Le code du même créateur vient de fonctionner avec" + procduct.Operation();

            return result;
        }
    }

    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
    public interface IProduct
    {
        string Operation();
    }

    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Resultat de ContreteProduct1}";
        }
    }
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Resultat de ContreteProduct2}";
        }
    }
    class client
    {
        public void Main()
        {
            Console.WriteLine("app: Lancer avec le ConcreteCreator1");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("app: Lancer avec le ConcreteCreator2");
            ClientCode(new ConcreteCreator2());
        }
        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client : Je ne connais pas la classe du créateur" + ", mais cela fonctionne.\n" + creator.SomeOperation());
        }

    }

  
    class Program
    {
        static void Main(string[] args)
        {
            new client().Main();
        }
    }
}
