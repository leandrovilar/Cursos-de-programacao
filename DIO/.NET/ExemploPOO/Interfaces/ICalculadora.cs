using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.interfaces;
using ExemploPOO.Models;

namespace ExemploPOO.interfaces
{
    public interface ICalculadora
    {
        int Soma(int nun1, int nun2);
        int Subtrair(int nun1, int nun2);
        int Multiplicar(int nun1, int nun2);
        int Dividir(int nun1, int nun2);

    }
}