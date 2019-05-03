using System;

namespace Nullable
{
    class Cliente
    {
        public string Nombre;
        public int NroCompras;
        public decimal MontoCompras;
        public DateTime PrimeraCompra;
        public DateTime UltimaCompra;

        public Cliente()
        {
            Nombre = null;
            NroCompras = int.MaxValue;
            MontoCompras = decimal.MaxValue;
            PrimeraCompra = DateTime.MinValue;
            UltimaCompra = DateTime.MinValue;
        }

        public override string ToString() =>
            "\nCliente: " + (Nombre != null ? Nombre : "Sin nombre") +
            "\nNro de Compras: " + (NroCompras != int.MaxValue ? NroCompras.ToString() 
                                                                : "Sin compras") +
            "\nMonto de Compras: " + (MontoCompras != decimal.MaxValue ? "$" + MontoCompras.ToString() 
                                                                : "Sin compras") +
            "\nPrimera Compra: " + (PrimeraCompra != DateTime.MinValue ? PrimeraCompra.ToString() 
                                                                : "No hay fecha de primera compra") +
            "\nUltima Compra: " + (UltimaCompra != DateTime.MinValue ? UltimaCompra.ToString() 
                                                                : "No hay fecha de última compra");
    }
}
