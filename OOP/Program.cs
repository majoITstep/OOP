using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Activ 1", "activ", "nie",3,100.9F, 74.8F);
            mojDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je: {0}", mojDom.ZistiVyuzitelnostZastavanejPlochy());

            Dom susedovDom = new Dom("Activ 2", "activ", "nie", 4, 100.9F, 35.8F);
            susedovDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je: {0}", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Chata chata = new Chata("Chata 1", "pasivna","10",5,85,50,"ano a velka");

            chata.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je: {0}", chata.ZistiVyuzitelnostZastavanejPlochy());
            chata.PopisChaty();
            
            

            Console.ReadLine();

                      
        }
    }
}
