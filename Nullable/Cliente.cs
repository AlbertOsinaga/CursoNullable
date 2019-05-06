using System;

namespace Nullable
{
    class Cliente
    {
        public string Nombre;
        public int NroCliente;
        public int? NroCompras;             // int? = Nullable<int>
        public decimal? MontoCompras;       // decimal? = Nullable<decimal>
        public DateTime? PrimeraCompra;     // DateTime? = Nullable<DateTime>
        public DateTime? UltimaCompra;

        public Cliente()
        {
            Nombre = null;
            NroCliente = 0;
            NroCompras = new int?();
            MontoCompras = null;
            PrimeraCompra = null;
            UltimaCompra = null;
        }

        public override string ToString() =>
            "\nCliente: " + (Nombre != null ? Nombre : "Sin nombre") +
            $"\nNro Cliente: {NroCliente}" + 
            "\nNro de Compras: " + (NroCompras.HasValue ? NroCompras.Value.ToString() 
                                                        : "Sin compras") +
            "\nMonto de Compras: " + (MontoCompras != null ? "$" + MontoCompras.Value.ToString() 
                                                            : "Sin compras") +
            "\nPrimera Compra: " + (PrimeraCompra.HasValue ? PrimeraCompra.Value.ToString() 
                                                           : "No hay fecha de primera compra") +
            "\nUltima Compra: " + (UltimaCompra.HasValue ? UltimaCompra.Value.ToString() 
                                                           : "No hay fecha de última compra");
    }
}
