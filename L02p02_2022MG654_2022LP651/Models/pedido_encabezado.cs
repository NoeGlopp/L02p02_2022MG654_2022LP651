﻿using System.ComponentModel.DataAnnotations;

namespace L02p02_2022MG654_2022LP651.Models
{
    public class pedido_encabezado
    {
        [Key]

        public int id { get; set; }

        public int id_cliente { get; set; }

        public int cantidad_libros { get; set; }

        public decimal total { get; set; }
    }
}