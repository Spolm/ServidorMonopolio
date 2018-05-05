using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Tarjetas
{
    public class Tarjeta_Arca
    {
        private int _id;
        private Efecto_Arca _efecto;
        private string _texto;

        public Tarjeta_Arca(int id, Efecto_Arca efecto, string contenido)
        {
            this._id = id;
            this._efecto = efecto;
            this._texto = contenido;
        }

        public int ID
        {
            get { return this._id; }
        }

        public Efecto_Arca Efecto
        {
            get { return this._efecto; }
        }

        public string Contenido
        {
            get { return this._texto; }
        }
    }
}
