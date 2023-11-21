using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var numerosPares = from numero in numeros
                           where numero % 2 == 0
                           select numero;

        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}
