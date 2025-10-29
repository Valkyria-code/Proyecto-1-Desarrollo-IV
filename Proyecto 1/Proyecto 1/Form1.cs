using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        string connectionString = @"Server=.;Database=Calculadora;TrustServerCertificate=true;Integrated Security=SSPI;";

        // Controla si el panel del historial está visible o no
        private bool historialVisible = false;

        // Almacena el último resultado calculado para usar con el botón Ans
        private string resultadoAns = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura el tamaño inicial del formulario (sin historial visible)
            this.Width = 353;
            this.Height = 549;
            dgv_historial.Visible = false;
        }

        // Guarda una operación y su resultado en la base de datos
        private void GuardarEnHistorial(string operacion, string resultado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Historial (Operacion, Resultado) VALUES (@Operacion, @Resultado)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Operacion", operacion);
                        comando.Parameters.AddWithValue("@Resultado", resultado);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en historial: " + ex.Message);
            }
        }

        // Carga el historial desde la base de datos y lo muestra en el DataGridView
        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Operacion, Resultado FROM Historial";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv_historial.DataSource = dt;

                        if (dgv_historial.Columns.Count > 0)
                        {
                            dgv_historial.Columns["Operacion"].HeaderText = "Operación";
                            dgv_historial.Columns["Resultado"].HeaderText = "Resultado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        // Método compartido para agregar dígitos u operadores al textbox
        // Toma el texto del botón presionado y lo agrega a la entrada
        private void AgregarDigito(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txt_entrada.Text += btn.Text;
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            txt_entrada.Text += "^";
        }


        // Procesa y calcula las potencias en la expresión convirtiendo base^exponente a su resultado
        private string ProcesarPotencias(string expresion)
        {
            while (expresion.Contains("^"))
            {
                int posicionPotencia = expresion.IndexOf("^");

                // Encuentra el inicio del número base (antes de ^)
                int inicioBase = posicionPotencia - 1;
                while (inicioBase > 0 && (char.IsDigit(expresion[inicioBase]) || expresion[inicioBase] == '.'))
                {
                    inicioBase--;
                }

                // Ajusta para estar en el primer dígito de la base
                if (!char.IsDigit(expresion[inicioBase]) && expresion[inicioBase] != '.')
                {
                    inicioBase++;
                }

                // Encuentra el final del exponente (después de ^)
                int finExponente = posicionPotencia + 1;

                // Permite exponentes negativos
                if (finExponente < expresion.Length && expresion[finExponente] == '-')
                {
                    finExponente++;
                }

                while (finExponente < expresion.Length && (char.IsDigit(expresion[finExponente]) || expresion[finExponente] == '.'))
                {
                    finExponente++;
                }

                // Extrae base y exponente como strings
                string baseStr = expresion.Substring(inicioBase, posicionPotencia - inicioBase);
                string exponenteStr = expresion.Substring(posicionPotencia + 1, finExponente - posicionPotencia - 1);

                // Convierte a números y calcula
                double baseNum = double.Parse(baseStr);
                double exponente = double.Parse(exponenteStr);
                double resultado = Math.Pow(baseNum, exponente);

                // Reemplaza base^exponente con el resultado
                expresion = expresion.Substring(0, inicioBase) + resultado.ToString() + expresion.Substring(finExponente);
            }

            return expresion;
        }
        private void btn_clear_entry_Click(object sender, EventArgs e)
        {
            if (txt_entrada.Text.Length > 0)
            {
                txt_entrada.Text = txt_entrada.Text.Substring(0, txt_entrada.Text.Length - 1);
            }
        }

        // Evalúa la expresión matemática completa y muestra el resultado
        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                string operacion = txt_entrada.Text;
                string operacionParaCalcular = operacion;

                // Procesa las potencias
                operacionParaCalcular = ProcesarPotencias(operacionParaCalcular);

                // Procesa las raíces antes de evaluar la expresión (si la operación tiene)
                operacionParaCalcular = ProcesarRaices(operacionParaCalcular);

                // Evalúa la expresión matemática
                var resultado = new System.Data.DataTable().Compute(operacionParaCalcular, null);
                string resultadoTexto = resultado.ToString();

                // Guarda el resultado para usarlo con el botón Ans
                resultadoAns = resultadoTexto;

                txt_entrada.Text = resultadoTexto;

                // Guarda y actualiza el historial
                GuardarEnHistorial(operacion, resultadoTexto);
                CargarHistorial();
            }
            catch (Exception)
            {
                txt_entrada.Text = "Error";
            }
        }

        private void btn_raiz_cuadrada_Click(object sender, EventArgs e)
        {
            txt_entrada.Text += "√(";
        }

        // Procesa y calcula las raíces (cuadradas y n-ésimas) en la expresión
        private string ProcesarRaices(string expresion)
        {
            // Procesa las raíces cuadradas √(...)
            while (expresion.Contains("√("))
            {
                int inicio = expresion.IndexOf("√(");
                int contadorParentesis = 1;
                int fin = inicio + 2;

                // Encuentra el paréntesis de cierre correspondiente, manejando paréntesis anidados
                while (fin < expresion.Length && contadorParentesis > 0)
                {
                    if (expresion[fin] == '(') contadorParentesis++;
                    if (expresion[fin] == ')') contadorParentesis--;
                    fin++;
                }

                // Extrae y calcula el contenido dentro de √(...)
                string contenido = expresion.Substring(inicio + 2, fin - inicio - 3);
                var resultadoContenido = new System.Data.DataTable().Compute(contenido, null);
                double raiz = Math.Sqrt(Convert.ToDouble(resultadoContenido));

                // Reemplaza √(...) con el resultado
                expresion = expresion.Substring(0, inicio) + raiz.ToString() + expresion.Substring(fin);
            }

            // Procesa las raíces n-ésimas ⁿ√[n](...)
            while (expresion.Contains("ⁿ√["))
            {
                int inicio = expresion.IndexOf("ⁿ√[");

                // Encuentra el cierre del índice ]
                int finIndice = expresion.IndexOf("]", inicio);
                if (finIndice == -1) break;

                // Extrae el índice de la raíz (n en raíz n-ésima)
                string indiceStr = expresion.Substring(inicio + 3, finIndice - inicio - 3);
                double indice = double.Parse(indiceStr);

                // Verifica que haya un paréntesis de apertura después de ]
                if (finIndice + 1 >= expresion.Length || expresion[finIndice + 1] != '(')
                    break;

                // Encuentra el paréntesis de cierre correspondiente
                int contadorParentesis = 1;
                int fin = finIndice + 2;

                while (fin < expresion.Length && contadorParentesis > 0)
                {
                    if (expresion[fin] == '(') contadorParentesis++;
                    if (expresion[fin] == ')') contadorParentesis--;
                    fin++;
                }

                // Extrae y calcula el contenido dentro de (...)
                string contenido = expresion.Substring(finIndice + 2, fin - finIndice - 3);
                var resultadoContenido = new System.Data.DataTable().Compute(contenido, null);
                double numero = Convert.ToDouble(resultadoContenido);

                // Calcula la raíz n-ésima usando la fórmula: raíz n de x = x^(1/n)
                double raiz = Math.Pow(numero, 1.0 / indice);

                // Reemplaza en la expresión con el resultado
                expresion = expresion.Substring(0, inicio) + raiz.ToString() + expresion.Substring(fin);
            }

            return expresion;
        }

        // Alterna entre mostrar y ocultar el historial, expandiendo/contrayendo la ventana
        private void btn_historial_Click(object sender, EventArgs e)
        {
            if (historialVisible)
            {
                this.Width = 353;

                dgv_historial.Visible = false;
                historialVisible = false;
            }
            else
            {
                this.Width = 632;
                CargarHistorial();

                dgv_historial.Visible = true;
                historialVisible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_entrada.Clear();
        }

        private void btn_abre_parentesis_Click(object sender, EventArgs e)
        {
            txt_entrada.Text += "(";
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            txt_entrada.Text += resultadoAns;
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            txt_entrada.Text += "ⁿ√[";
        }
    }
}
