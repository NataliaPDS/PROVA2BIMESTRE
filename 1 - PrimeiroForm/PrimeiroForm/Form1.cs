using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_diferente.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//salvar
        {
            /*string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            string email = tx_email.Text;
            string telefone = mask_telefone.Text;*/
            
            
            string senha = tx_senha.Text;
            string confsenha = tx_confsenha.Text;
            MessageBox.Show("AAA");
            if (senha == confsenha)
            {
                string nome = tx_nome.Text;
                string cpf = mask_cpf.Text;
                string email = tx_email.Text;
                string telefone = mask_telefone.Text;
                MessageBox.Show($"{nome}\n {cpf}\n {email}\n {telefone}");
                lb_diferente.Text = "";
            }
            else
            {
                lb_diferente.Text = "Senhas diferentes!";
            }
          

            //MessageBox.Show($"{nome}\n {cpf}\n {email}\n {telefone}\n {senha}\n {confsenha}");

           
      

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            tx_nome.Clear();
            tx_email.Clear();
            mask_cpf.Clear();
            mask_telefone.Clear();
            tx_senha.Clear();
            tx_confsenha.Clear();
           
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_diferente_Click(object sender, EventArgs e)
        {

        }
    }
}
