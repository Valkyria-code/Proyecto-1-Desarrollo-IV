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

        string connectionString = @"Server=.;Database=Calculadora;TrustServerCertificate=true;Integrated Security=SSPI;";

        private bool historialVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 353;
            this.Height = 526;
            dgv_historial.Visible = false;
        }

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

        private void AgregarDigito(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txt_entrada.Text += btn.Text;
        }

        private void btn_clear_entry_Click(object sender, EventArgs e)
        {
            txt_entrada.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                string operacion = txt_entrada.Text;

                var resultado = new System.Data.DataTable().Compute(operacion, null);
                string resultadoTexto = resultado.ToString();

                txt_entrada.Text = resultadoTexto;

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

        }

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
    }
}
