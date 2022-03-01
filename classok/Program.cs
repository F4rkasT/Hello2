using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classok
{

    class Allat
    {
        private string nev;
        private string fajta;
        private string szín;
        private int kor;

        public Allat(string nev, string fajta, string szín)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szín = szín;
        }

        public Allat()
        {
            this.nev = "Anonim";
            this.fajta = "ismeretlen";
            this.szín = "fekete";
            this.kor = 0;
        }
        public string getnev()
        {
            return this.nev;
        }
        public int getkor()
        {
            return this.kor;
        }

        public void setkor(int p)
        {
            if (p > 0 && p < 50)
            {
                this.kor = p;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Példányosítunk objektumokat
                Allat allat1 = new Allat("Bodri", "Puli", " Fekete");
                allat1.setkor(2);
                Console.WriteLine("Az állat neve: {0}, kora {1} év", allat1.getnev(), allat1.getkor());

                Allat allat2 = new Allat("Bolhás", "Komondor", "Fehér");
                allat2.setkor(3);
                Console.WriteLine("Az allat2 neve: {0}, kora {1} év", allat2.getnev(), allat2.getkor());

                Allat allat3 = new Allat();
                allat3.setkor("Vadász");
                allat3.setfajta("Agár");
                allat3.setszín("Barna");
                allat3.setkor(5);
                Console.WriteLine("\n Az állat neve: {0}, -" + "\n kora: {1} év \n fajtája: {2} \n színe {3}", allat3.getnev(), allat3.getkor(), allat3.get.fajta());
                Console.ReadKey();
    Console.
        }
        }
    }
}
