using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oszthat
{
    public class feladat
    {
        string bekérés;
        int szam;
        int a = 1;
        public feladat() {}

        public void setSzam()
        {
            while (this.a == 1)
            {
                Console.WriteLine("Számot kérek");
                bekérés = Console.ReadLine();
                this.a = 0;
                
            }
          


        }
        public void getSzám()
        {
            if (szam % 3 == 0)
            {
                Console.WriteLine("Három");
            }
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
