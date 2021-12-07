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

namespace lolzin.View
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var champs = new Campeoes();
            champs.nome = textBox2.Text;
            champs.codigo = int.Parse(txtcod.Text);
            champs.Editar();
            dataGridView1.DataSource = champs.Listar();
            MessageBox.Show("Usuario editado com sucesso!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcod.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                var champs = new Campeoes();
                champs.nome = textBox2.Text;
                champs.Criar();
                dataGridView1.DataSource = champs.Listar();
            }
            else
            {
                MessageBox.Show("Preencha corretamente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var champs = new Campeoes();
            champs.Deletar(txtcod.Text);
            dataGridView1.DataSource = champs.Listar();
            MessageBox.Show("Campeão Deletado com sucesso!");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var champs = new Campeoes();
            champs.Deletar(txtcod.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Close();
        }
    }
}
