using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace Nortwing.Models
{
    public class BaseDatosModel
    {
        public SQLiteConnection Conexion;
        public BaseDatosModel()
        {
            Conexion = new SQLiteConnection(Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "db3"));
            Conexion.CreateTable<ProductoModel>();
            Conexion.CreateTable<CategoriaModel>();
        }
        public int IngresarDatos(ProductoModel Producto)
        {
            return Conexion.Insert(Producto);
        }
        public int IngresarDatos(CategoriaModel Categoria)
        {
            return Conexion.Insert(Categoria);
        }
        public int EliminarDatos(ProductoModel Producto)
        {
            return Conexion.Delete(Producto);
        }
        public int EliminarDatos(CategoriaModel Categoria)
        {
            return Conexion.Delete(Categoria);
        }
        public int ActualizarDatos(ProductoModel Producto)
        {
            return Conexion.Update(Producto);
        }
        public int ActualizarDatos(CategoriaModel Categoria)
        {
            return Conexion.Update(Categoria);
        }
        public ProductoModel LeerDato(int ID)
        {
            return Conexion.Table<ProductoModel>().Where(n => n.IDProducto == ID).FirstOrDefault();
        }
        public CategoriaModel LeerDato1(int ID)
        {
            return Conexion.Table<CategoriaModel>().Where(n => n.IDCategoria == ID).FirstOrDefault();
        }
        public List<ProductoModel>LeerDatos()
        {
            return Conexion.Table<ProductoModel>().ToList();
        }
        public List<CategoriaModel> LeerDatos1()
        {
            return Conexion.Table<CategoriaModel>().ToList();
        }
        public List<ProductoModel> LeerProductoCategoria(int IDCategoria)
        {
          
            return Conexion.Table<ProductoModel>().Where(n => n.IDCategoria == IDCategoria).ToList();
        }
    }
}
