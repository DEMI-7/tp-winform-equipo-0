using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos conexion = new AccesoDatos();
            conexion.SeterarConsulta("SELECT Id, IdArticulo, ImagenUrl as Url from IMAGENES");

            try
            {
                conexion.EjecutarLectura();

                while (conexion.Lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.Id = (int)conexion.Lector["Id"];
                    aux.IdArticulo = (int)conexion.Lector["IdArticulo"];
                    aux.Url = (string) conexion.Lector["Url"];

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

        public void GuardarImagen(int idArticulo, string url)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SeterarConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo,@ImagenUrl)");
                conexion.agregarParametro("@IdArticulo", idArticulo);
                conexion.agregarParametro("@ImagenUrl", url);
                conexion.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
