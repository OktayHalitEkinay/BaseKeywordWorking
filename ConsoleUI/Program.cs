using ClassLibrary.Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = new EntityManager();
            Console.WriteLine(entityManager.Add().Message); 
            Console.WriteLine(entityManager.Add().Success); 
        }
    }
}
