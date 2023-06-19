namespace PrimeiroForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_hello = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_confsenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_diferente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.BackColor = System.Drawing.Color.Transparent;
            this.lb_hello.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello.ForeColor = System.Drawing.Color.Black;
            this.lb_hello.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_hello.Location = new System.Drawing.Point(24, 28);
            this.lb_hello.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(339, 43);
            this.lb_hello.TabIndex = 0;
            this.lb_hello.Text = "Cadastro de Usuário";
            this.lb_hello.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.Pink;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_nome.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(308, 146);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(522, 22);
            this.tx_nome.TabIndex = 1;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(308, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(157, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(174, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(149, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(149, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(88, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conf.Senha:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Pink;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_email.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(308, 192);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(522, 22);
            this.tx_email.TabIndex = 8;
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.Color.Pink;
            this.tx_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_senha.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.Location = new System.Drawing.Point(308, 282);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(522, 22);
            this.tx_senha.TabIndex = 10;
            this.tx_senha.TextChanged += new System.EventHandler(this.tx_senha_TextChanged);
            // 
            // tx_confsenha
            // 
            this.tx_confsenha.BackColor = System.Drawing.Color.Pink;
            this.tx_confsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_confsenha.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_confsenha.Location = new System.Drawing.Point(308, 331);
            this.tx_confsenha.Name = "tx_confsenha";
            this.tx_confsenha.PasswordChar = '*';
            this.tx_confsenha.Size = new System.Drawing.Size(522, 22);
            this.tx_confsenha.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.lb_hello);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 93);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(517, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefone:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(703, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mask_cpf
            // 
            this.mask_cpf.BackColor = System.Drawing.Color.Pink;
            this.mask_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_cpf.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(308, 237);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(203, 22);
            this.mask_cpf.TabIndex = 18;
            // 
            // mask_telefone
            // 
            this.mask_telefone.BackColor = System.Drawing.Color.Pink;
            this.mask_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_telefone.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone.Location = new System.Drawing.Point(651, 237);
            this.mask_telefone.Mask = "(00) 0000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(179, 22);
            this.mask_telefone.TabIndex = 19;
            // 
            // lb_diferente
            // 
            this.lb_diferente.AutoSize = true;
            this.lb_diferente.BackColor = System.Drawing.Color.Transparent;
            this.lb_diferente.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diferente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_diferente.Location = new System.Drawing.Point(311, 356);
            this.lb_diferente.Name = "lb_diferente";
            this.lb_diferente.Size = new System.Drawing.Size(42, 15);
            this.lb_diferente.TabIndex = 20;
            this.lb_diferente.Text = "label7";
            this.lb_diferente.Click += new System.EventHandler(this.lb_diferente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(961, 516);
            this.Controls.Add(this.lb_diferente);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_confsenha);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_confsenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.Label lb_diferente;
    }
}

