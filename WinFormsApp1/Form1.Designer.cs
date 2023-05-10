namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.iblValor1 = new System.Windows.Forms.Label();
            this.iblValor2 = new System.Windows.Forms.Label();
            this.iblOperador = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.iblRealizarOperacao = new System.Windows.Forms.Button();
            this.iblSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(221, 47);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 23);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // iblValor1
            // 
            this.iblValor1.AutoSize = true;
            this.iblValor1.Location = new System.Drawing.Point(107, 55);
            this.iblValor1.Name = "iblValor1";
            this.iblValor1.Size = new System.Drawing.Size(45, 15);
            this.iblValor1.TabIndex = 1;
            this.iblValor1.Text = "Valor 1:";
            this.iblValor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iblValor2
            // 
            this.iblValor2.AutoSize = true;
            this.iblValor2.Location = new System.Drawing.Point(107, 113);
            this.iblValor2.Name = "iblValor2";
            this.iblValor2.Size = new System.Drawing.Size(45, 15);
            this.iblValor2.TabIndex = 2;
            this.iblValor2.Text = "Valor 2:";
            // 
            // iblOperador
            // 
            this.iblOperador.AutoSize = true;
            this.iblOperador.Location = new System.Drawing.Point(107, 170);
            this.iblOperador.Name = "iblOperador";
            this.iblOperador.Size = new System.Drawing.Size(100, 15);
            this.iblOperador.TabIndex = 3;
            this.iblOperador.Text = "Operador(+ - / *):";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(221, 110);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 23);
            this.txtValor2.TabIndex = 4;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(221, 162);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(100, 23);
            this.txtOperador.TabIndex = 5;
            // 
            // iblRealizarOperacao
            // 
            this.iblRealizarOperacao.Location = new System.Drawing.Point(150, 232);
            this.iblRealizarOperacao.Name = "iblRealizarOperacao";
            this.iblRealizarOperacao.Size = new System.Drawing.Size(121, 23);
            this.iblRealizarOperacao.TabIndex = 6;
            this.iblRealizarOperacao.Text = "Fazer Operação";
            this.iblRealizarOperacao.UseVisualStyleBackColor = true;
            this.iblRealizarOperacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // iblSair
            // 
            this.iblSair.Location = new System.Drawing.Point(171, 350);
            this.iblSair.Name = "iblSair";
            this.iblSair.Size = new System.Drawing.Size(75, 23);
            this.iblSair.TabIndex = 7;
            this.iblSair.Text = "Sair";
            this.iblSair.UseVisualStyleBackColor = true;
            this.iblSair.Click += new System.EventHandler(this.iblSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.iblSair);
            this.Controls.Add(this.iblRealizarOperacao);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.iblOperador);
            this.Controls.Add(this.iblValor2);
            this.Controls.Add(this.iblValor1);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValor1;
        private Label iblValor1;
        private Label iblValor2;
        private Label iblOperador;
        private TextBox txtValor2;
        private TextBox txtOperador;
        private Button iblRealizarOperacao;
        private Button iblSair;
    }
}