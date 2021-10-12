
using System.Drawing;
using System.Windows.Forms;

namespace myHomework
{
    partial class Homework
    {
        private System.ComponentModel.IContainer components = null;
        private Button enter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework));
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.AccessibleDescription = "";
            this.enter.AccessibleName = "";
            this.enter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enter.BackColor = System.Drawing.SystemColors.GrayText;
            this.enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Location = new System.Drawing.Point(0, 415);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(752, 35);
            this.enter.TabIndex = 0;
            this.enter.Text = "Защищаться";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Homework
            // 
            this.AccessibleName = "myHomework";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.enter);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Homework";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Witcher\'s job";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        private void InitializeButton()
        {
                        
        }
        #endregion

    }
}

