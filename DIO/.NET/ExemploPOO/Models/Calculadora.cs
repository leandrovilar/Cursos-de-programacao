using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int nun1, int nun2)
        {
            return nun1 / nun2;
        }

        public int Multiplicar(int nun1, int nun2)
        {
            return nun1 * nun2;
        }

        public int Soma(int nun1, int nun2)
        {
            return nun1 + nun2;
        }

        public int Subtrair(int nun1, int nun2)
        {
            return nun1 - nun2;
        }
    }

}