using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusNavegacion
{
    public class Conexion
    {
        public Conexion(string destino, int distancia)
        {
            Destino = destino;
            Distancia = distancia;
        }

        public string Destino { get; set; }

        public int Distancia { get; set; }
    }
}
