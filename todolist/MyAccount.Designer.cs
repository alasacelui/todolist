
namespace todolist
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.btn_MyAccount = new FontAwesome.Sharp.IconButton();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Txt_uname = new System.Windows.Forms.TextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_address = new System.Windows.Forms.TextBox();
            this.Txt_pw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_updateUser = new System.Windows.Forms.Button();
            this.Btn_back = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MyAccount
            // 
            this.btn_MyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_MyAccount.FlatAppearance.BorderSize = 0;
            this.btn_MyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyAccount.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_MyAccount.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_MyAccount.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_MyAccount.IconSize = 20;
            this.btn_MyAccount.Location = new System.Drawing.Point(286, 0);
            this.btn_MyAccount.Name = "btn_MyAccount";
            this.btn_MyAccount.Size = new System.Drawing.Size(28, 29);
            this.btn_MyAccount.TabIndex = 7;
            this.btn_MyAccount.UseVisualStyleBackColor = false;
            this.btn_MyAccount.Click += new System.EventHandler(this.btn_MyAccount_Click);
            // 
            // Txt_name
            // 
            this.Txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_name.Location = new System.Drawing.Point(58, 180);
            this.Txt_name.Multiline = true;
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(196, 27);
            this.Txt_name.TabIndex = 8;
            // 
            // Txt_uname
            // 
            this.Txt_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_uname.Location = new System.Drawing.Point(58, 213);
            this.Txt_uname.Multiline = true;
            this.Txt_uname.Name = "Txt_uname";
            this.Txt_uname.Size = new System.Drawing.Size(196, 27);
            this.Txt_uname.TabIndex = 8;
            // 
            // Txt_email
            // 
            this.Txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_email.Location = new System.Drawing.Point(58, 246);
            this.Txt_email.Multiline = true;
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(196, 27);
            this.Txt_email.TabIndex = 8;
            // 
            // Txt_address
            // 
            this.Txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_address.Location = new System.Drawing.Point(58, 279);
            this.Txt_address.Multiline = true;
            this.Txt_address.Name = "Txt_address";
            this.Txt_address.Size = new System.Drawing.Size(196, 27);
            this.Txt_address.TabIndex = 8;
            // 
            // Txt_pw
            // 
            this.Txt_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pw.Location = new System.Drawing.Point(58, 312);
            this.Txt_pw.Multiline = true;
            this.Txt_pw.Name = "Txt_pw";
            this.Txt_pw.Size = new System.Drawing.Size(196, 27);
            this.Txt_pw.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_updateUser
            // 
            this.Btn_updateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Btn_updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_updateUser.ForeColor = System.Drawing.Color.White;
            this.Btn_updateUser.Location = new System.Drawing.Point(116, 348);
            this.Btn_updateUser.Name = "Btn_updateUser";
            this.Btn_updateUser.Size = new System.Drawing.Size(75, 29);
            this.Btn_updateUser.TabIndex = 10;
            this.Btn_updateUser.Text = "Update";
            this.Btn_updateUser.UseVisualStyleBackColor = false;
            this.Btn_updateUser.Click += new System.EventHandler(this.Btn_updateUser_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.Btn_back.FlatAppearance.BorderSize = 0;
            this.Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_back.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.Btn_back.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_back.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_back.IconSize = 20;
            this.Btn_back.Location = new System.Drawing.Point(132, 382);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(39, 29);
            this.Btn_back.TabIndex = 11;
            this.Btn_back.UseVisualStyleBackColor = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(314, 423);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_updateUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_pw);
            this.Controls.Add(this.Txt_address);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.Txt_uname);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.btn_MyAccount);
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_MyAccount;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.TextBox Txt_uname;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.TextBox Txt_address;
        private System.Windows.Forms.TextBox Txt_pw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_updateUser;
        private FontAwesome.Sharp.IconButton Btn_back;
    }
}