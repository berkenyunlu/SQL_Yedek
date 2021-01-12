
namespace SQL_Yedek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(11, 25);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(119, 20);
            this.txtSunucu.TabIndex = 0;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(136, 25);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(119, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(261, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(119, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(386, 25);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(119, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yedek Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sunucu Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 106);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtSunucu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL YEDEK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

