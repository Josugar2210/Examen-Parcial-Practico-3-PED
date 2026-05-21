using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusNavegación
{
    public class Ruta
    {
        public string Edificio { get; set; }
        public int Distancia { get; set; }

        public Ruta(string edificio, int distancia)
        {
            Edificio = edificio;
            Distancia = distancia;
        }


    }
}
