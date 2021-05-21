
namespace VIDGACSharpForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonAnalysis = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(335, 22);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(309, 140);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Admin Ekle";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.Location = new System.Drawing.Point(12, 22);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(309, 140);
            this.buttonSubject.TabIndex = 1;
            this.buttonSubject.Text = "Denek Ekle";
            this.buttonSubject.UseVisualStyleBackColor = true;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.Location = new System.Drawing.Point(658, 22);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(309, 140);
            this.buttonAnalysis.TabIndex = 3;
            this.buttonAnalysis.Text = "Analiz Gör";
            this.buttonAnalysis.UseVisualStyleBackColor = true;
            this.buttonAnalysis.Click += new System.EventHandler(this.buttonAnalysis_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.Location = new System.Drawing.Point(335, 168);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(309, 140);
            this.buttonCredits.TabIndex = 7;
            this.buttonCredits.Text = "Emeği Geçenler";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoEllipsis = true;
            this.buttonExit.Location = new System.Drawing.Point(658, 168);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(309, 140);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Çıkış Yap";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRecord.BackgroundImage")));
            this.buttonRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRecord.Location = new System.Drawing.Point(12, 168);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(309, 140);
            this.buttonRecord.TabIndex = 4;
            this.buttonRecord.Text = "Kayıt Başlat";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonAnalysis);
            this.Controls.Add(this.buttonSubject);
            this.Controls.Add(this.buttonAdmin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VİDGA Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRecord;
    }
}