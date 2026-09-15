using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Dominio
{
    public class Imagen
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
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
