using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDePartidasRankeadas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Vitórias do jogador
            Console.WriteLine("Digite o quantidade de vitórias");
            int vitorias = int.Parse(Console.ReadLine());

            //Derrotas do jogador
            Console.WriteLine("Digite o quantidade de derrotas");
            int derrotas = int.Parse(Console.ReadLine());

            //Saldo de vitórias
            int saldoVitorias = CalcularSaldo(vitorias, derrotas);

            //Ranking do jogador
            string nivel = DeterminarRanking(vitorias);

            //Saída
            Console.WriteLine($"O Heroi tem um saldo de {saldoVitorias} e está no Ranking {nivel}");

        }
        //Função para calcular o saldo
        static int CalcularSaldo(int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }

        //Função para determinar o Ranking do jogador
        static string DeterminarRanking(int vitorias)
        {
            if (vitorias < 10)
                return "Ferro";
            else if (vitorias >= 11 && vitorias <= 20)
                return "Bronse";
            else if (vitorias >= 21 && vitorias <= 50)
                return "Prata";
            else if (vitorias >= 51 && vitorias <= 80)
                return "Ouro";
            else if (vitorias >= 81 && vitorias <= 90)
                return "Diamante";
            else if (vitorias >= 91 && vitorias <= 100)
                return "Lendário";
            else
                return "Imortal";
        }
    }
}