namespace Thuchanh3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyễnThanhTuânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trầnThanhHoàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thànhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thànhViênToolStripMenuItem
            // 
            this.thànhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnThanhTuânToolStripMenuItem,
            this.trầnThanhHoàngToolStripMenuItem});
            this.thànhViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.thànhViênToolStripMenuItem.Text = "Thành Viên";
            // 
            // nguyễnThanhTuânToolStripMenuItem
            // 
            this.nguyễnThanhTuânToolStripMenuItem.Name = "nguyễnThanhTuânToolStripMenuItem";
            this.nguyễnThanhTuânToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.nguyễnThanhTuânToolStripMenuItem.Text = "Nguyễn Thanh Tuân";
            this.nguyễnThanhTuânToolStripMenuItem.Click += new System.EventHandler(this.nguyễnThanhTuânToolStripMenuItem_Click);
            // 
            // trầnThanhHoàngToolStripMenuItem
            // 
            this.trầnThanhHoàngToolStripMenuItem.Name = "trầnThanhHoàngToolStripMenuItem";
            this.trầnThanhHoàngToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.trầnThanhHoàngToolStripMenuItem.Text = "Trần Thanh Hoàng";
            this.trầnThanhHoàngToolStripMenuItem.Click += new System.EventHandler(this.trầnThanhHoàngToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 544);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyễnThanhTuânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trầnThanhHoàngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

