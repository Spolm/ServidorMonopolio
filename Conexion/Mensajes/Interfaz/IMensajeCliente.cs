using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Interfaz
{
    public interface IMensajeCliente
    {
        void Ejecutar(string[] mensaje, Jugador jugador,Juego juego ,ServerForm ventanaServidor);
    }
}
