using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Interfaz
{
    public interface IMensajeServidor
    {
        string[] GetMensaje();
    }
}
