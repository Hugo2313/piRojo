namespace pet4sitter
{
    partial class FrmAdminUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminUsuarios));
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblUsuarioss = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbAdministrator = new System.Windows.Forms.CheckBox();
            this.ckbSitter = new System.Windows.Forms.CheckBox();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblSitter = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(637, 512);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(275, 26);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblUsuarioss
            // 
            this.lblUsuarioss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioss.AutoSize = true;
            this.lblUsuarioss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioss.Location = new System.Drawing.Point(118, 43);
            this.lblUsuarioss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioss.Name = "lblUsuarioss";
            this.lblUsuarioss.Size = new System.Drawing.Size(190, 20);
            this.lblUsuarioss.TabIndex = 55;
            this.lblUsuarioss.Text = "Usuarios Desplegados";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(637, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 469);
            this.panel1.TabIndex = 52;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(67, 429);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(142, 26);
            this.btnEliminarUsuario.TabIndex = 47;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ckbAdministrator);
            this.panel4.Controls.Add(this.ckbSitter);
            this.panel4.Controls.Add(this.lblAdministrator);
            this.panel4.Controls.Add(this.lblSitter);
            this.panel4.Controls.Add(this.lblPassword);
            this.panel4.Controls.Add(this.lblDni);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.lblId);
            this.panel4.Controls.Add(this.ptbImagen);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Location = new System.Drawing.Point(18, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 395);
            this.panel4.TabIndex = 45;
            // 
            // ckbAdministrator
            // 
            this.ckbAdministrator.AutoSize = true;
            this.ckbAdministrator.Location = new System.Drawing.Point(158, 365);
            this.ckbAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.ckbAdministrator.Name = "ckbAdministrator";
            this.ckbAdministrator.Size = new System.Drawing.Size(15, 14);
            this.ckbAdministrator.TabIndex = 20;
            this.ckbAdministrator.UseVisualStyleBackColor = true;
            // 
            // ckbSitter
            // 
            this.ckbSitter.AutoSize = true;
            this.ckbSitter.Location = new System.Drawing.Point(158, 335);
            this.ckbSitter.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSitter.Name = "ckbSitter";
            this.ckbSitter.Size = new System.Drawing.Size(15, 14);
            this.ckbSitter.TabIndex = 19;
            this.ckbSitter.UseVisualStyleBackColor = true;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Enabled = false;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(29, 358);
            this.lblAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(116, 20);
            this.lblAdministrator.TabIndex = 17;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblSitter
            // 
            this.lblSitter.AutoSize = true;
            this.lblSitter.Enabled = false;
            this.lblSitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitter.Location = new System.Drawing.Point(29, 328);
            this.lblSitter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSitter.Name = "lblSitter";
            this.lblSitter.Size = new System.Drawing.Size(53, 20);
            this.lblSitter.TabIndex = 16;
            this.lblSitter.Text = "Sitter";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(29, 298);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Enabled = false;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(29, 266);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 20);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "Dni";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 234);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 202);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(29, 172);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 20);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(70, 57);
            this.ptbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(114, 91);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 10;
            this.ptbImagen.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(92, 25);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 20);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.dgvUsers);
            this.panel3.Location = new System.Drawing.Point(112, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 438);
            this.panel3.TabIndex = 50;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.ColumnHeadersHeight = 29;
            this.dgvUsers.Location = new System.Drawing.Point(28, 16);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(464, 398);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "iduser";
            // 
            // FrmAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblUsuarioss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1125, 635);
            this.Name = "FrmAdminUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminUsuarios";
            this.Load += new System.EventHandler(this.FrmAdminUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblUsuarioss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblSitter;
        private System.Windows.Forms.CheckBox ckbAdministrator;
        private System.Windows.Forms.CheckBox ckbSitter;
        private System.Windows.Forms.Label lblPassword;
    }
}
