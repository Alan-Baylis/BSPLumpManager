﻿namespace BSPLumpManager
{
    partial class MainWindow
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
            this.col_checked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hammerid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ent_list = new System.Windows.Forms.ListView();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.textbox_filepath = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // col_checked
            // 
            this.col_checked.Text = "Keep Id";
            // 
            // col_hammerid
            // 
            this.col_hammerid.Text = "Hammer ID";
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            // 
            // ent_list
            // 
            this.ent_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_checked,
            this.col_hammerid,
            this.col_name});
            this.ent_list.Location = new System.Drawing.Point(1, 38);
            this.ent_list.Name = "ent_list";
            this.ent_list.Size = new System.Drawing.Size(384, 473);
            this.ent_list.TabIndex = 0;
            this.ent_list.UseCompatibleStateImageBehavior = false;
            this.ent_list.View = System.Windows.Forms.View.Details;
            // 
            // open_file
            // 
            this.open_file.FileName = "openFileDialog1";
            // 
            // textbox_filepath
            // 
            this.textbox_filepath.Location = new System.Drawing.Point(12, 12);
            this.textbox_filepath.Name = "textbox_filepath";
            this.textbox_filepath.Size = new System.Drawing.Size(266, 20);
            this.textbox_filepath.TabIndex = 1;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(284, 10);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(88, 23);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open Map";
            this.button_open.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.textbox_filepath);
            this.Controls.Add(this.ent_list);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSPLump Editor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader col_checked;
        private System.Windows.Forms.ColumnHeader col_hammerid;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ListView ent_list;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.TextBox textbox_filepath;
        private System.Windows.Forms.Button button_open;
    }
}

