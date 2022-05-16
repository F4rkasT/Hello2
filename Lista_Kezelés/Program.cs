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
        string beolvas;
        string név;
        string folytatás;
        List<string> lista = new List<string>();
    public Városnevek() { }
        public void setDb()
        {
            Console.WriteLine("Hány nevet akarunk eltárolni?");
            névdarab = Convert.ToInt32(Console.ReadLine());
            if (névdarab == 0)
            {
                
            }
        }
        public void setNevek()
        {
            for (int i = 0; i < névdarab; i++)
            {
                Console.WriteLine("Kérek nevet");
                név = Console.ReadLine();
                lista.Add(beolvas);
            }
            
        }
        public void getNevek()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0},",lista[i]);
            }
            
        }
        public void getVan() 
        {
            Console.WriteLine("Kérek egy nevet");
            bool hoppá = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (beolvas == lista[i])
                {
                    hoppá = true;
                }
                else { }
            }
            if (hoppá)
            {
                Console.WriteLine("Szerepel a listában");
            }
            else
            {
                Console.WriteLine("nem szerepel a listában");
            }
        }
        public void delNev()
        {
            Console.WriteLine("kérek egy nevet");
            beolvas = Console.ReadLine();
            bool ezigen = false;
            int azigen = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (beolvas == lista[i])
                {
                    azigen = i;
                    ezigen = true;
                }
            }
            if (ezigen)
            {
                lista.RemoveAt(azigen);
                Console.WriteLine("törölve lett");
            }
            else
            {
                lista.Add(beolvas);
                Console.WriteLine("Hozzáadva");
            }

        }
        public void delLast()
        {
            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine("Utolsó elem törölve");
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
