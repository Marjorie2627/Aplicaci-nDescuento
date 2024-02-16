using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En una tienda efectúan un descuento a los clientes dependiendo del monto de la compra.El descuento se efectúa con base en el siguiente criterio:
//Si el monto es menor que $500 — - no hay descuento.
//Si el monto está comprendido entre $500 y $1 000 inclusive —- 5% de descuento.
//Si el monto está comprendido entre $1 000 y $7 000 inclusive —* 11% de descuento.
//Si el monto está comprendido entre $7 000 y $15 000 inclusive —* 18% de descuento.
//Si el monto es mayor a $15 000 —* 25% de descuento.


namespace AplicacionDescuento
{ 


  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Ingrese el monto de la compra: ");
        string montoInput = Console.ReadLine();

        if (!double.TryParse(montoInput, out double monto))
        {
            Console.WriteLine("El monto debe ser un número válido.");
            return;
        }

        double descuento = 0;

        if (monto >= 500 && monto <= 1000)
        {
            descuento = 0.05;
        }
        else if (monto > 1000 && monto <= 7000)
        {
            descuento = 0.11;
        }
        else if (monto > 7000 && monto <= 15000)
        {
            descuento = 0.18;
        }
        else if (monto > 15000)
        {
            descuento = 0.25;
        }

        double montoConDescuento = monto - (monto * descuento);
        Console.WriteLine("El monto a pagar es: " + montoConDescuento);
            Console.ReadKey();
    }
  }
}
