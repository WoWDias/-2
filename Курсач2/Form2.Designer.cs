﻿namespace Курсач2
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yeat_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обПрограммеToolStripMenuItem
            // 
            this.обПрограммеToolStripMenuItem.Name = "обПрограммеToolStripMenuItem";
            this.обПрограммеToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.обПрограммеToolStripMenuItem.Text = "Об программе";
            this.обПрограммеToolStripMenuItem.Click += new System.EventHandler(this.обПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.phone_number,
            this.Yeat_of_birth,
            this.order_id});
            this.dataGridView1.Location = new System.Drawing.Point(13, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.Width = 125;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 125;
            // 
            // Yeat_of_birth
            // 
            this.Yeat_of_birth.HeaderText = "Год рождения";
            this.Yeat_of_birth.Name = "Yeat_of_birth";
            // 
            // order_id
            // 
            this.order_id.HeaderText = "ID Заказа";
            this.order_id.Name = "order_id";
            this.order_id.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_download);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(685, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(6, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_delete.Location = new System.Drawing.Point(6, 169);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(188, 35);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_update.Location = new System.Drawing.Point(6, 128);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(188, 35);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_add.Location = new System.Drawing.Point(6, 87);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(188, 35);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_download
            // 
            this.button_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_download.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_download.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_download.Location = new System.Drawing.Point(6, 46);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(188, 35);
            this.button_download.TabIndex = 0;
            this.button_download.Text = "Загрузить";
            this.button_download.UseVisualStyleBackColor = false;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(927, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yeat_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.Button button1;
    }
}