
namespace SeçimUygulama
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
            this.ilcelbl = new System.Windows.Forms.Label();
            this.akplbl = new System.Windows.Forms.Label();
            this.chplbl = new System.Windows.Forms.Label();
            this.mhplbl = new System.Windows.Forms.Label();
            this.iplbl = new System.Windows.Forms.Label();
            this.zplbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.oygir = new System.Windows.Forms.Button();
            this.grafik = new System.Windows.Forms.Button();
            this.cik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ilcelbl
            // 
            this.ilcelbl.AutoSize = true;
            this.ilcelbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilcelbl.Location = new System.Drawing.Point(97, 68);
            this.ilcelbl.Name = "ilcelbl";
            this.ilcelbl.Size = new System.Drawing.Size(105, 29);
            this.ilcelbl.TabIndex = 0;
            this.ilcelbl.Text = "İlçe Ad :";
            // 
            // akplbl
            // 
            this.akplbl.AutoSize = true;
            this.akplbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akplbl.Location = new System.Drawing.Point(97, 108);
            this.akplbl.Name = "akplbl";
            this.akplbl.Size = new System.Drawing.Size(58, 29);
            this.akplbl.TabIndex = 1;
            this.akplbl.Text = "Akp";
            // 
            // chplbl
            // 
            this.chplbl.AutoSize = true;
            this.chplbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chplbl.Location = new System.Drawing.Point(97, 154);
            this.chplbl.Name = "chplbl";
            this.chplbl.Size = new System.Drawing.Size(60, 29);
            this.chplbl.TabIndex = 2;
            this.chplbl.Text = "Chp";
            // 
            // mhplbl
            // 
            this.mhplbl.AutoSize = true;
            this.mhplbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mhplbl.Location = new System.Drawing.Point(97, 193);
            this.mhplbl.Name = "mhplbl";
            this.mhplbl.Size = new System.Drawing.Size(64, 29);
            this.mhplbl.TabIndex = 3;
            this.mhplbl.Text = "Mhp";
            // 
            // iplbl
            // 
            this.iplbl.AutoSize = true;
            this.iplbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iplbl.Location = new System.Drawing.Point(97, 232);
            this.iplbl.Name = "iplbl";
            this.iplbl.Size = new System.Drawing.Size(100, 29);
            this.iplbl.TabIndex = 4;
            this.iplbl.Text = "İyi Parti";
            // 
            // zplbl
            // 
            this.zplbl.AutoSize = true;
            this.zplbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zplbl.Location = new System.Drawing.Point(97, 274);
            this.zplbl.Name = "zplbl";
            this.zplbl.Size = new System.Drawing.Size(150, 29);
            this.zplbl.TabIndex = 5;
            this.zplbl.Text = "Zafer Partisi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(270, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(270, 238);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(270, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(195, 22);
            this.textBox6.TabIndex = 11;
            // 
            // oygir
            // 
            this.oygir.BackColor = System.Drawing.Color.LimeGreen;
            this.oygir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oygir.Location = new System.Drawing.Point(270, 319);
            this.oygir.Name = "oygir";
            this.oygir.Size = new System.Drawing.Size(195, 57);
            this.oygir.TabIndex = 12;
            this.oygir.Text = "Oy Girişi Yap";
            this.oygir.UseVisualStyleBackColor = false;
            this.oygir.Click += new System.EventHandler(this.oygir_Click);
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafik.Location = new System.Drawing.Point(270, 394);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(124, 69);
            this.grafik.TabIndex = 13;
            this.grafik.Text = "Grafikler";
            this.grafik.UseVisualStyleBackColor = false;
            this.grafik.Click += new System.EventHandler(this.grafik_Click);
            // 
            // cik
            // 
            this.cik.BackColor = System.Drawing.Color.Crimson;
            this.cik.Location = new System.Drawing.Point(410, 394);
            this.cik.Name = "cik";
            this.cik.Size = new System.Drawing.Size(94, 69);
            this.cik.TabIndex = 14;
            this.cik.Text = "Çıkış";
            this.cik.UseVisualStyleBackColor = false;
            this.cik.Click += new System.EventHandler(this.cik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 533);
            this.Controls.Add(this.cik);
            this.Controls.Add(this.grafik);
            this.Controls.Add(this.oygir);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zplbl);
            this.Controls.Add(this.iplbl);
            this.Controls.Add(this.mhplbl);
            this.Controls.Add(this.chplbl);
            this.Controls.Add(this.akplbl);
            this.Controls.Add(this.ilcelbl);
            this.Name = "Form1";
            this.Text = "Seçim Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilcelbl;
        private System.Windows.Forms.Label akplbl;
        private System.Windows.Forms.Label chplbl;
        private System.Windows.Forms.Label mhplbl;
        private System.Windows.Forms.Label iplbl;
        private System.Windows.Forms.Label zplbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button oygir;
        private System.Windows.Forms.Button grafik;
        private System.Windows.Forms.Button cik;
    }
}

