namespace Program_TA.Forms
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dashboardUC2 = new Program_TA.User_Controls.DashboardUC();
            this.pesanSekarang1 = new Program_TA.User_Controls.PesanSekarang();
            this.Menu = new Program_TA.User_Controls.Menu();
            this.dashboardUC1 = new Program_TA.User_Controls.DashboardUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 501);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pesan Sekarang";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHeader.Controls.Add(this.button4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(130, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(917, 42);
            this.panelHeader.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(877, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 41);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(163, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(90, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Dashboard";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.dashboardUC2);
            this.panelContainer.Controls.Add(this.pesanSekarang1);
            this.panelContainer.Controls.Add(this.Menu);
            this.panelContainer.Controls.Add(this.dashboardUC1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(130, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(917, 429);
            this.panelContainer.TabIndex = 2;
            // 
            // dashboardUC2
            // 
            this.dashboardUC2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUC2.Location = new System.Drawing.Point(0, 0);
            this.dashboardUC2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardUC2.Name = "dashboardUC2";
            this.dashboardUC2.Size = new System.Drawing.Size(917, 429);
            this.dashboardUC2.TabIndex = 3;
            // 
            // pesanSekarang1
            // 
            this.pesanSekarang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesanSekarang1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesanSekarang1.Location = new System.Drawing.Point(0, 0);
            this.pesanSekarang1.Name = "pesanSekarang1";
            this.pesanSekarang1.Size = new System.Drawing.Size(917, 429);
            this.pesanSekarang1.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(917, 429);
            this.Menu.TabIndex = 1;
            // 
            // dashboardUC1
            // 
            this.dashboardUC1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUC1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUC1.Margin = new System.Windows.Forms.Padding(31004037, 99064882, 31004037, 99064882);
            this.dashboardUC1.Name = "dashboardUC1";
            this.dashboardUC1.Size = new System.Drawing.Size(917, 429);
            this.dashboardUC1.TabIndex = 0;
            // 
            // formMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1047, 501);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContainer;
        private User_Controls.DashboardUC dashboardUC1;
        private User_Controls.Menu Menu;
        private User_Controls.PesanSekarang pesanSekarang1;
        private User_Controls.DashboardUC dashboardUC2;
    }
}