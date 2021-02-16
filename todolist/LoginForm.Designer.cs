
namespace todolist
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_showRegisterFrm = new System.Windows.Forms.Button();
            this.cb_togglepw = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_email.Location = new System.Drawing.Point(92, 62);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 20);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(142, 57);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(193, 25);
            this.txt_email.TabIndex = 1;
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pw.Location = new System.Drawing.Point(73, 91);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(66, 20);
            this.lbl_pw.TabIndex = 0;
            this.lbl_pw.Text = "Password:";
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(142, 88);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(193, 25);
            this.txt_pw.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.Location = new System.Drawing.Point(259, 121);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_showRegisterFrm
            // 
            this.btn_showRegisterFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_showRegisterFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_showRegisterFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showRegisterFrm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_showRegisterFrm.Location = new System.Drawing.Point(179, 121);
            this.btn_showRegisterFrm.Name = "btn_showRegisterFrm";
            this.btn_showRegisterFrm.Size = new System.Drawing.Size(75, 23);
            this.btn_showRegisterFrm.TabIndex = 3;
            this.btn_showRegisterFrm.Text = "Register";
            this.btn_showRegisterFrm.UseVisualStyleBackColor = false;
            this.btn_showRegisterFrm.Click += new System.EventHandler(this.btn_showRegisterFrm_Click);
            // 
            // cb_togglepw
            // 
            this.cb_togglepw.AutoSize = true;
            this.cb_togglepw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_togglepw.Location = new System.Drawing.Point(341, 99);
            this.cb_togglepw.Name = "cb_togglepw";
            this.cb_togglepw.Size = new System.Drawing.Size(15, 14);
            this.cb_togglepw.TabIndex = 3;
            this.cb_togglepw.UseVisualStyleBackColor = true;
            this.cb_togglepw.CheckedChanged += new System.EventHandler(this.cb_togglepw_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "👁️";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(417, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showRegisterFrm);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.cb_togglepw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 230);
            this.MinimumSize = new System.Drawing.Size(460, 230);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_showRegisterFrm;
        private System.Windows.Forms.CheckBox cb_togglepw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

