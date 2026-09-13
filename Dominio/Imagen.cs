using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dominio
{
    public class Imagen
    {
        public int Id {  get; set; }
        public int IdArticulo { get; set; }
        public string Url { get; set; } = string.Empty;

        public Imagen()
        {

        }

        public Imagen(string urlImagen)
        {
            this.Url = urlImagen;
        }
    }
}
