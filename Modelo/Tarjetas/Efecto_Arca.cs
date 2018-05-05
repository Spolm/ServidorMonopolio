using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Tarjetas
{
    public enum Efecto_Arca
    {
        Salir_Prision = 0,
        Restar_100 = 1,
        Restar_150 = 2,
        Recibir_50_Jugador = 3, //Cada jugador te paga 50$
        Recibir_200 = 4,
        Recibir_10 = 5,
        Recibir_100 = 6,
        Recibir_200_Inicio = 7,
        Restar_25_Propiedad = 8, //Por cada propiedad, se resta 25$
        Ir_Carcel = 9,
        Restar_20 = 10,
        Restar_50_Jugador = 11 //Pagar 50$ a cada jugador
    }

}
