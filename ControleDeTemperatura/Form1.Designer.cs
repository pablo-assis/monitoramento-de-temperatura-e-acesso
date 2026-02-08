namespace ControleDeTemperatura
{
    partial class ControleTemperatura
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleTemperatura));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            _log = new TextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            _lblPres = new Label();
            _lblDist = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            _lblTemp = new Label();
            lblStatus = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            lbltemperatura = new Label();
            lblPorta = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            label2 = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 344F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 536F));
            tableLayoutPanel1.Size = new Size(916, 536);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(_log, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 352F));
            tableLayoutPanel2.Size = new Size(338, 532);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 136);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 0;
            label1.Text = "RETORNO DA BITDOGLAB";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _log
            // 
            _log.Dock = DockStyle.Fill;
            _log.Location = new Point(3, 176);
            _log.Margin = new Padding(3, 2, 3, 2);
            _log.Multiline = true;
            _log.Name = "_log";
            _log.Size = new Size(333, 354);
            _log.TabIndex = 2;
            _log.Text = "AGUARDANDO...";
            _log.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.EmbarcaTech;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(lblStatus, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(347, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Size = new Size(566, 532);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(_lblPres, 1, 1);
            tableLayoutPanel4.Controls.Add(_lblDist, 0, 1);
            tableLayoutPanel4.Controls.Add(label5, 2, 0);
            tableLayoutPanel4.Controls.Add(label4, 1, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(_lblTemp, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 31.87773F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 68.12227F));
            tableLayoutPanel4.Size = new Size(560, 96);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // _lblPres
            // 
            _lblPres.BackColor = Color.DarkGreen;
            _lblPres.Dock = DockStyle.Fill;
            _lblPres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblPres.ForeColor = Color.White;
            _lblPres.Location = new Point(186, 30);
            _lblPres.Margin = new Padding(0);
            _lblPres.Name = "_lblPres";
            _lblPres.Size = new Size(186, 66);
            _lblPres.TabIndex = 5;
            _lblPres.Text = "--";
            _lblPres.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblDist
            // 
            _lblDist.BackColor = Color.DarkGreen;
            _lblDist.Dock = DockStyle.Fill;
            _lblDist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblDist.ForeColor = Color.White;
            _lblDist.Location = new Point(0, 30);
            _lblDist.Margin = new Padding(0);
            _lblDist.Name = "_lblDist";
            _lblDist.Size = new Size(186, 66);
            _lblDist.TabIndex = 4;
            _lblDist.Text = "--";
            _lblDist.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(375, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 30);
            label5.TabIndex = 3;
            label5.Text = "DISTÂNCIA";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(189, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 2;
            label4.Text = "PRESSÃO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 1;
            label3.Text = "TEMPERATURA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblTemp
            // 
            _lblTemp.BackColor = Color.DarkGreen;
            _lblTemp.Dock = DockStyle.Fill;
            _lblTemp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblTemp.ForeColor = Color.White;
            _lblTemp.Location = new Point(372, 30);
            _lblTemp.Margin = new Padding(0);
            _lblTemp.Name = "_lblTemp";
            _lblTemp.Size = new Size(188, 66);
            _lblTemp.TabIndex = 0;
            _lblTemp.Text = "--";
            _lblTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.DarkGreen;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(3, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(560, 332);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "STATUS";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label6, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(lblPorta, 0, 1);
            tableLayoutPanel5.Controls.Add(lbltemperatura, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 435);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel5.Size = new Size(560, 94);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // lbltemperatura
            // 
            lbltemperatura.BackColor = SystemColors.Control;
            lbltemperatura.Dock = DockStyle.Fill;
            lbltemperatura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltemperatura.ForeColor = Color.Black;
            lbltemperatura.Location = new Point(280, 41);
            lbltemperatura.Margin = new Padding(0);
            lbltemperatura.Name = "lbltemperatura";
            lbltemperatura.Size = new Size(280, 53);
            lbltemperatura.TabIndex = 6;
            lbltemperatura.Text = "--";
            lbltemperatura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPorta
            // 
            lblPorta.BackColor = SystemColors.Control;
            lblPorta.Dock = DockStyle.Fill;
            lblPorta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorta.ForeColor = Color.Black;
            lblPorta.Location = new Point(0, 41);
            lblPorta.Margin = new Padding(0);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(280, 53);
            lblPorta.TabIndex = 5;
            lblPorta.Text = "--";
            lblPorta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(280, 41);
            label2.TabIndex = 7;
            label2.Text = "PORTA ABERTA HOJE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(280, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(280, 41);
            label6.TabIndex = 8;
            label6.Text = "TEMPERATURA EXCEDEU O LIMITE";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControleTemperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 536);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ControleTemperatura";
            Text = "CONTROLE DE TEMPERATURA AMBIENTE";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox _log;
        private ContextMenuStrip contextMenuStrip2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label _lblPres;
        private Label _lblDist;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label _lblTemp;
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lbltemperatura;
        private Label lblPorta;
        private Label label6;
        private Label label2;
    }
}