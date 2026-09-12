using System;
using System.Collections.Generic;
using System.Text;
using Dominio; 


namespace Negocio
{
    public class MarcaNegocio
    {
        //metodo listar : devuelve las marcas de la base de datos. 

        public List <Marca> Listar ()
        {
            // se crea la lista vacia 
            List<Marca> lista = new List<Marca>();

            AccesoDatos datos = new AccesoDatos();

           try
            {
                datos.SeterarConsulta ("Select Id, Descripcion From Marcas");

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];

                    //agregamos el objeto a la lista ; 
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
                datos.CerrarConexion();
            }

        }
        // inserta una nueva marca en la b de datos ; 
        public void Agregar (Marca nueva )
        {
            AccesoDatos datos = new AccesoDatos(); 

            try
            {
                datos.limpiarParametros();
                datos.SeterarConsulta("Insert into Marcas (Descripcion) values (@Descripcion)");
                datos.agregarParametro("@Descripcion", nueva.Nombre);
                datos.ejecutarAccion();

            }
            catch (Exception)
            {
                
                throw;
            }
            // no hace falta finally porque el metodo ejecutarAccion ya cierra la conexion.


        }


    }
}
