using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusNavegacion;

namespace CampusNavegación
{
    public partial class Form1 : Form
    {
        private readonly Grafo _grafo;
        private readonly TablaHash _tabla;
        private readonly MinHeap _heap;

        private readonly List<Arista> _aristas;
        private readonly Dictionary<string, Point> _posiciones;

        private readonly Dictionary<string, string> _nombresEdificios;
        private readonly Dictionary<string, Color> _coloresEdificios;

        private sealed class Arista
        {
            public Arista(string origen, string destino, int distancia)
            {
                Origen = origen;
                Destino = destino;
                Distancia = distancia;
            }

            public string Origen { get; }

            public string Destino { get; }

            public int Distancia { get; }
        }

        public Form1()
        {
            InitializeComponent();

            _grafo = new Grafo();
            _tabla = new TablaHash();
            _heap = new MinHeap();

            _aristas = new List<Arista>();
            _posiciones = new Dictionary<string, Point>();

            _nombresEdificios = new Dictionary<string, string>();
            _coloresEdificios = new Dictionary<string, Color>();

            InicializarInfoEdificios();

            cmbOrigen.SelectedIndexChanged += CmbSeleccionChanged;
            cmbDestino.SelectedIndexChanged += CmbSeleccionChanged;

            txtResultado.Text = "Listo. Selecciona origen/destino y revisa el mapa del campus (Panel superior).";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InicializarGrafo();
            InicializarMapa();
            InicializarCombos();
            panelCampus.Invalidate();
        }

        private void InicializarInfoEdificios()
        {
            _nombresEdificios.Clear();
            _nombresEdificios["A"] = "Biblioteca Central";
            _nombresEdificios["B"] = "Cafeteria";
            _nombresEdificios["C"] = "Laboratorio de Computo";
            _nombresEdificios["D"] = "Rectoria";
            _nombresEdificios["E"] = "Gimnasio";
            _nombresEdificios["F"] = "Aulas Generales";
            _nombresEdificios["G"] = "Estacionamiento";

            _coloresEdificios.Clear();
            _coloresEdificios["A"] = Color.FromArgb(52, 152, 219);  // Azul
            _coloresEdificios["B"] = Color.FromArgb(46, 204, 113);  // Verde
            _coloresEdificios["C"] = Color.FromArgb(155, 89, 182);  // Morado
            _coloresEdificios["D"] = Color.FromArgb(241, 196, 15);  // Amarillo
            _coloresEdificios["E"] = Color.FromArgb(230, 126, 34);  // Naranja
            _coloresEdificios["F"] = Color.FromArgb(231, 76, 60);   // Rojo
            _coloresEdificios["G"] = Color.FromArgb(26, 188, 156);  // Turquesa
        }

        private void InicializarCombos()
        {
            var edificios = _posiciones.Keys.OrderBy(x => x).ToList();

            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();

            for (int i = 0; i < edificios.Count; i++)
            {
                cmbOrigen.Items.Add(edificios[i]);
                cmbDestino.Items.Add(edificios[i]);
            }

            if (cmbOrigen.Items.Count > 0)
            {
                cmbOrigen.SelectedIndex = 0;
            }

            if (cmbDestino.Items.Count > 0)
            {
                cmbDestino.SelectedIndex = cmbDestino.Items.Count - 1;
            }
        }

        private void InicializarGrafo()
        {
            _grafo.AgregarCamino("A", "B", 120);
            _grafo.AgregarCamino("A", "C", 200);
            _grafo.AgregarCamino("B", "D", 150);
            _grafo.AgregarCamino("B", "E", 300);
            _grafo.AgregarCamino("C", "F", 100);
            _grafo.AgregarCamino("D", "F", 80);
            _grafo.AgregarCamino("E", "G", 250);
            _grafo.AgregarCamino("F", "G", 180);

            _aristas.Clear();
            _aristas.Add(new Arista("A", "B", 120));
            _aristas.Add(new Arista("A", "C", 200));
            _aristas.Add(new Arista("B", "D", 150));
            _aristas.Add(new Arista("B", "E", 300));
            _aristas.Add(new Arista("C", "F", 100));
            _aristas.Add(new Arista("D", "F", 80));
            _aristas.Add(new Arista("E", "G", 250));
            _aristas.Add(new Arista("F", "G", 180));
        }

        private void InicializarMapa()
        {
            _posiciones.Clear();

            _posiciones["A"] = new Point(120, 80);
            _posiciones["B"] = new Point(260, 60);
            _posiciones["C"] = new Point(170, 190);
            _posiciones["D"] = new Point(390, 160);
            _posiciones["E"] = new Point(430, 55);
            _posiciones["F"] = new Point(310, 280);
            _posiciones["G"] = new Point(480, 255);
        }

        private void CmbSeleccionChanged(object sender, EventArgs e)
        {
            panelCampus.Invalidate();
        }

        private void btnMostrarGrafo_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = _grafo.MostrarGrafo();
            panelCampus.Invalidate();
        }

        private void btnBFS_Click_1(object sender, EventArgs e)
        {
            string origen = cmbOrigen.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(origen))
            {
                txtResultado.Text = "Selecciona un edificio de origen para ejecutar BFS.";
                return;
            }

            txtResultado.Text = _grafo.RecorridoBFS(origen);

