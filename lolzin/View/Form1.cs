using lolzin.Model;
using lolzin.View;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                Usuario.email = textBox1.Text;
                Usuario.senha = textBox2.Text;

                if (Usuario.Login())
                {
                    Form3 main = new Form3();
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados corretamente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
