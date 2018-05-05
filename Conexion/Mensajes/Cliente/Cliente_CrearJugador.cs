using ServidorMonopolio.Conexion.Mensajes.Interfaz;
using ServidorMonopolio.Conexion.Mensajes.Servidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Cliente
{
    public class Cliente_CrearJugador : IMensajeCliente
    {
        public void Ejecutar(string[] mensaje, ServidorMonopolio.Modelo.Jugador jugador,ServidorMonopolio.Modelo.Juego juego,ServidorMonopolio.ServerForm ventanaServidor)
        {
            jugador.Nombre = mensaje[1];

            ventanaServidor.Mostrar_Cliente(jugador.Nombre.ToUpper());

            ventanaServidor.Imprimir_Log(DateTime.Now + " - " + jugador.Id.ToString() + ": Se le ha asignado el nombre: " + jugador.Nombre.ToUpper());

            jugador.EnviarMensaje(new Servidor_CrearJugador(jugador,juego));
        }
    }
}
