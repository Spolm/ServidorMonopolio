using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo.Tarjetas
{
    public enum Efecto_Casualidad
    {
        Salir_Prision = 0,
        Recibir_150 = 1,
        Recibir_200_Inicio = 2,
        Restar_50 = 3,
        Ir_Carcel = 4,
        Restar_25_Propiedad = 5, //Por cada propiedad, se resta 25$
        Ir_Mendoza_Sur = 6,
        Recibir_50 = 7,
        Dar_25_Jugador = 8, //Paga 25 a cada jugador
        Ir_San_Luis = 9,
        Restar_3_Pasos = 10, //Volver 3 Posiciones
        Recibir_100 = 11
    }
}
