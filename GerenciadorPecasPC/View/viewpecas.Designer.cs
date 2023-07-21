namespace GerenciadorPecasPC.View
{
    partial class viewpecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Peça = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPeca = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.txtBoxCapacidade = new System.Windows.Forms.TextBox();
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(180, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR PEÇAS";
            // 
            // Peça
            // 
            this.Peça.AutoSize = true;
            this.Peça.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Peça.ForeColor = System.Drawing.Color.LightPink;
            this.Peça.Location = new System.Drawing.Point(77, 103);
            this.Peça.Name = "Peça";
            this.Peça.Size = new System.Drawing.Size(53, 23);
            this.Peça.TabIndex = 1;
            this.Peça.Text = "Peça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(77, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightPink;
            this.label4.Location = new System.Drawing.Point(77, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxPeca
            // 
            this.txtBoxPeca.Location = new System.Drawing.Point(161, 106);
            this.txtBoxPeca.Name = "txtBoxPeca";
            this.txtBoxPeca.Size = new System.Drawing.Size(224, 23);
            this.txtBoxPeca.TabIndex = 4;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(164, 171);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(221, 23);
            this.txtBoxMarca.TabIndex = 5;
            // 
            // txtBoxCapacidade
            // 
            this.txtBoxCapacidade.Location = new System.Drawing.Point(190, 235);
            this.txtBoxCapacidade.Name = "txtBoxCapacidade";
            this.txtBoxCapacidade.Size = new System.Drawing.Size(195, 23);
            this.txtBoxCapacidade.TabIndex = 6;
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPecas.ForeColor = System.Drawing.Color.HotPink;
            this.btnCadastrarPecas.Location = new System.Drawing.Point(209, 323);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastrarPecas.Size = new System.Drawing.Size(154, 38);
            this.btnCadastrarPecas.TabIndex = 7;
            this.btnCadastrarPecas.Text = "Cadastrar";
            this.btnCadastrarPecas.UseVisualStyleBackColor = true;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // viewpecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.txtBoxCapacidade);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.txtBoxPeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Peça);
            this.Controls.Add(this.label1);
            this.Name = "viewpecas";
            this.Text = "viewpecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Peça;
        private Label label3;
        private Label label4;
        private TextBox txtBoxPeca;
        private TextBox txtBoxMarca;
        private TextBox txtBoxCapacidade;
        private Button btnCadastrarPecas;
    }
}