using System;
using System.Collections.Generic;

namespace MaestroDetalle.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int IdCompra { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? RazonSocial { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
