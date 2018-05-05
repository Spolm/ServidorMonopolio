using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo
{
    public class Banco
    {
        private int _casas;
        private int _hoteles;

        public Banco()
        {
            this._casas = 32;
            this._hoteles = 12;
        }

        public int Casas
        {
            get { return this._casas; }
            set { this._casas = value; }
        }

        public int Hoteles
        {
            get { return this._hoteles; }
            set { this._hoteles = value; }
        }
    }
}