            for (int i = 0; i < _grafo.VisitasBFS.Count; i++)
            {
                _tabla.RegistrarVisita(_grafo.VisitasBFS[i]);
            }
        }

        private void btnDFS_Click_1(object sender, EventArgs e)
        {
            string origen = cmbOrigen.SelectedItem as string;
            string destino = cmbDestino.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                txtResultado.Text = "Selecciona origen y destino para ejecutar DFS.";
                return;
            }

            txtResultado.Text = _grafo.RecorridoDFS(origen, destino);

            for (int i = 0; i < _grafo.VisitasDFS.Count; i++)
            {
                _tabla.RegistrarVisita(_grafo.VisitasDFS[i]);
            }
        }

        private void btnHash_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = _tabla.MostrarEstadisticas();
        }

        private void btnHeap_Click_1(object sender, EventArgs e)
        {
            _heap.Limpiar();

            for (int i = 0; i < _aristas.Count; i++)
            {
                Arista a = _aristas[i];
                _heap.Insertar($"{a.Origen}-{a.Destino}", a.Distancia);
            }

            txtResultado.Text = _heap.MostrarRutasOrdenadas();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            _tabla.Limpiar();
            _heap.Limpiar();
            panelCampus.Invalidate();
        }

        private void panelCampus_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = panelCampus.ClientRectangle;

            using (var brushFondo = new LinearGradientBrush(rect, Color.White, Color.FromArgb(240, 248, 255), 90f))
            using (var penLinea = new Pen(Color.FromArgb(160, 90, 90, 90), 3f))
            using (var brushTexto = new SolidBrush(Color.FromArgb(35, 35, 35)))
            using (var fontLetra = new Font("Segoe UI", 12f, FontStyle.Bold))
            using (var fontNombre = new Font("Segoe UI", 9f, FontStyle.Regular))
            using (var formatCentro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var formatCentroArriba = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near })
            {
                penLinea.StartCap = LineCap.Round;
                penLinea.EndCap = LineCap.Round;

                g.FillRectangle(brushFondo, rect);

                string origenSel = cmbOrigen.SelectedItem as string;
                string destinoSel = cmbDestino.SelectedItem as string;

                // Conexiones
                for (int i = 0; i < _aristas.Count; i++)
                {
                    Arista a = _aristas[i];

                    if (!_posiciones.ContainsKey(a.Origen) || !_posiciones.ContainsKey(a.Destino))
                    {
                        continue;
                    }

                    Point p1 = _posiciones[a.Origen];
                    Point p2 = _posiciones[a.Destino];

                    g.DrawLine(penLinea, p1, p2);

                    // Distancia (opcional, pero ayuda a “verse universitario” sin complicar)
                    Point medio = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                    string dist = $"{a.Distancia} m";
                    using (var fontDist = new Font("Segoe UI", 8.5f, FontStyle.Regular))
                    using (var brushDist = new SolidBrush(Color.FromArgb(110, 60, 60, 60)))
                    {
                        g.DrawString(dist, fontDist, brushDist, medio.X + 6, medio.Y + 6);
                    }
                }

                // Nodos
                const int radio = 24;
                const int diametro = radio * 2;

                foreach (var par in _posiciones)
                {
                    string etiqueta = par.Key;
                    Point centro = par.Value;

                    int x = centro.X - radio;
                    int y = centro.Y - radio;

                    Rectangle nodoRect = new Rectangle(x, y, diametro, diametro);

                    Color colorNodo;
                    if (!_coloresEdificios.TryGetValue(etiqueta, out colorNodo))
                    {
                        colorNodo = Color.RoyalBlue;
                    }

                    string nombre;
                    if (!_nombresEdificios.TryGetValue(etiqueta, out nombre))
                    {
                        nombre = etiqueta;
                    }

                    bool esOrigen = string.Equals(etiqueta, origenSel, StringComparison.OrdinalIgnoreCase);
                    bool esDestino = string.Equals(etiqueta, destinoSel, StringComparison.OrdinalIgnoreCase);

                    int borde = (esOrigen || esDestino) ? 4 : 2;
                    Color colorBorde = Color.FromArgb(25, 25, 25);
                    if (esOrigen)
                    {
                        colorBorde = Color.FromArgb(39, 174, 96); // verde
                    }
                    else if (esDestino)
                    {
                        colorBorde = Color.FromArgb(192, 57, 43); // rojo
                    }

                    using (var brushSombra = new SolidBrush(Color.FromArgb(45, 0, 0, 0)))
                    using (var brushNodo = new SolidBrush(colorNodo))
                    using (var penNodo = new Pen(colorBorde, borde))
                    using (var brushLetra = new SolidBrush(Color.White))
                    using (var brushNombre = new SolidBrush(Color.FromArgb(70, 70, 70)))
                    {
                        g.FillEllipse(brushSombra, nodoRect.X + 3, nodoRect.Y + 3, nodoRect.Width, nodoRect.Height);
                        g.FillEllipse(brushNodo, nodoRect);
                        g.DrawEllipse(penNodo, nodoRect);

                        // Letra dentro del círculo
                        g.DrawString(etiqueta, fontLetra, brushLetra, centro, formatCentro);

                        // Nombre debajo del nodo (2 líneas visuales: letra en círculo + nombre abajo)
                        RectangleF nombreRect = new RectangleF(centro.X - 90, centro.Y + radio + 4, 180, 36);
                        g.DrawString(nombre, fontNombre, brushNombre, nombreRect, formatCentroArriba);
                    }
                }
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            btnHash_Click_1(sender, e);
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            btnHeap_Click_1(sender, e);
        }
    }
}
