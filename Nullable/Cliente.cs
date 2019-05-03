using System;

namespace Nullable
{
    class Cliente
    {
        public string Nombre;
        public int NroCliente = 0;
        public MiNullable<int> NroCompras;
        public MiNullable<decimal> MontoCompras;
        public MiNullable<DateTime> PrimeraCompra;
        public MiNullable<DateTime> UltimaCompra;

        public Cliente() => Nombre = null;

        public override string ToString() =>
            "\nCliente: " + (Nombre != null ? Nombre : "Sin nombre") +
            $"\nNro Cliente: {NroCliente}" + 
            "\nNro de Compras: " + (NroCompras.HasValue ? NroCompras.Value.ToString() 
                                                        : "Sin compras") +
            "\nMonto de Compras: " + (MontoCompras.HasValue ? "$" + MontoCompras.Value.ToString() 
                                                            : "Sin compras") +
            "\nPrimera Compra: " + (PrimeraCompra.HasValue ? PrimeraCompra.Value.ToString() 
                                                           : "No hay fecha de primera compra") +
            "\nUltima Compra: " + (UltimaCompra.HasValue ? UltimaCompra.Value.ToString() 
                                                           : "No hay fecha de última compra");
    }
}
