using System;

namespace lab1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui*/
            Console.WriteLine("Introdu valorile pentru a calcula volumul unui paralelipied dreptunghic");

            Console.Write("Lungime: ");
            double lungime = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inaltime: ");
            double inaltime = Convert.ToDouble(Console.ReadLine());

            Console.Write("Latime: ");
            double latime = Convert.ToDouble(Console.ReadLine());

            double volum = lungime * inaltime * latime;

            Console.WriteLine($"Volumul este: {volum}");

            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/
            Console.WriteLine("Introdu valorile pentru a calcula media aritmetica a trei numere");
            
            Console.Write("Primul numar: ");
            double primulNumar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Al doilea numar: ");
            double alDoileaNumar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Al treilea numar: ");
            double alTreileaNumar = Convert.ToDouble(Console.ReadLine());

            double mediaAritmetica = (primulNumar + alDoileaNumar + alTreileaNumar) / 3;

            Console.WriteLine($"Media aritmetica este: {mediaAritmetica}");

            /*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/
            Console.WriteLine("Introdu un număr întreg: ");

            int numarIntreg = Convert.ToInt32(Console.ReadLine());

            int ultimaCifraDinNumar = numarIntreg % 10;

            Console.WriteLine($"Ultima cifră a numărului este: {ultimaCifraDinNumar}");
        }
    }
}
