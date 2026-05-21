using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusNavegación
{
    public class TablaHash
    {
        private readonly Dictionary<string, int> _visitas;

        public TablaHash()
        {
            _visitas = new Dictionary<string, int>();
        }

        public void Limpiar()
        {
            _visitas.Clear();
        }

        public void RegistrarVisita(string edificio)
        {
            if (string.IsNullOrWhiteSpace(edificio))
            {
                return;
            }

            if (_visitas.ContainsKey(edificio))
            {
                _visitas[edificio]++;
                return;
            }

            _visitas.Add(edificio, 1);
        }

        public string MostrarEstadisticas()
        {
            if (_visitas.Count == 0)
            {
                return "No hay visitas registradas.";
            }

            var lista = new List<KeyValuePair<string, int>>(_visitas);
            lista.Sort(CompararVisitasDesc);

            var sb = new StringBuilder();
            sb.AppendLine("=== ESTADÍSTICAS DE VISITAS (MAYOR A MENOR) ===");

            for (int i = 0; i < lista.Count; i++)
            {
                sb.AppendLine($"{lista[i].Key}: {lista[i].Value}");
            }

            sb.AppendLine();
            sb.AppendLine($"Edificio más visitado: {lista[0].Key} ({lista[0].Value})");

            return sb.ToString();
        }

        public string EdificioMasVisitado()
        {
            if (_visitas.Count == 0)
            {
                return "Ninguno (sin visitas).";
            }

            string mejor = null;
            int max = -1;

            foreach (var par in _visitas)
            {
                if (par.Value > max)
                {
                    max = par.Value;
                    mejor = par.Key;
                }
            }

            return $"{mejor} con {max} visitas";
        }

        private static int CompararVisitasDesc(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            int comp = b.Value.CompareTo(a.Value);
            if (comp != 0)
            {
                return comp;
            }

            return string.Compare(a.Key, b.Key);
        }
    }
}
