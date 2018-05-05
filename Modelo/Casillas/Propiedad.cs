using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Casillas
{
    public class Propiedad : Casilla
    {
        private string _nombre;
        private Color_Propiedad _color;
        private int _precio;
        private int _penitencia_0; //Alquiler 
        private int _penitencia_1; // 1 casa
        private int _penitencia_2; // 2 casas
        private int _penitencia_3; // 3 casas
        private int _penitencia_4; // 4 casas
        private int _penitencia_5; // Hotel
        private int _hipoteca;
        private int _precio_casa;
        private int _precio_hotel;
        private int _nivel_penitencia;
        private Jugador _propietario;

        public Propiedad(string nombre, Color_Propiedad color, int precio, int penitencia0, int penitencia1, int penitencia2, int penitencia3, int penitencia4,
            int penitencia5, int hipoteca, int precio_casa, int precio_hotel, int posicion, Tipo_Casilla tipo, Image imagen)
        {
            this._nombre = nombre;
            this._color = color;
            this._precio = precio;
            this._penitencia_0 = penitencia0;
            this._penitencia_1 = penitencia1;
            this._penitencia_2 = penitencia2;
            this._penitencia_3 = penitencia3;
            this._penitencia_4 = penitencia4;
            this._penitencia_5 = penitencia5;
            this._hipoteca = hipoteca;
            this._precio_casa = precio_casa;
            this._precio_hotel = precio_hotel;
            this.Posicion = posicion;
            this.Tipo = tipo;
            this._nivel_penitencia = 0;
            this._propietario = null;
            this.Imagen = imagen;
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public Color_Propiedad Color
        {
            get { return this._color; }
        }

        public int Precio
        {
            get { return this._precio; }
        }

        public int Penitencia_0
        {
            get { return this._penitencia_0; }
        }

        public int Penitencia_1
        {
            get { return this._penitencia_1; }
        }

        public int Penitencia_2
        {
            get { return this._penitencia_2; }
        }

        public int Penitencia_3
        {
            get { return this._penitencia_3; }
        }

        public int Penitencia_4
        {
            get { return this._penitencia_4; }
        }

        public int Penitencia_5
        {
            get { return this._penitencia_5; }
        }

        public int Hipoteca
        {
            get { return this._hipoteca; }
        }

        public int Precio_Casa
        {
            get { return this._precio_casa; }
        }

        public int Precio_Hotel
        {
            get { return this._precio_hotel; }
        }

        public int Nivel_Penitencia
        {
            get { return this._nivel_penitencia; }
            set { this._nivel_penitencia = value; }
        }

        public Jugador Propietario
        {
            get { return this._propietario; }
            set { this._propietario = value; }
        }

        public bool Penitencia_Activa()
        {
            if (this.Propietario != null)
                return true;

            return false;
        }
        public int Obtener_Penitencia(int Jugador_ID) {

            if (!Penitencia_Activa())
                return 0;

            if (this.Propietario.Id == Jugador_ID)
                return 0;

            int Valor_Penitencia = 0;

            if (Nivel_Penitencia == 0)
            {
                Valor_Penitencia = this.Penitencia_0;
            }
            else if (Nivel_Penitencia == 1)
            {
                Valor_Penitencia = this.Penitencia_1;
            }
            else if (Nivel_Penitencia == 2)
            {
                Valor_Penitencia = this.Penitencia_2;
            }
            else if (Nivel_Penitencia == 3)
            {
                Valor_Penitencia = this.Penitencia_3;
            }
            else if (Nivel_Penitencia == 4)
            {
                Valor_Penitencia = this.Penitencia_4;
            }
            else if (Nivel_Penitencia == 5)
            {
                Valor_Penitencia = this.Penitencia_5;
            }

            return Valor_Penitencia;
        }
    }
}
