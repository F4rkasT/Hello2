using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Készitsünk oszályt városnevek tárolására
Metódusok:
setDb:bekérjük hogy hány nevet akarunk eltárolni. Ha semmit vagy 0-át ír be a felhasználó, akkor a beolvasást addig folytatjuk, amíg üres mezőt nem ír be.
setNevek:Bekérjük a neveket az előbb megadott módon beolvassuk és hozzáadjuk a listához
getNevek:kiiratjuk vesszővel elválasztva a letárolt neveket
getVan:Bekérünk egy nevet és kiirjuk hogy szerepel-e a listában
delNev: Bekérünk egy nevet.  Ha szerepel a listában, akkor töröljük, ha nem, akkor hozzáadjuk.
delLast:kitörli a listában lévő utolsó elemet*/
namespace Lista_Kezelés
{
    public class Városnevek 
    {
        int névdarab = 0;
        string név;
        List<string> lista = new List<string>();
    public Városnevek() { }
        public void setDb()
        {
            Console.WriteLine("Hány nevet akarunk eltárolni?");
            névdarab = Convert.ToInt32(Console.ReadLine());
            if (névdarab == 0)
            {
                Console.WriteLine("Város neveit kérem: ");
                do
                {
                    for (int i = 0; i <= névdarab; i++)
                    {
                        név = Console.ReadLine();
                        lista.Add(név);
                    }
                } while (név != "");
            }

        }
        public void setNevek()
        {
            for (int i = 0; i < névdarab; i++)
            {
                név = Console.ReadLine();
                lista.Add(név);
            }
            
        }
        public void getNevek()
        {
            Console.WriteLine("lista elemei:");
            foreach (var item in lista)
            {
                Console.Write("{0}, ", item);
            }
        }
        public void getVan()
        {
            string beker;
            Console.WriteLine("Kérem a város nevét!");
            beker = Console.ReadLine();
            if (lista.Contains(beker))
            {
                Console.WriteLine("Szerepel a listában");
            }
            else
            {
                Console.WriteLine("Nem szerepel a listában");
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void delNev()
        {
            string bekér;
            Console.WriteLine("kérek egy nevet");
            bekér = Console.ReadLine();
            if (lista.Contains(bekér))
            {
                Console.Write("A név szerepel a listában ezért törölve.");
                lista.Remove(bekér);
            }
            else
            {
                Console.WriteLine("A név nem szerepel a listában ezért hozzá lett adva");
                lista.Add(bekér);
            }
            Console.WriteLine("Az elemek: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void delLast()
        {
            string last = lista[lista.Count - 1];
            lista.Remove(last);
            Console.WriteLine("Utolsó elem törölve");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Városnevek vege = new Városnevek();
            vege.setDb();
            vege.setNevek();
            vege.getNevek();
            vege.getVan();
            vege.delNev();
            vege.delLast();
            Console.ReadKey();
            
        }
    }
}
