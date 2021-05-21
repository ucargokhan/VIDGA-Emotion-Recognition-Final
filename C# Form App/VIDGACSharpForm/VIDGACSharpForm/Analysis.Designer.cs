
namespace VIDGACSharpForm
{
    partial class Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            this.dgSes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgGoruntu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recordStartTextBox = new System.Windows.Forms.TextBox();
            this.recordFinishedTextBox = new System.Windows.Forms.TextBox();
            this.pbAngry = new System.Windows.Forms.ProgressBar();
            this.pbDisgust = new System.Windows.Forms.ProgressBar();
            this.pbFearful = new System.Windows.Forms.ProgressBar();
            this.pbHappy = new System.Windows.Forms.ProgressBar();
            this.pbSad = new System.Windows.Forms.ProgressBar();
            this.pbSuprised = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pbNeutral = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSes
            // 
            this.dgSes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgSes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSes.Location = new System.Drawing.Point(17, 309);
            this.dgSes.Name = "dgSes";
            this.dgSes.ReadOnly = true;
            this.dgSes.Size = new System.Drawing.Size(955, 303);
            this.dgSes.TabIndex = 2;
            this.dgSes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSes_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ses Analizi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Görüntü Analizi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgGoruntu
            // 
            this.dgGoruntu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgGoruntu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGoruntu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGoruntu.Location = new System.Drawing.Point(17, 671);
            this.dgGoruntu.Name = "dgGoruntu";
            this.dgGoruntu.ReadOnly = true;
            this.dgGoruntu.Size = new System.Drawing.Size(955, 303);
            this.dgGoruntu.TabIndex = 5;
            this.dgGoruntu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGoruntu_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1762, 993);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seans Başlangıç Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seans Bitiş Saati:";
            // 
            // recordStartTextBox
            // 
            this.recordStartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordStartTextBox.Location = new System.Drawing.Point(254, 117);
            this.recordStartTextBox.Name = "recordStartTextBox";
            this.recordStartTextBox.ReadOnly = true;
            this.recordStartTextBox.Size = new System.Drawing.Size(268, 29);
            this.recordStartTextBox.TabIndex = 8;
            this.recordStartTextBox.TextChanged += new System.EventHandler(this.recordStartTextBox_TextChanged);
            // 
            // recordFinishedTextBox
            // 
            this.recordFinishedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordFinishedTextBox.Location = new System.Drawing.Point(254, 189);
            this.recordFinishedTextBox.Name = "recordFinishedTextBox";
            this.recordFinishedTextBox.ReadOnly = true;
            this.recordFinishedTextBox.Size = new System.Drawing.Size(268, 29);
            this.recordFinishedTextBox.TabIndex = 9;
            // 
            // pbAngry
            // 
            this.pbAngry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAngry.Location = new System.Drawing.Point(1285, 282);
            this.pbAngry.Name = "pbAngry";
            this.pbAngry.Size = new System.Drawing.Size(156, 23);
            this.pbAngry.TabIndex = 10;
            // 
            // pbDisgust
            // 
            this.pbDisgust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDisgust.Location = new System.Drawing.Point(1285, 338);
            this.pbDisgust.Name = "pbDisgust";
            this.pbDisgust.Size = new System.Drawing.Size(156, 23);
            this.pbDisgust.TabIndex = 11;
            // 
            // pbFearful
            // 
            this.pbFearful.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFearful.Location = new System.Drawing.Point(1285, 397);
            this.pbFearful.Name = "pbFearful";
            this.pbFearful.Size = new System.Drawing.Size(156, 23);
            this.pbFearful.TabIndex = 12;
            // 
            // pbHappy
            // 
            this.pbHappy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHappy.Location = new System.Drawing.Point(1285, 458);
            this.pbHappy.Name = "pbHappy";
            this.pbHappy.Size = new System.Drawing.Size(156, 23);
            this.pbHappy.TabIndex = 13;
            // 
            // pbSad
            // 
            this.pbSad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSad.Location = new System.Drawing.Point(1285, 516);
            this.pbSad.Name = "pbSad";
            this.pbSad.Size = new System.Drawing.Size(156, 23);
            this.pbSad.TabIndex = 14;
            // 
            // pbSuprised
            // 
            this.pbSuprised.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSuprised.Location = new System.Drawing.Point(1285, 575);
            this.pbSuprised.Name = "pbSuprised";
            this.pbSuprised.Size = new System.Drawing.Size(156, 23);
            this.pbSuprised.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1109, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kızgın";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pbNeutral
            // 
            this.pbNeutral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNeutral.Location = new System.Drawing.Point(1285, 632);
            this.pbNeutral.Name = "pbNeutral";
            this.pbNeutral.Size = new System.Drawing.Size(156, 23);
            this.pbNeutral.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1109, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "İğrenmiş";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1109, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Korkmuş";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1109, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mutlu";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1109, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Üzgün";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1109, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Şaşkın";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1109, 631);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nötr";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1495, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 373);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1491, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Seans Kayıt Cihazları: Kamera ve Mikrofon";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(800, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(329, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "13.05 2021 Tarihli 1. Seans Analizi";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1109, 777);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(656, 72);
            this.label14.TabIndex = 27;
            this.label14.Text = "UYARI: Burada gösterilen analizler %100 doğruluk değeri vaat etmez. \r\nAlanlarında" +
    " uzman çalışanlara duygusal içgörü anlamında destekte \r\nbulunma amacıyla oluştur" +
    "lmuştur.";
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbNeutral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbSuprised);
            this.Controls.Add(this.pbSad);
            this.Controls.Add(this.pbHappy);
            this.Controls.Add(this.pbFearful);
            this.Controls.Add(this.pbDisgust);
            this.Controls.Add(this.pbAngry);
            this.Controls.Add(this.recordFinishedTextBox);
            this.Controls.Add(this.recordStartTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgGoruntu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSes);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analiz Görüntüle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgSes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgGoruntu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recordStartTextBox;
        private System.Windows.Forms.TextBox recordFinishedTextBox;
        private System.Windows.Forms.ProgressBar pbAngry;
        private System.Windows.Forms.ProgressBar pbDisgust;
        private System.Windows.Forms.ProgressBar pbFearful;
        private System.Windows.Forms.ProgressBar pbHappy;
        private System.Windows.Forms.ProgressBar pbSad;
        private System.Windows.Forms.ProgressBar pbSuprised;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbNeutral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}