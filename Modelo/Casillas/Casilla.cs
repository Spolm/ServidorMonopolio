using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Casillas
{
    public class Casilla
    {
        private int _posicion;
        private Tipo_Casilla _tipo;
        private Image _imagen;

        public int Posicion
        {
            get { return this._posicion; }
            set { _posicion = value; }
        }
        public Tipo_Casilla Tipo
        {
            get { return this._tipo; }
            set { _tipo = value; }
        }
        public Image Imagen
        {
            get { return this._imagen; }
            set { _imagen = value; }
        }

    }
}
