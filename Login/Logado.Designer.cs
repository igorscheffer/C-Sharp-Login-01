namespace Login
{
    partial class Logado
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
            this.mensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mensagem
            // 
            this.mensagem.AutoSize = true;
            this.mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem.Location = new System.Drawing.Point(190, 205);
            this.mensagem.Name = "mensagem";
            this.mensagem.Size = new System.Drawing.Size(568, 46);
            this.mensagem.TabIndex = 0;
            this.mensagem.Text = "Usuario Logado com Sucesso.";
            // 
            // Logado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.mensagem);
            this.Name = "Logado";
            this.Text = "Logado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensagem;
    }
}