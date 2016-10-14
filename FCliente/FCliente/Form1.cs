using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCliente.Models;

namespace FCliente
{
    public partial class FCliente : Form
    {        
        private Cliente objCliente;
        private Censo objCenso = new Censo();

        public FCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCliente = new Cliente();

            objCliente.Identificacion = Convert.ToInt32(txtid.Text.Trim());
            objCliente.Nombre = txtNom.Text.ToUpper().Trim();
            objCliente.Apellido = txtApe.Text.ToUpper().Trim();

            objCenso.AdicionarCliente(objCliente);
            String mensaje = String.Format("El costo de almacenamiento es: {0}\n"+
                                           "El valor del producto es: {1}\n"+
                                           "El valor de venta del producto: {2}", objCliente.Nombre, objCliente.Apellido, objCliente.Identificacion);
            MessageBox.Show(mensaje);
            llenarGrilla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void llenarGrilla()
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = objCenso.ListaCenso;
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objCliente = objCenso.ConsultarCliente(Convert.ToInt32(txtid.Text));

            txtNom.Text = objCliente.Nombre;
            txtApe.Text = objCliente.Apellido;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objCenso.EliminarCliente(Convert.ToInt32(txtid.Text));

            llenarGrilla();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNom.Text = dgDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApe.Text = dgDatos.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objCliente.Nombre = txtNom.Text;
            objCliente.Apellido = txtApe.Text;
            objCliente.Identificacion = Convert.ToInt32(txtid.Text);

            objCenso.ActualizarCliente(objCliente);
            llenarGrilla();
        }

        private void aRCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        }
    }

