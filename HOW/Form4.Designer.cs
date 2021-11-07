
namespace HOW
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passo1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passo1
            // 
            this.passo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passo1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passo1.ForeColor = System.Drawing.Color.Black;
            this.passo1.Location = new System.Drawing.Point(96, 387);
            this.passo1.Name = "passo1";
            this.passo1.Size = new System.Drawing.Size(220, 49);
            this.passo1.TabIndex = 4;
            this.passo1.Text = "CONTINUAR";
            this.passo1.UseVisualStyleBackColor = false;
            this.passo1.Click += new System.EventHandler(this.passo1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(144, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Endereço de\r\n   entrega";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(12, 44);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 36);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcep.ForeColor = System.Drawing.Color.White;
            this.lblcep.Location = new System.Drawing.Point(53, 174);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(41, 20);
            this.lblcep.TabIndex = 8;
            this.lblcep.Text = "CEP";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblbairro.ForeColor = System.Drawing.Color.White;
            this.lblbairro.Location = new System.Drawing.Point(43, 238);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(51, 20);
            this.lblbairro.TabIndex = 9;
            this.lblbairro.Text = "Bairro";
            this.lblbairro.Click += new System.EventHandler(this.lblbairro_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblnumero.ForeColor = System.Drawing.Color.White;
            this.lblnumero.Location = new System.Drawing.Point(29, 303);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(65, 20);
            this.lblnumero.TabIndex = 11;
            this.lblnumero.Text = "Número";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcidade.ForeColor = System.Drawing.Color.White;
            this.lblcidade.Location = new System.Drawing.Point(35, 271);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(59, 20);
            this.lblcidade.TabIndex = 10;
            this.lblcidade.Text = "Cidade";
            // 
            // textBoxCep
            // 
            this.textBoxCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCep.Location = new System.Drawing.Point(100, 171);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(86, 26);
            this.textBoxCep.TabIndex = 12;
            this.textBoxCep.TextChanged += new System.EventHandler(this.tbcep_TextChanged);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.Location = new System.Drawing.Point(100, 235);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(168, 26);
            this.textBoxBairro.TabIndex = 13;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.Location = new System.Drawing.Point(100, 268);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(168, 26);
            this.textBoxCidade.TabIndex = 14;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(100, 300);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(57, 26);
            this.textBoxNumero.TabIndex = 15;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRua.Location = new System.Drawing.Point(100, 203);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(234, 26);
            this.textBoxRua.TabIndex = 16;
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblrua.ForeColor = System.Drawing.Color.White;
            this.lblrua.Location = new System.Drawing.Point(53, 206);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(39, 20);
            this.lblrua.TabIndex = 17;
            this.lblrua.Text = "Rua";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(405, 512);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passo1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label lblrua;
    }
}