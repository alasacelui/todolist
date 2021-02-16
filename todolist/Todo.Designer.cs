
namespace todolist
{
    partial class todo_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_task = new System.Windows.Forms.TextBox();
            this.btn_insertT = new System.Windows.Forms.Button();
            this.dg_task = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MyAccount = new FontAwesome.Sharp.IconButton();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_task)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Task";
            // 
            // txt_task
            // 
            this.txt_task.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_task.Location = new System.Drawing.Point(311, 94);
            this.txt_task.Multiline = true;
            this.txt_task.Name = "txt_task";
            this.txt_task.Size = new System.Drawing.Size(192, 29);
            this.txt_task.TabIndex = 1;
            // 
            // btn_insertT
            // 
            this.btn_insertT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_insertT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertT.ForeColor = System.Drawing.Color.White;
            this.btn_insertT.Location = new System.Drawing.Point(509, 94);
            this.btn_insertT.Name = "btn_insertT";
            this.btn_insertT.Size = new System.Drawing.Size(75, 29);
            this.btn_insertT.TabIndex = 2;
            this.btn_insertT.Text = "Add";
            this.btn_insertT.UseVisualStyleBackColor = false;
            this.btn_insertT.Click += new System.EventHandler(this.btn_insertT_Click);
            // 
            // dg_task
            // 
            this.dg_task.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_task.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_task.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_task.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.dg_task.Location = new System.Drawing.Point(128, 174);
            this.dg_task.Name = "dg_task";
            this.dg_task.Size = new System.Drawing.Size(587, 217);
            this.dg_task.TabIndex = 3;
            this.dg_task.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_task_CellDoubleClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(555, 397);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 29);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(636, 397);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "🔑";
            // 
            // btn_MyAccount
            // 
            this.btn_MyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_MyAccount.FlatAppearance.BorderSize = 0;
            this.btn_MyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyAccount.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btn_MyAccount.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_MyAccount.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_MyAccount.IconSize = 25;
            this.btn_MyAccount.Location = new System.Drawing.Point(794, 4);
            this.btn_MyAccount.Name = "btn_MyAccount";
            this.btn_MyAccount.Size = new System.Drawing.Size(27, 23);
            this.btn_MyAccount.TabIndex = 6;
            this.btn_MyAccount.UseVisualStyleBackColor = false;
            this.btn_MyAccount.Click += new System.EventHandler(this.btn_MyAccount_Click);
            this.btn_MyAccount.MouseLeave += new System.EventHandler(this.btn_MyAccount_MouseLeave);
            this.btn_MyAccount.MouseHover += new System.EventHandler(this.btn_MyAccount_MouseHover);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_logout.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_logout.IconSize = 20;
            this.btn_logout.Location = new System.Drawing.Point(822, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(28, 29);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // todo_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_MyAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_task);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insertT);
            this.Controls.Add(this.txt_task);
            this.Controls.Add(this.label1);
            this.Name = "todo_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.todo_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_task;
        private System.Windows.Forms.Button btn_insertT;
        private System.Windows.Forms.DataGridView dg_task;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_MyAccount;
        private FontAwesome.Sharp.IconButton btn_logout;
    }
}