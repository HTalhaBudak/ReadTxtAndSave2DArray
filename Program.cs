using System;
using System.IO;

namespace ödev
{
    class Program
    {

        static void Main(string[] args)
        {
            string[][] baglanti=new string[12][];
            string[] satirlar=File.ReadAllLines("relation.txt");  
            
            for (int i = 0; i < satirlar.Length; i++)
            {
                int j=0;
                baglanti[i]=new string[satirlar.Length];
               foreach (var item in satirlar[i])
               {   
                   baglanti[i][j]=item.ToString(); 
                   j++;
               }
            }

            for (int i = 0; i < baglanti.Length; i++)
            {
                for (int j = 0; j < baglanti[i].Length; j++)
                {
                    System.Console.Write(baglanti[i][j]);
                }
                System.Console.WriteLine("");
            }
            

            System.Console.WriteLine(baglanti[4][3]);  
            
            // foreach (var item in satirlar)
            // {
            //     foreach (var key in item)
            //     {
            //         System.Console.WriteLine(key);
            //     }
               
            // }     
         
        }
    }
}
