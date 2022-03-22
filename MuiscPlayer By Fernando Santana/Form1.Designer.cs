namespace MuiscPlayer_By_Fernando_Santana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkAleatoria = new System.Windows.Forms.CheckBox();
            this.checkRepetir = new System.Windows.Forms.CheckBox();
            this.BtnPrimeira = new System.Windows.Forms.Button();
            this.BtnUltima = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProxima = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkAleatoria
            // 
            this.checkAleatoria.AutoSize = true;
            this.checkAleatoria.Image = ((System.Drawing.Image)(resources.GetObject("checkAleatoria.Image")));
            this.checkAleatoria.Location = new System.Drawing.Point(123, 320);
            this.checkAleatoria.Name = "checkAleatoria";
            this.checkAleatoria.Size = new System.Drawing.Size(53, 31);
            this.checkAleatoria.TabIndex = 65;
            this.checkAleatoria.UseVisualStyleBackColor = true;
            // 
            // checkRepetir
            // 
            this.checkRepetir.AutoSize = true;
            this.checkRepetir.Image = ((System.Drawing.Image)(resources.GetObject("checkRepetir.Image")));
            this.checkRepetir.Location = new System.Drawing.Point(182, 320);
            this.checkRepetir.Name = "checkRepetir";
            this.checkRepetir.Size = new System.Drawing.Size(53, 31);
            this.checkRepetir.TabIndex = 64;
            this.checkRepetir.UseVisualStyleBackColor = true;
            // 
            // BtnPrimeira
            // 
            this.BtnPrimeira.AutoSize = true;
            this.BtnPrimeira.FlatAppearance.BorderSize = 0;
            this.BtnPrimeira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimeira.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrimeira.Image")));
            this.BtnPrimeira.Location = new System.Drawing.Point(7, 267);
            this.BtnPrimeira.Name = "BtnPrimeira";
            this.BtnPrimeira.Size = new System.Drawing.Size(54, 54);
            this.BtnPrimeira.TabIndex = 63;
            this.BtnPrimeira.UseVisualStyleBackColor = true;
            this.BtnPrimeira.Click += new System.EventHandler(this.BtnPrimeira_Click);
            // 
            // BtnUltima
            // 
            this.BtnUltima.AutoSize = true;
            this.BtnUltima.FlatAppearance.BorderSize = 0;
            this.BtnUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUltima.Image = ((System.Drawing.Image)(resources.GetObject("BtnUltima.Image")));
            this.BtnUltima.Location = new System.Drawing.Point(302, 267);
            this.BtnUltima.Name = "BtnUltima";
            this.BtnUltima.Size = new System.Drawing.Size(54, 54);
            this.BtnUltima.TabIndex = 62;
            this.BtnUltima.UseVisualStyleBackColor = true;
            this.BtnUltima.Click += new System.EventHandler(this.BtnUltima_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.AutoSize = true;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(182, 267);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(54, 54);
            this.BtnStop.TabIndex = 61;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.AutoSize = true;
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.Location = new System.Drawing.Point(67, 267);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(54, 54);
            this.BtnAnterior.TabIndex = 60;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProxima
            // 
            this.BtnProxima.AutoSize = true;
            this.BtnProxima.FlatAppearance.BorderSize = 0;
            this.BtnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProxima.Image = ((System.Drawing.Image)(resources.GetObject("BtnProxima.Image")));
            this.BtnProxima.Location = new System.Drawing.Point(242, 267);
            this.BtnProxima.Name = "BtnProxima";
            this.BtnProxima.Size = new System.Drawing.Size(54, 54);
            this.BtnProxima.TabIndex = 59;
            this.BtnProxima.UseVisualStyleBackColor = true;
            this.BtnProxima.Click += new System.EventHandler(this.BtnProxima_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.AutoSize = true;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Location = new System.Drawing.Point(128, 270);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(48, 48);
            this.BtnPlay.TabIndex = 58;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 28);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abirToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.menuToolStripMenuItem.Text = "Arquivo";
            // 
            // abirToolStripMenuItem
            // 
            this.abirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abirToolStripMenuItem.Image")));
            this.abirToolStripMenuItem.Name = "abirToolStripMenuItem";
            this.abirToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.abirToolStripMenuItem.Text = "&Abir";
            this.abirToolStripMenuItem.Click += new System.EventHandler(this.abirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(103, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(7, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(349, 226);
            this.treeView1.TabIndex = 56;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "music.png");
            this.imageList1.Images.SetKeyName(1, "tempo.png");
            this.imageList1.Images.SetKeyName(2, "Album.png");
            this.imageList1.Images.SetKeyName(3, "bitrate.png");
            this.imageList1.Images.SetKeyName(4, "pasta.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 353);
            this.Controls.Add(this.checkAleatoria);
            this.Controls.Add(this.checkRepetir);
            this.Controls.Add(this.BtnPrimeira);
            this.Controls.Add(this.BtnUltima);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProxima);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAleatoria;
        private System.Windows.Forms.CheckBox checkRepetir;
        private System.Windows.Forms.Button BtnPrimeira;
        private System.Windows.Forms.Button BtnUltima;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProxima;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

