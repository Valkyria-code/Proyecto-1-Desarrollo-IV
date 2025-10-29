using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {

        string connectionString = @"Server=.;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                var resultado = new System.Data.DataTable().Compute(txt_entrada.Text, null);
                txt_entrada.Text = resultado.ToString();
            }
            catch (Exception)
            {
                txt_entrada.Text = "Error";
            }
        }
    }
}
