using System;
using System.Collections.Generic;
using System.Text;

namespace CampusNavegacion
{
    public class MinHeap
    {
        private readonly List<(string Ruta, int Distancia)> _elementos = new List<(string Ruta, int Distancia)>();

        public void Limpiar()
        {
            _elementos.Clear();
        }

        public void Insertar(string ruta, int distancia)
        {
            _elementos.Add((ruta, distancia));
            _elementos.Sort((a, b) => a.Distancia.CompareTo(b.Distancia));
        }

        public string MostrarRutasOrdenadas()
        {
            if (_elementos.Count == 0)
                return "No hay rutas en el heap.";

            var sb = new StringBuilder();
            foreach (var elem in _elementos)
            {
                sb.AppendLine($"{elem.Ruta}: {elem.Distancia} m");
            }
            return sb.ToString();
        }
    }
}
