namespace VerificarPrimo
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
            btnVerificar = new Button();
            txbNumero = new TextBox();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(65, 142);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(199, 29);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar Primo";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txbNumero
            // 
            txbNumero.Location = new Point(62, 104);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(205, 23);
            txbNumero.TabIndex = 1;
            txbNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(62, 206);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(57, 15);
            lblResposta.TabIndex = 2;
            lblResposta.Text = "Resposta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 316);
            Controls.Add(lblResposta);
            Controls.Add(txbNumero);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox txbNumero;
        private Label lblResposta;
    }
}
