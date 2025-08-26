using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
        // Nome do héroi
        Console.WriteLine("Digite o nome do héroi: ");
        string heroi = Console.ReadLine();

        // Quantidade de xp do héroi
        Console.WriteLine("Digite a quantidade de XP do héroi: ");
        int xp = int.Parse(Console.ReadLine());
        
        string nivel;
           if (xp < 11)
            {
                nivel = "Estagiário";
            }
            else if (xp >= 11 &&xp < 1000)
            {
                nivel = "Ferro";
            }
            else if (xp >= 1001 && xp <=2000)
            {
                nivel = "Bronze";
            }
            else if (xp >= 2001 && xp <=5000)
            {
                nivel = "Prata";
            }
            else if (xp >= 5001 && xp <=7000)
            {
                nivel = "Ouro";
            }
            else if (xp >= 7001 && xp <=8000)
            {
                nivel = "Platina";
            }           
            else if (xp >= 8001 && xp <=9000)
            {
                nivel = "Ascendente";
            }
              else if (xp >= 9001 && xp <=10000)
            {
                nivel = "Imortal";
            }
            else
            {
                nivel = "Radiante";
            }
            
            //Saída
            Console.WriteLine($"Nome do hérói {heroi} experiência nível {nivel}");
            
         }          
    }
}
