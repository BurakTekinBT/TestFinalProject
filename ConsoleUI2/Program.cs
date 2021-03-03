using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{  //interface, base class, abstraclar abstract klasörlere koyulacak. Referans tip tututcular o klasöre
    //concrete somut ve işi yapacak sınıflar
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());


                Console.WriteLine(productManager);
           

        }
    }
}
