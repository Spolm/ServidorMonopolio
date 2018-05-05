
using ServidorMonopolio.Conexion.Mensajes.Cliente;
using ServidorMonopolio.Conexion.Mensajes.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorMonopolio.Conexion.Mensajes
{
    class MensajeManager
    {
        private Dictionary<int, IMensajeCliente> _mensajesCliente;

        public MensajeManager()
        {
            _mensajesCliente = new Dictionary<int, IMensajeCliente>();
            RegistrarMensajes();

        }

        private void RegistrarMensajes()
        {
            _mensajesCliente.Add(Codigos_Entradas.Entrada_Crear_Jugador, new Cliente_CrearJugador());
            _mensajesCliente.Add(Codigos_Entradas.Entrada_Troll, new Cliente_Troll());
        }

        public void EjecutarMensaje(string[] mensaje, ServidorMonopolio.Modelo.Jugador jugador, ServidorMonopolio.Modelo.Juego juego, ServidorMonopolio.ServerForm VentanaServidor)
        {
            IMensajeCliente IMensaje = Verificar_Mensaje(mensaje, VentanaServidor);

            if (IMensaje == null)
                return;

            IMensaje.Ejecutar(mensaje, jugador, juego, VentanaServidor);
        }

        private IMensajeCliente Verificar_Mensaje(string[] Split, ServidorMonopolio.ServerForm VentanaServidor)
        {
            int Codigo_Entrada = -1;
            IMensajeCliente IMensaje = null;
            try
            {
                Codigo_Entrada = Convert.ToInt32(Split[0]);

                if (!_mensajesCliente.TryGetValue(Codigo_Entrada, out IMensaje)) {

                    VentanaServidor.Imprimir_Log("Codigo de entrada desconocido: " + Codigo_Entrada);
                    return null;
                }

                return IMensaje;

            }
            catch (Exception)
            {
                VentanaServidor.Imprimir_Log("Error al convertir el código de entrada: "+Split[0]);
                return null;
            }

        }
    }
}
