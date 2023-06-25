using System;

namespace lab1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EX1: Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui*/
            Console.WriteLine("Introdu valorile pentru a calcula volumul unui paralelipied dreptunghic");

            Console.Write("Lungime: ");
            double lungime = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inaltime: ");
            double inaltime = Convert.ToDouble(Console.ReadLine());

            Console.Write("Latime: ");
            double latime = Convert.ToDouble(Console.ReadLine());

            double volum = lungime * inaltime * latime;

            Console.WriteLine($"Volumul este: {volum}");

            /*EX2: Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/
            Console.WriteLine("Introdu valorile pentru a calcula media aritmetica a trei numere");
            
            Console.Write("Primul numar: ");
            double primulNumar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Al doilea numar: ");
            double alDoileaNumar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Al treilea numar: ");
            double alTreileaNumar = Convert.ToDouble(Console.ReadLine());

            double mediaAritmetica = (primulNumar + alDoileaNumar + alTreileaNumar) / 3;

            Console.WriteLine($"Media aritmetica este: {mediaAritmetica}");

            /*EX3: Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/
            Console.Write("Introdu un număr întreg să afli ultima cifră a acelui număr: ");

            int numarIntreg = Convert.ToInt32(Console.ReadLine());

            int ultimaCifraDinNumar = numarIntreg % 10;

            Console.WriteLine($"Ultima cifră a numărului este: {ultimaCifraDinNumar}");

            /*EX4: Scrieti un program care va afisa semnul unui numar citit de la tastatura*/
            Console.WriteLine("Introdu un număr să afli dacă este pozitiv sau negativ");
            double numarPozitivSauNegativ = Convert.ToDouble(Console.ReadLine());

            if (numarPozitivSauNegativ > 0)
            {
                Console.WriteLine("Numar pozitiv");
            }
            else if (numarPozitivSauNegativ < 0)
            {
                Console.WriteLine("Numar negativ");
            }
            else
            {
                Console.WriteLine("Numarul este zero");
            }

            /*EX5: Se citesc doua numere de la tastatura, x,y . Scrieti un program care va afisa cele doua valori in ordine crescatoare*/            
            Console.WriteLine("Introdu doua numere să afli ordinea crescatoare");

            Console.Write("Introdu un număr x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introdu un număr y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"Ordinea crescatoarea este: {y}, {x}");
            }
            else
            {
                Console.WriteLine($"Ordinea crescatoarea este: {x}, {y}");
            }

            /*EX6: Se citesc trei numere de la tastatura , x,y,z . Scrieti un program care va afisa cele trei valori in ordine descrescatoare*/
            Console.WriteLine("Introdu trei numere să afli ordinea descrescatoare");

            Console.Write("Introdu un număr a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introdu un număr b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introdu un număr c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double celMaiMare = Math.Max(a, Math.Max(b, c));
            double celMaiMic = Math.Min(a, Math.Min(b, c));
            double numarMijloc = a + b + c - celMaiMare - celMaiMic;

            Console.WriteLine($"Ordinea descrescătoare este: {celMaiMare}, {numarMijloc}, {celMaiMic}");

            /*EX7: Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar*/
            Console.WriteLine("Introdu un număr să afli dacă este impar sau par");
            int numarParSauImpar = Convert.ToInt32(Console.ReadLine());

            if (numarParSauImpar % 2 == 0)
            {
                Console.WriteLine("Numărum este par");
            } 
            else
            {
                Console.WriteLine("Numărum este impar");
            }

            /*EX8: Scrieti un program care interschimba valoarea a doua variabile intregi*/
            Console.WriteLine("Introdu un număr întreg să afli cum se scrie");
            Console.Write("Variabila 1: ");
            int primaVariabila = Convert.ToInt32(Console.ReadLine());

            Console.Write("Variabila 2: ");
            int aDouaVariabila = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Valorile inițiale: Variabila 1 = {primaVariabila}, Variabila 2 = {aDouaVariabila}");
            int variablilaTemporara = primaVariabila;
            primaVariabila = aDouaVariabila;
            aDouaVariabila = variablilaTemporara;

            Console.WriteLine($"Valorile interschimbate: Variabila 1 = {primaVariabila}, Variabila 2 = {aDouaVariabila}");


            /*EX9: Folosind instructiunea switch, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele*/
            Console.WriteLine("Introdu un număr întreg să afli cum se scrie în litere");
            int numarInLitere = Convert.ToInt32(Console.ReadLine());

            switch (numarInLitere)
            {
                case 1:
                    Console.WriteLine("unu");
                    break;
                case 2:
                    Console.WriteLine("doi");
                    break;
                case 3:
                    Console.WriteLine("trei");
                    break;
                case 5:
                    Console.WriteLine("cinci");
                    break;
                case 8:
                    Console.WriteLine("opt");
                    break;
                default:
                    Console.WriteLine("neidentificat");
                    break;
             }

        }
    }
}
