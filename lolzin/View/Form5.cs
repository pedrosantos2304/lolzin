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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                var maps = new Mapas();
                maps.nome = textBox2.Text;
                maps.Criar();
                dataGridView1.DataSource = maps.Listar();
            }
            else
            {
                MessageBox.Show("Preencha corretamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var maps = new Mapas();
            maps.nome = textBox2.Text;
            maps.codigo = int.Parse(txtcod.Text);
            maps.Editar();
            dataGridView1.DataSource = maps.Listar();
            MessageBox.Show("Usuario editado com sucesso!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var maps = new Mapas();
            maps.Deletar(txtcod.Text);
            dataGridView1.DataSource = maps.Listar();
            MessageBox.Show("Produto Deletado com sucesso!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtcod.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var maps = new Mapas();
            dataGridView1.DataSource = maps.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Close();
        }
    }
}
