using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio
{
    public class Articulo
    {
        public int Id {  get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; } = string.Empty;
        public string Nombre {  get; set; } = string.Empty;
        [DisplayName("Descripción")]
        public string Descripcion {  get; set; } = string.Empty;
        [DisplayName("Marca")]
        public Marca MarcaProducto { get; set; } = new Marca();
        [DisplayName("Categoría")]
        public Categoria CategoriaProducto { get; set; } = new Categoria();
        public decimal Precio { get; set; }
        public List<Imagen> listaImagenes { get; set; }= new List<Imagen>();
    }
}
