using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Casillas
{
    public class Servicio : Casilla
    {
        private Tipo_Servicio _tipo_servicio;
        private int _precio;
        private int _hipoteca;
        private int _nivel_penitencia;
        private Jugador _propietario;

        public Servicio(Tipo_Servicio tipo_servicio, int precio, int hipoteca, int posicion, Tipo_Casilla tipo_casilla, Image imagen)
        {
            this._tipo_servicio = tipo_servicio;
            this._precio = precio;
            this._hipoteca = hipoteca;
            this.Posicion = posicion;
            this.Tipo = tipo_casilla;
            this.Imagen = imagen;
            this._nivel_penitencia = 1;
            this._propietario = null;
        }

        public Tipo_Servicio Tipo_Servicio
        {
            get { return this._tipo_servicio; }
        }

        public int Precio
        {
            get { return this._precio; }
        }

        public int Hipoteca
        {
            get { return this._hipoteca; }
        }

        public Jugador Propietario
        {
            get { return this._propietario; }
            set { this._propietario = value; }
        }

        public int Nivel_Penitencia
        {
            get { return this._nivel_penitencia; }
            set { this._nivel_penitencia = value; }
        }

        public bool Penitencia_Activa()
        {
            if (this.Propietario != null)
                return true;

            return false;
        }

        public int Obtener_Penitencia(int Valor_Dado, int Jugador_ID)
        {

            if (!Penitencia_Activa())
                return 0;

            if (this.Propietario.Id == Jugador_ID)
                return 0;

            if (Nivel_Penitencia == 1)
                return (Valor_Dado * 4);
            else
                return (Valor_Dado * 10);
            
            
        }
    }
}
