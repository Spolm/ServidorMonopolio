using ServidorMonopolio.Conexion.Mensajes.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes
{
    public class Paquete : IMensajeServidor
    {
        private string[] _mensaje;

        public Paquete()
        {
            _mensaje = new string[0];
        }

        public string[] GetMensaje()
        {
            return _mensaje;
        }
        

        public void AgregarElemento(string elemento)
        {
            int tamañoMensaje = _mensaje.Length;

            Array.Resize(ref _mensaje, tamañoMensaje + 1);
            _mensaje[tamañoMensaje] = elemento;

        }

    }
}
