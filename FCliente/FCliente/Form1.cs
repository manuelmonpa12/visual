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
            objCliente.Ciudad = txtCiudad.Text.ToUpper().Trim();
            
            //sexo ini           
            if (radioButton1.Checked)
            {
                objCliente.Sexo =  radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                objCliente.Sexo =   radioButton2.Text;
            }
            //sexo fin
            objCenso.AdicionarCliente(objCliente);
            //String mensaje = String.Format("El costo de almacenamiento es: {0}\n"+
            //                               "El valor del producto es: {1}\n"+
            //                               "El valor de venta del producto: {2}", objCliente.Nombre, objCliente.Apellido, objCliente.Identificacion);
            MessageBox.Show(" Registro Guardado");
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
            txtCiudad.Text = objCliente.Ciudad;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objCenso.EliminarCliente(Convert.ToInt32(txtid.Text));
            MessageBox.Show("Registro Eliminado");
            llenarGrilla();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNom.Text = dgDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApe.Text = dgDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            //ojo
            txtCiudad.Text = dgDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objCliente.Nombre = txtNom.Text;
            objCliente.Apellido = txtApe.Text;
            objCliente.Identificacion = Convert.ToInt32(txtid.Text);
            objCliente.Ciudad = txtCiudad.Text;

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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtApe.Clear();
            txtid.Clear();
            txtNom.Clear();            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        }
    }

