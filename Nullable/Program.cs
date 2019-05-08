using System;
using static System.Console;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            OperadoresEspeciales.Run();
            //Cliente cliente = new Cliente()
            //{
            //    Nombre = "Juan Lopez",
            //    NroCliente = 1001,
            //    NroCompras = 10,
            //    MontoCompras = 1560M,
            //    PrimeraCompra = new DateTime(2018, 5, 23)
            //};
            //WriteLine($"\nCliente después de construido:\n {cliente}");

            //cliente.NroCompras++;
            //cliente.MontoCompras += 250M;
            //WriteLine($"\nCliente después de cambios:\n {cliente}");

            //int nroCompras = (int) cliente.NroCompras;
            //WriteLine($"\nnro de compras del cliente:\n {nroCompras}");
            //LiftedOperadores.Run();
            //ConversionesNullables.Run();
        }
    }
}
