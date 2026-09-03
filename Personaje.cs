using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Structs_Y_Pilas
{
    public struct Personaje
    {

        public int VidaTotal { get; set; }
        public int VidaActual { get; set; }
        public string UltimaAccion { get; set; }


       public Personaje (int VidaTotal, int VidaActual, string UltimaAccion)
       {
            this.VidaActual = VidaActual;
            this.VidaTotal = VidaTotal;
            this.UltimaAccion = UltimaAccion;
       }
    }
}
