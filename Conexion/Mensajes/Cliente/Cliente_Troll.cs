using ServidorMonopolio.Conexion.Mensajes.Interfaz;
using ServidorMonopolio.Conexion.Mensajes.Servidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Cliente
{
    class Cliente_Troll : IMensajeCliente
    {
        public void Ejecutar(string[] mensaje, ServidorMonopolio.Modelo.Jugador jugador, ServidorMonopolio.Modelo.Juego juego, ServidorMonopolio.ServerForm ventanaServidor)
        {
            foreach(ServidorMonopolio.Modelo.Jugador _jugador in juego.Jugadores)
            {
                _jugador.EnviarMensaje(new Servidor_Troll());
            }
        }
    }
}
