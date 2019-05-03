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


        public override string ToString() => $"\nCliente: {Nombre}" +
                                            $"\nNro de Compras: {NroCompras}" +
                                            $"\nMontoCompras: {MontoCompras}" +
                                            $"\nPrimeraCompra: {PrimeraCompra}" +
                                            $"\nUltimaCompra: {UltimaCompra}";
    }
}
