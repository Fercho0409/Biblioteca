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
    public partial class Form2 : Form
    {
        // Solución para CS0169: El campo 'Form1.Usuario_cliente' nunca se usa
        // El campo sí se usa en los constructores y en los métodos Equals/GetHashCode, por lo que el error no debería aparecer.
        // Solución para IDE0044: Hacer el campo de solo lectura
        // Se recomienda marcar el campo como readonly si solo se asigna en el constructor.

        private readonly string Usuario_cliente;

        public string Usuario_cliente1 => Usuario_cliente2;

        public string Usuario_cliente2 => Usuario_cliente3;

        public string Usuario_cliente3 => Usuario_cliente;

        public Form2(string usuario_cliente)
        {
            Usuario_cliente = usuario_cliente;
        }

        public Form2(string Usuario, string usuario_cliente)
        {
            InitializeComponent();
            Usuario_cliente = usuario_cliente;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        public override bool Equals(object obj)
        {
            return obj is Form2 form &&
                   Usuario_cliente2 == form.Usuario_cliente2;
        }

        public override int GetHashCode()
        {
            return -2104510850 + EqualityComparer<string>.Default.GetHashCode(Usuario_cliente2);
        }
    }
}
