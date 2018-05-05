using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_Troll : Paquete
    {
        public Servidor_Troll()
        {
            AgregarElemento(Codigos_Salidas.Salida_Troll.ToString());
            AgregarElemento("Hola les hablo desde el servidor");
        }
    }
}
