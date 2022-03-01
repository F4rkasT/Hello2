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
                Console.WriteLine("Az állat neve: {0}, kora ");
    
        }
        }
    }
}
