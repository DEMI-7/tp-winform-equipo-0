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
			conexion.SeterarConsulta("SELECT Art.Id, Art.Codigo, Art.Nombre, Art.Descripcion, Art.IdMarca, Mar.Descripcion AS Marca, Art.IdCategoria, Cat.Descripcion AS Categoria, Art.Precio FROM ARTICULOS Art INNER JOIN MARCAS Mar ON Art.IdMarca = Mar.Id INNER JOIN CATEGORIAS Cat ON Art.IdCategoria = Cat.Id");

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
					aux.MarcaProducto.Nombre = (string)conexion.Lector["Marca"];

					aux.CategoriaProducto.Id = (int)conexion.Lector["IdCategoria"];
					aux.CategoriaProducto.Nombre = (string)conexion.Lector["Categoria"];

					aux.Precio = (decimal)conexion.Lector["Precio"];

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
