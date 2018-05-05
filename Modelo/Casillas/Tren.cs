using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Casillas
{
    public class Tren : Casilla
    {
        private Tipo_Tren _tipo_tren;
        private int _precio;
        private int _penitencia_1; // 1 Tren
        private int _penitencia_2; // 2 Trenes
        private int _penitencia_3; // 3 Trenes
        private int _penitencia_4; // 4 Trenes
        private int _hipoteca;
        private int _nivel_penitencia;
        private Jugador _propietario;

        public Tren(Tipo_Tren tipo_tren, int precio, int penitencia1, int penitencia2, int penitencia3, int penitencia4, int hipoteca, 
            int posicion, Tipo_Casilla tipo_casilla, Image imagen)
        {
            this._tipo_tren = tipo_tren;
            this._precio = precio;
            this._penitencia_1 = penitencia1;
            this._penitencia_2 = penitencia2;
            this._penitencia_3 = penitencia3;
            this._penitencia_4 = penitencia4;
            this._hipoteca = hipoteca;
            this.Posicion = posicion;
            this.Tipo = tipo_casilla;
            this._nivel_penitencia = 1;
            this._propietario = null;
            this.Imagen = imagen;
        }

        public Tipo_Tren Tipo_Tren
        {
            get { return this._tipo_tren; }
        }

        public int Precio
        {
            get { return this._precio; }
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

        public int Hipoteca
        {
            get { return this._hipoteca; }
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
        public int Obtener_Penitencia(int Jugador_ID)
        {

            if (!Penitencia_Activa())
                return 0;

            if (this.Propietario.Id == Jugador_ID)
                return 0;

            int Valor_Penitencia = 0;

            if (Nivel_Penitencia == 1)
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

            return Valor_Penitencia;
        }
    }
}
