
namespace Login_and_register
{
    partial class Clint
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
            this.ClintDGV = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClintPhoneTb = new System.Windows.Forms.TextBox();
            this.ClintAddressTb = new System.Windows.Forms.TextBox();
            this.ClintNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClintDGV)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClintDGV
            // 
            this.ClintDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClintDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClintDGV.Location = new System.Drawing.Point(250, 80);
            this.ClintDGV.Name = "ClintDGV";
            this.ClintDGV.Size = new System.Drawing.Size(550, 370);
            this.ClintDGV.TabIndex = 8;
            this.ClintDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClintDGV_CellClick);
            this.ClintDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClintDGV_CellContentClick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.ClintPhoneTb);
            this.panelMenu.Controls.Add(this.ClintAddressTb);
            this.panelMenu.Controls.Add(this.ClintNameTb);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(249, 370);
            this.panelMenu.TabIndex = 6;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(67, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 36);
            this.button5.TabIndex = 37;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(129, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 36);
            this.button4.TabIndex = 37;
            this.button4.Text = "RESET";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(13, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 37;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(129, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 37;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(15, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 37;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClintPhoneTb
            // 
            this.ClintPhoneTb.Location = new System.Drawing.Point(79, 102);
            this.ClintPhoneTb.Name = "ClintPhoneTb";
            this.ClintPhoneTb.Size = new System.Drawing.Size(146, 20);
            this.ClintPhoneTb.TabIndex = 36;
            this.ClintPhoneTb.TextChanged += new System.EventHandler(this.ClintPhoneTb_TextChanged);
            // 
            // ClintAddressTb
            // 
            this.ClintAddressTb.Location = new System.Drawing.Point(79, 68);
            this.ClintAddressTb.Name = "ClintAddressTb";
            this.ClintAddressTb.Size = new System.Drawing.Size(146, 20);
            this.ClintAddressTb.TabIndex = 36;
            this.ClintAddressTb.TextChanged += new System.EventHandler(this.ClintAddressTb_TextChanged);
            // 
            // ClintNameTb
            // 
            this.ClintNameTb.Location = new System.Drawing.Point(79, 36);
            this.ClintNameTb.Name = "ClintNameTb";
            this.ClintNameTb.Size = new System.Drawing.Size(146, 20);
            this.ClintNameTb.TabIndex = 36;
            this.ClintNameTb.TextChanged += new System.EventHandler(this.ClintNameTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "PHONE ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "ADRESS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 80);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLINT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClintDGV);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "Clint";
            this.Text = "Clint";
            this.Load += new System.EventHandler(this.Clint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClintDGV)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClintDGV;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ClintPhoneTb;
        private System.Windows.Forms.TextBox ClintAddressTb;
        private System.Windows.Forms.TextBox ClintNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}