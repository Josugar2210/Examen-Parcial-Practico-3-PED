using System;
using System.Collections.Generic;
using System.Text;

namespace CampusNavegacion
{
    public class Grafo
    {
        private readonly Dictionary<string, List<Conexion>> _grafo;

        public Grafo()
        {
            _grafo = new Dictionary<string, List<Conexion>>();
            VisitasBFS = new List<string>();
            VisitasDFS = new List<string>();
        }

        public List<string> VisitasBFS { get; private set; }

        public List<string> VisitasDFS { get; private set; }

        public void AgregarEdificio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return;
            }

            if (!_grafo.ContainsKey(nombre))
            {
                _grafo.Add(nombre, new List<Conexion>());
            }
        }

        public void AgregarCamino(string origen, string destino, int distancia)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                return;
            }

            AgregarEdificio(origen);
            AgregarEdificio(destino);

            _grafo[origen].Add(new Conexion(destino, distancia));
            _grafo[destino].Add(new Conexion(origen, distancia));
        }

        public string MostrarGrafo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== MAPA DEL CAMPUS (GRAFO) ===");

            foreach (var edificio in _grafo)
            {
                sb.Append($"{edificio.Key}: ");

                List<Conexion> conexiones = edificio.Value;
                for (int i = 0; i < conexiones.Count; i++)
                {
                    sb.Append($"{conexiones[i].Destino} [{conexiones[i].Distancia}m]");

                    if (i < conexiones.Count - 1)
                    {
                        sb.Append(" | ");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string RecorridoBFS(string inicio)
        {
            VisitasBFS.Clear();

            if (string.IsNullOrWhiteSpace(inicio) || !_grafo.ContainsKey(inicio))
            {
                return "BFS: el edificio '{inicio}' no existe.";
            }

            var cola = new Queue<string>();
            var visitados = new Dictionary<string, bool>();
            var niveles = new Dictionary<string, int>();

            cola.Enqueue(inicio);
            visitados[inicio] = true;
            niveles[inicio] = 0;

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                VisitasBFS.Add(actual);

                foreach (Conexion vecino in _grafo[actual])
                {
                    if (visitados.ContainsKey(vecino.Destino))
                    {
                        continue;
                    }

                    visitados[vecino.Destino] = true;
                    niveles[vecino.Destino] = niveles[actual] + 1;
                    cola.Enqueue(vecino.Destino);
                }
            }

            int maxNivel = 0;
            foreach (var par in niveles)
            {
                if (par.Value > maxNivel)
                {
                    maxNivel = par.Value;
                }
            }

            var sb = new StringBuilder();
            sb.AppendLine("=== BFS DESDE {inicio} ===");
            sb.AppendLine("Niveles:");

            for (int n = 0; n <= maxNivel; n++)
            {
                sb.Append("Nivel" + " " + n + ":" );
                bool primero = true;
                    
                for (int i = 0; i < VisitasBFS.Count; i++)
                {
                    string e = VisitasBFS[i];
                    if (niveles[e] != n)
                    {
                        continue;
                    }

                    if (!primero)
                    {
                        sb.Append(", ");
                    }

                    sb.Append(e);
                    primero = false;
                }

                sb.AppendLine();
            }

            sb.AppendLine();
            sb.Append("Recorrido: ");

            for (int i = 0; i < VisitasBFS.Count; i++)
            {
                sb.Append(VisitasBFS[i]);

                if (i < VisitasBFS.Count - 1)
                {
                    sb.Append(" -> ");
                }
            }

            return sb.ToString();
        }

        public string RecorridoDFS(string inicio, string destino)
        {
            VisitasDFS.Clear();

            if (string.IsNullOrWhiteSpace(inicio) || !_grafo.ContainsKey(inicio))
            {
                return "DFS: el edificio '{inicio}' no existe.";
            }

            if (string.IsNullOrWhiteSpace(destino) || !_grafo.ContainsKey(destino))
            {
                return "DFS: el edificio '{destino}' no existe.";
            }

            var pila = new Stack<string>();
            var visitados = new Dictionary<string, bool>();
            var padre = new Dictionary<string, string>();

            pila.Push(inicio);
            padre[inicio] = null;

            bool encontrado = false;

            while (pila.Count > 0)
            {
                string actual = pila.Pop();

                if (visitados.ContainsKey(actual))
                {
                    continue;
                }

                visitados[actual] = true;
                VisitasDFS.Add(actual);

                if (actual == destino)
                {
                    encontrado = true;
                    break;
                }

                List<Conexion> vecinos = _grafo[actual];
                for (int i = vecinos.Count - 1; i >= 0; i--)
                {
                    string sig = vecinos[i].Destino;

                    if (visitados.ContainsKey(sig))
                    {
                        continue;
                    }

                    if (!padre.ContainsKey(sig))
                    {
                        padre[sig] = actual;
                    }

                    pila.Push(sig);
                }
            }

            if (!encontrado)
            {
                return "=== DFS ===\nNo existe camino de {inicio} a {destino}.";
            }

            var camino = new List<string>();
            string nodo = destino;

            while (nodo != null)
            {
                camino.Add(nodo);
                nodo = padre[nodo];
            }

            camino.Reverse();

            var sb = new StringBuilder();
            sb.AppendLine("=== DFS DE {inicio} A {destino} ===");
            sb.Append("Camino encontrado: ");

            for (int i = 0; i < camino.Count; i++)
            {
                sb.Append(camino[i]);

                if (i < camino.Count - 1)
                {
                    sb.Append(" -> ");
                }
            }

            return sb.ToString();
        }

        public List<Conexion> ObtenerConexiones(string edificio)
        {
            if (string.IsNullOrWhiteSpace(edificio) || !_grafo.ContainsKey(edificio))
            {
                return new List<Conexion>();
            }

            return _grafo[edificio];
        }
    }
}
