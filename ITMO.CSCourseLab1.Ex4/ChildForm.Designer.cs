﻿
namespace ITMO.CSCourse.WFAppLab1._4
{
    partial class ChildForm
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
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.ChildWindowMenue = new System.Windows.Forms.MenuStrip();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildWindowMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 24);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(800, 426);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChildWindowMenue
            // 
            this.ChildWindowMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatMenuItem});
            this.ChildWindowMenue.Location = new System.Drawing.Point(0, 0);
            this.ChildWindowMenue.Name = "ChildWindowMenue";
            this.ChildWindowMenue.Size = new System.Drawing.Size(800, 24);
            this.ChildWindowMenue.TabIndex = 1;
            this.ChildWindowMenue.Text = "menuStrip1";
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleMenuItem});
            this.FormatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FormatMenuItem.Text = "&Format";
            // 
            // ToggleMenuItem
            // 
            this.ToggleMenuItem.Name = "ToggleMenuItem";
            this.ToggleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ToggleMenuItem.Text = "&Toggle Foreground";
            this.ToggleMenuItem.Click += new System.EventHandler(this.ToggleMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.ChildWindowMenue);
            this.MainMenuStrip = this.ChildWindowMenue;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ChildWindowMenue.ResumeLayout(false);
            this.ChildWindowMenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChildTextBox;
        private System.Windows.Forms.MenuStrip ChildWindowMenue;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToggleMenuItem;
    }
}