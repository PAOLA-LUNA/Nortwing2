using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Nortwing.Models
{
    [Table("Producto")]
     public class ProductoModel
    {
        [PrimaryKey,AutoIncrement,Unique]
        public string NombreProducto { get; set; }
        public int IDProducto { get; set; }
        public int IDCategoria { get; set; }

    }
}
