using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
		// Accede a la BDD mediante la clase AccesoDatos, setea una consulta y la ejecuta en el try catch
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos conexion = new AccesoDatos();
			conexion.SeterarConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS");

			try
			{
				conexion.EjecutarLectura();

				while (conexion.Lector.Read())
				{
					Articulo aux = new Articulo();

					aux.Id = (int)conexion.Lector["Id"];
					aux.Codigo = (string)conexion.Lector["Codigo"];
					aux.Nombre = (string)conexion.Lector["Nombre"];
					aux.Descripcion = (string)conexion.Lector["Descripcion"];
					aux.MarcaProducto.Id = (int)conexion.Lector["IdMarca"];
					aux.CategoriaProducto.Id = (int)conexion.Lector["IdCategoria"];

					// Respecto a precio voy a preguntar en el foro si conviene tratarlo como decimal o como float
					aux.Precio = (float)(decimal)conexion.Lector["Precio"];

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
				conexion.CerrarConexion();
			}
        }
    }
}
