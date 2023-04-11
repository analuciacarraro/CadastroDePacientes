namespace SystemLogin
{
    partial class F_SystemLogin
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pb_imge = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.Location = new System.Drawing.Point(404, 501);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(147, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(267, 364);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(431, 32);
            this.tb_password.TabIndex = 4;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(267, 301);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(431, 32);
            this.tb_login.TabIndex = 3;
            this.tb_login.Enter += new System.EventHandler(this.tb_loginEnter);
            this.tb_login.Leave += new System.EventHandler(this.tb_loginExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(422, 274);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(81, 23);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Usuário";
            // 
            // pb_imge
            // 
            this.pb_imge.Image = global::SystemLogin.Properties.Resources.user_2;
            this.pb_imge.Location = new System.Drawing.Point(368, 73);
            this.pb_imge.Margin = new System.Windows.Forms.Padding(4);
            this.pb_imge.Name = "pb_imge";
            this.pb_imge.Size = new System.Drawing.Size(221, 179);
            this.pb_imge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imge.TabIndex = 0;
            this.pb_imge.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(582, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Se não houver cadastro, Clique aqui";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // F_SystemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.pb_imge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "F_SystemLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.F_SystemLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_imge;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}

