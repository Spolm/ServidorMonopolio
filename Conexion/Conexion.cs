using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorMonopolio.Conexion.Mensajes;

namespace ServidorMonopolio.Conexion
{
    public class Conection
    {
        private IPAddress _ip_address;
        private int _puerto;
        private TcpListener _servidor;
        private ServerForm _form;
        private int contador_clientes = 0;
        private Juego _juego;
        private MensajeManager _mensajeManager;
        private Paquete _paquete;

        public bool Crear_Conexion(string ip, int puerto, ServerForm form)
        {
            try
            {
                IPAddress.TryParse(ip, out _ip_address);

                _puerto = puerto;

                _form = form;

                _mensajeManager = new MensajeManager();

                _servidor = new TcpListener(_ip_address, _puerto);

                _servidor.Start();

                _form.Imprimir_Log("Conexión abierta.");

                _juego = new Juego();

                _servidor.BeginAcceptTcpClient(AceptandoCliente, _servidor);

                _form.Imprimir_Log("Esperando clientes...");

                
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e.ToString());
                return false;
            }

        }

        private void AceptandoCliente(IAsyncResult AsyncResult)
        {
            _servidor = (TcpListener)AsyncResult.AsyncState;
            TcpClient Cliente_Entrante = null;
            Jugador _jugador;

            try
            {

                Cliente_Entrante = _servidor.EndAcceptTcpClient(AsyncResult);
                _servidor.BeginAcceptTcpClient(AceptandoCliente, _servidor); //Sigue el loop para aceptar mas clientes.

                _form.Imprimir_Log("Recibiendo información de un cliente...");

                contador_clientes++;

                _jugador = new Jugador(contador_clientes);
                _jugador.Cliente = Cliente_Entrante;


                lock (_juego.Jugadores)
                {
                    _juego.Jugadores.Add(_jugador);
                }

                _jugador.Lectura = new byte[512];

                _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, RecibiendoMensajeCliente, _jugador.Cliente);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecibiendoMensajeCliente(IAsyncResult AsyncResult)
        {
            int nCountReadBytes = 0;
            string mensaje_lectura = "";
            Jugador _jugador = null;

            lock (_juego.Jugadores)
            {
                try
                {
                    _jugador = _juego.Jugadores.Find(x => x.Cliente == (TcpClient)AsyncResult.AsyncState);

                    nCountReadBytes = _jugador.Cliente.GetStream().EndRead(AsyncResult);

                    mensaje_lectura = Encoding.ASCII.GetString(_jugador.Lectura, 0, nCountReadBytes).Trim();

                    _mensajeManager.EjecutarMensaje(mensaje_lectura.Split(';'), _jugador, _juego, _form);

                }
                catch (IndexOutOfRangeException)
                {
                    _form.Imprimir_Log("Error al decodificar el mensaje: " + mensaje_lectura);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("El jugador: " + _jugador.Id + " se ha desconectado.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _juego.Jugadores.Remove(_jugador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().FullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (_jugador.Cliente.Connected)
                    {
                        _jugador.Lectura = new byte[512];
                        _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, RecibiendoMensajeCliente, _jugador.Cliente);
                    }
                }
            }
        }


    }
}
