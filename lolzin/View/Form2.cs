using lolzin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolzin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.email = textBox1.Text;
            Usuario.senha = textBox2.Text;
            Usuario.Criar();
            MessageBox.Show("Usuario Cadastrado com sucesso!");
            Hide();
        }
    }
}
