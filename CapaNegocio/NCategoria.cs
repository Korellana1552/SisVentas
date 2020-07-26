using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;



namespace CapaNegocio
{
    public class NCategoria
    {
        //Método que llama al método Insertar de la Capa de Datos
        //de la clase dCategoria
        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = Nombre;
            Obj.Descripcion = Descripcion;
            return Obj.Insertar(Obj);
        }
        //Método que llama al método Actualizar de la Capa de Datos
        //de la clase dCategoia
        public static string Editar(int Idcategoria, string Nombre, string Descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = Idcategoria;
            Obj.Nombre = Nombre;
            Obj.Descripcion = Descripcion;
            return Obj.Editar(Obj);
        }

        //Método que se encarga de llamar al método Eliminar
        //de la clase dCategoria
        public static string Eliminar(int Idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = Idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Método que se encarga de llamar al método ObtenerProducto
        //de la clase Producto
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataTable BuscarNombre(string TextoBuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = TextoBuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
    

