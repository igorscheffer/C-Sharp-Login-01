namespace Login
{
    partial class Login
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
            this.textLogin = new System.Windows.Forms.TextBox();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.iconSenha = new FontAwesome.Sharp.IconPictureBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.buttonClose = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.buttonLogin = new FontAwesome.Sharp.IconButton();
            this.iconMostrarSenha = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMostrarSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.textLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.Color.White;
            this.textLogin.Location = new System.Drawing.Point(63, 139);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(204, 22);
            this.textLogin.TabIndex = 0;
            this.textLogin.Tag = "login";
            this.textLogin.Enter += new System.EventHandler(this.TextFocusEnter);
            this.textLogin.Leave += new System.EventHandler(this.TextFocusLeave);
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.iconLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.iconLogin.IconSize = 24;
            this.iconLogin.Location = new System.Drawing.Point(33, 139);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(24, 24);
            this.iconLogin.TabIndex = 1;
            this.iconLogin.TabStop = false;
            // 
            // iconSenha
            // 
            this.iconSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.iconSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.iconSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconSenha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.iconSenha.IconSize = 24;
            this.iconSenha.Location = new System.Drawing.Point(33, 201);
            this.iconSenha.Name = "iconSenha";
            this.iconSenha.Size = new System.Drawing.Size(24, 24);
            this.iconSenha.TabIndex = 2;
            this.iconSenha.TabStop = false;
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.ForeColor = System.Drawing.Color.White;
            this.textSenha.Location = new System.Drawing.Point(63, 201);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(166, 22);
            this.textSenha.TabIndex = 3;
            this.textSenha.Enter += new System.EventHandler(this.TextFocusEnter);
            this.textSenha.Leave += new System.EventHandler(this.TextFocusLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.buttonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.buttonClose.Location = new System.Drawing.Point(257, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonClose.TabIndex = 4;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseGdi = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseOnClick);
            this.buttonClose.MouseLeave += new System.EventHandler(this.CloseOnLeave);
            this.buttonClose.MouseHover += new System.EventHandler(this.CloseOnHover);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.panelLogin.Location = new System.Drawing.Point(33, 167);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(234, 2);
            this.panelLogin.TabIndex = 5;
            // 
            // panelSenha
            // 
            this.panelSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.panelSenha.Location = new System.Drawing.Point(33, 231);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(234, 2);
            this.panelSenha.TabIndex = 6;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(106, 68);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 31);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Log In";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.buttonLogin.IconColor = System.Drawing.Color.White;
            this.buttonLogin.IconSize = 16;
            this.buttonLogin.Location = new System.Drawing.Point(33, 302);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Rotation = 0D;
            this.buttonLogin.Size = new System.Drawing.Size(234, 40);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.LogInValidation);
            // 
            // iconMostrarSenha
            // 
            this.iconMostrarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.iconMostrarSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconMostrarSenha.IconColor = System.Drawing.Color.White;
            this.iconMostrarSenha.IconSize = 26;
            this.iconMostrarSenha.Location = new System.Drawing.Point(241, 204);
            this.iconMostrarSenha.Name = "iconMostrarSenha";
            this.iconMostrarSenha.Size = new System.Drawing.Size(26, 26);
            this.iconMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconMostrarSenha.TabIndex = 9;
            this.iconMostrarSenha.TabStop = false;
            this.iconMostrarSenha.Click += new System.EventHandler(this.MostrarSenhaOnClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(300, 389);
            this.Controls.Add(this.iconMostrarSenha);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panelSenha);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.iconSenha);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.textLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.OnShowForm);
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMostrarSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private FontAwesome.Sharp.IconPictureBox iconSenha;
        private System.Windows.Forms.TextBox textSenha;
        private FontAwesome.Sharp.IconPictureBox buttonClose;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton buttonLogin;
        private FontAwesome.Sharp.IconPictureBox iconMostrarSenha;
    }
}

