namespace Desktop
{
    partial class frmCalculadora
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.btnRealizarOperacao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(77, 28);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(43, 13);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            this.lblValor1.Click += new System.EventHandler(this.lblValor1_Click);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(77, 89);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(43, 13);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2:";
            this.lblValor2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(73, 151);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "Operador:";
            this.lblOperador.Click += new System.EventHandler(this.lblOperador_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(135, 27);
            this.txtValor1.MaxLength = 4;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(135, 86);
            this.txtValor2.MaxLength = 4;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 2;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(135, 148);
            this.txtOperador.MaxLength = 1;
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(100, 20);
            this.txtOperador.TabIndex = 3;
            // 
            // btnRealizarOperacao
            // 
            this.btnRealizarOperacao.Location = new System.Drawing.Point(126, 204);
            this.btnRealizarOperacao.Name = "btnRealizarOperacao";
            this.btnRealizarOperacao.Size = new System.Drawing.Size(118, 28);
            this.btnRealizarOperacao.TabIndex = 4;
            this.btnRealizarOperacao.Text = "Realizar Operação";
            this.btnRealizarOperacao.UseVisualStyleBackColor = true;
            this.btnRealizarOperacao.Click += new System.EventHandler(this.btnRealizarOperacao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(117, 238);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 51);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRealizarOperacao);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Button btnRealizarOperacao;
        private System.Windows.Forms.Button btnSair;
    }
}

