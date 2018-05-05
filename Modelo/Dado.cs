using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Modelo
{
    public static class Dado
    {
        private static int _dado_1;
        private static int _dado_2;
        private static bool _doble = false;

        static Random rand = new Random();

        public static int Dado_1
        {
            get { return _dado_1; }
            set { _dado_1 = value; }
        }

        public static int Dado_2
        {
            get { return _dado_2; }
            set { _dado_2 = value; }
        }


        public static bool Doble
        {
            get { return _doble; }
            set { _doble = value; }
        }

        public static int Lanzar_Dado() {

            Dado_1 = rand.Next(1, 7);
            Dado_2 = rand.Next(1, 7);

            if (Dado_1 == Dado_2)
                Doble = true;
            else
                Doble = false;

            return _dado_1 + _dado_2;
        }
    }
}
