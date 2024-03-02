
namespace Login_and_register
{
    partial class ViewBooking2
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
            this.View2DGV = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bookingbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View2DGV)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // View2DGV
            // 
            this.View2DGV.BackgroundColor = System.Drawing.Color.White;
            this.View2DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View2DGV.Location = new System.Drawing.Point(215, 80);
            this.View2DGV.Name = "View2DGV";
            this.View2DGV.Size = new System.Drawing.Size(1016, 402);
            this.View2DGV.TabIndex = 11;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.bookingbutton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 402);
            this.panelMenu.TabIndex = 9;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1231, 80);
            this.panelTitleBar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW BOOKING";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Image = global::Login_and_register.Properties.Resources.back;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookingbutton
            // 
            this.bookingbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingbutton.FlatAppearance.BorderSize = 0;
            this.bookingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingbutton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbutton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bookingbutton.Image = global::Login_and_register.Properties.Resources.booking;
            this.bookingbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingbutton.Location = new System.Drawing.Point(0, 0);
            this.bookingbutton.Name = "bookingbutton";
            this.bookingbutton.Size = new System.Drawing.Size(220, 60);
            this.bookingbutton.TabIndex = 1;
            this.bookingbutton.Text = "Delete Booking";
            this.bookingbutton.UseVisualStyleBackColor = true;
            // 
            // ViewBooking2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 482);
            this.Controls.Add(this.View2DGV);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "ViewBooking2";
            this.Text = "ViewBooking2";
            this.Load += new System.EventHandler(this.ViewBooking2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View2DGV)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView View2DGV;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bookingbutton;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
    }
}