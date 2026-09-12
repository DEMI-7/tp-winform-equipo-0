using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Negocio
{ //use de referencia la clase ArticuloNegocio
    public class CategoriaNegocio
    {
      
        public List<Categoria> Listar()
        {  //creo lista vacia para guardar categorias
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos conexion = new AccesoDatos();  // conectamos a bd
            conexion.SeterarConsulta(
                "SELECT Id, Descripcion FROM CATEGORIAS"); //traigo solo id y descripcion desde categorias
            try
            {
                conexion.EjecutarLectura();
                while (conexion.Lector.Read()) //recorremos los resultados y guaradmos en aux para convertirlos y agregarlos a la lista
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Nombre = (string)conexion.Lector["Descripcion"]; //este es el nombre, en sql esta nombrado como descripcion
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.CerrarConexion(); //cerramos conxion con la bd
            }
        }
    }
}
