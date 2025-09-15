using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ControlBotones()
        {
            if (Usuario.Text != "" && textBox2.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }
        // Reemplaza la llamada a 'controlBotones()' por 'ControlBotones()' en el método Usuario_TextChanged
        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            using (Form1 ventanaForm2 = new Form2(text: Usuario.Text))
            {
                ventanaForm2.ShowDialog();
            }
        }
        // Agrega este método en la clase Biblioteca para manejar el evento Click del botón btnSalir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
