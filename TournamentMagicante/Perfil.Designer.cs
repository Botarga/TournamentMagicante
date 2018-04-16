namespace TournamentMagicante
{
    partial class Perfil
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifyPassBt = new System.Windows.Forms.Button();
            this.pass2Tb = new System.Windows.Forms.TextBox();
            this.pass1Tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.chooseLocationBt = new System.Windows.Forms.Button();
            this.modifyDataBt = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.locationTb = new System.Windows.Forms.TextBox();
            this.infoLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localización:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nueva Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmar Contraseña:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifyPassBt);
            this.groupBox1.Controls.Add(this.pass2Tb);
            this.groupBox1.Controls.Add(this.pass1Tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(354, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar contraseña";
            // 
            // modifyPassBt
            // 
            this.modifyPassBt.Enabled = false;
            this.modifyPassBt.Location = new System.Drawing.Point(123, 74);
            this.modifyPassBt.Name = "modifyPassBt";
            this.modifyPassBt.Size = new System.Drawing.Size(75, 23);
            this.modifyPassBt.TabIndex = 8;
            this.modifyPassBt.Text = "Modificar";
            this.modifyPassBt.UseVisualStyleBackColor = true;
            this.modifyPassBt.Click += new System.EventHandler(this.modifyPassBt_Click);
            // 
            // pass2Tb
            // 
            this.pass2Tb.Location = new System.Drawing.Point(123, 48);
            this.pass2Tb.Name = "pass2Tb";
            this.pass2Tb.Size = new System.Drawing.Size(128, 20);
            this.pass2Tb.TabIndex = 7;
            this.pass2Tb.TextChanged += new System.EventHandler(this.pass2Tb_TextChanged);
            // 
            // pass1Tb
            // 
            this.pass1Tb.Location = new System.Drawing.Point(123, 22);
            this.pass1Tb.Name = "pass1Tb";
            this.pass1Tb.PasswordChar = '*';
            this.pass1Tb.Size = new System.Drawing.Size(128, 20);
            this.pass1Tb.TabIndex = 6;
            this.pass1Tb.TextChanged += new System.EventHandler(this.pass1Tb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ageNumeric);
            this.groupBox2.Controls.Add(this.chooseLocationBt);
            this.groupBox2.Controls.Add(this.modifyDataBt);
            this.groupBox2.Controls.Add(this.nameTb);
            this.groupBox2.Controls.Add(this.usernameTb);
            this.groupBox2.Controls.Add(this.locationTb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(81, 96);
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(116, 20);
            this.ageNumeric.TabIndex = 10;
            this.ageNumeric.ValueChanged += new System.EventHandler(this.ageNumeric_ValueChanged);
            // 
            // chooseLocationBt
            // 
            this.chooseLocationBt.Location = new System.Drawing.Point(212, 45);
            this.chooseLocationBt.Name = "chooseLocationBt";
            this.chooseLocationBt.Size = new System.Drawing.Size(75, 23);
            this.chooseLocationBt.TabIndex = 9;
            this.chooseLocationBt.Text = "Elegir";
            this.chooseLocationBt.UseVisualStyleBackColor = true;
            this.chooseLocationBt.Click += new System.EventHandler(this.chooseLocationBt_Click);
            // 
            // modifyDataBt
            // 
            this.modifyDataBt.Location = new System.Drawing.Point(101, 129);
            this.modifyDataBt.Name = "modifyDataBt";
            this.modifyDataBt.Size = new System.Drawing.Size(75, 23);
            this.modifyDataBt.TabIndex = 8;
            this.modifyDataBt.Text = "Modificar";
            this.modifyDataBt.UseVisualStyleBackColor = true;
            this.modifyDataBt.Click += new System.EventHandler(this.modifyDataBt_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(81, 21);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(116, 20);
            this.nameTb.TabIndex = 7;
            this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(81, 70);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(116, 20);
            this.usernameTb.TabIndex = 5;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            // 
            // locationTb
            // 
            this.locationTb.Location = new System.Drawing.Point(81, 47);
            this.locationTb.Name = "locationTb";
            this.locationTb.ReadOnly = true;
            this.locationTb.Size = new System.Drawing.Size(116, 20);
            this.locationTb.TabIndex = 4;
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(12, 185);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(0, 13);
            this.infoLb.TabIndex = 8;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 207);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox locationTb;
        private System.Windows.Forms.TextBox pass2Tb;
        private System.Windows.Forms.TextBox pass1Tb;
        private System.Windows.Forms.Button chooseLocationBt;
        private System.Windows.Forms.Button modifyDataBt;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button modifyPassBt;
        private System.Windows.Forms.NumericUpDown ageNumeric;
        private System.Windows.Forms.Label infoLb;
    }
}