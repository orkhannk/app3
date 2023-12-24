using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək
            Console.WriteLine("bir yazi daxil edin ");
            string text = Console.ReadLine();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }
            Console.WriteLine(newText);




            //Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
            Console.WriteLine("ededler siyahisinin uzunluqunu daxil edin ");
            
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);
            int[] array = new int[n];
            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine($"{i +1}ci ededi daxil edin ");
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("axtarilan ededi daxil edin ");
            string axtarilanededStr = Console.ReadLine();
            int axtarilaneded = Convert.ToInt32(axtarilanededStr);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == axtarilaneded)
                {
                    Console.WriteLine("verilmis ededin indeksi"+ i);
                    break;
                }
            }











            //Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
            Console.WriteLine("yazilar siyahisinin uzunluqunu daxil edin :");
            string n1Str = Console.ReadLine();
            int n1 = Convert.ToInt32(n1Str);
            string[] arrayteze = new string[n1];
            for (int i = 0; i < arrayteze.Length; i++)
            {
                Console.WriteLine($"{i+1}ci yazini daxil edin");
                arrayteze[i] = Console.ReadLine();

            }
            Console.WriteLine("axtarilan herfi  daxil edin :");

            char herf = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arrayteze.Length; i++)
            {
                for (int p = 0; p < arrayteze[i].Length; p++)
                {
                    if (arrayteze[i][p] == herf)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{ count} qeder verilmis herfden var");




            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            // Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.


            Console.WriteLine("1 ci ededi daxil edin :");
            int birincieded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin :");
            int ikincieded = Convert.ToInt32(Console.ReadLine());
            bool check;
            do
            {
                Console.WriteLine("simvol daxil edin :");
                string simvol = Console.ReadLine();
                check = true;
                switch (simvol)
                {
                    case "+":
                        Console.WriteLine($"verilmis ededlerin cemi {birincieded + ikincieded}");
                        break;
                    case "-":
                        Console.WriteLine($"verilmis ededlerin cixilmasi {birincieded - ikincieded}");
                        break;
                    case "*":
                        Console.WriteLine($"verilmis ededlerin vurulmasi {birincieded * ikincieded}");
                        break;
                    case "/":
                        Console.WriteLine($"verilmis ededlerin bolunmesi {birincieded / ikincieded}");
                        break;

                    default:
                        check = false;
                        Console.WriteLine("Simvolu duzgun daxil et");
                        break;



                }
            } while (!check);
            


        }
    }
}
