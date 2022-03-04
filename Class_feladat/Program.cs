using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_feladat
{
    class Kör
    {
        protected double Körsugar;

        public void setSugar()
        {
            Körsugar = Convert.ToDouble(Console.ReadLine());
        }
        public double getSugar()
        {
            return Körsugar;
        }
        public double getTer()
        {
            return Math.PI * (Körsugar * Körsugar);
        }
        public double getKer()
        {
            return 2 * Math.PI * Körsugar;
        }


        class Henger : Kör
        {
            private double magassag;
            public Henger() : base() { }
            public void Magasság()
            {
                magassag = Convert.ToDouble(Console.ReadLine());
            }
            public double getMagasság()
            {
                return Körsugar;
            }
            public double getTérfogat()
            {
                return Math.PI * (Körsugar * Körsugar) * magassag;
            }
            public double getAlapter()
            {
                return 2 * Math.PI * this.Körsugar * this.magassag;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kör k1 = new Kör();
                Henger Henger1 = new Henger();
                Console.WriteLine("Add meg a Kör sugarát");
                Henger1.setSugar();
                Console.WriteLine("Add meg a Henger magasságát");
                Henger1.Magasság();
                Console.WriteLine("A Kör sugara: {0}", Henger1.getSugar());
                Console.WriteLine("A Kör kerülete: {0}", Henger1.getKer());
                Console.WriteLine("A Kör területe: {0}", Henger1.getTer());
                Console.WriteLine("A henger magassága {0}", Henger1.getMagasság());
                Console.WriteLine("A henger térfogata {0}", Henger1.getTérfogat());
                Console.WriteLine("A henger alaptterülete", Henger1.getAlapter());

                Console.ReadKey();
            }
        }
    }
}
