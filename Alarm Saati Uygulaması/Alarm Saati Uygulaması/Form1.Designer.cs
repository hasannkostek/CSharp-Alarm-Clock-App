namespace Alarm_Saati_Uygulaması
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
            this.components = new System.ComponentModel.Container();
            this.labelZaman = new System.Windows.Forms.Label();
            this.numericUpDownSaat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDakika = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaniye = new System.Windows.Forms.NumericUpDown();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelZaman.Location = new System.Drawing.Point(179, 25);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(355, 91);
            this.labelZaman.TabIndex = 0;
            this.labelZaman.Text = "00:00:00";
            // 
            // numericUpDownSaat
            // 
            this.numericUpDownSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSaat.Location = new System.Drawing.Point(211, 150);
            this.numericUpDownSaat.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSaat.Name = "numericUpDownSaat";
            this.numericUpDownSaat.Size = new System.Drawing.Size(59, 49);
            this.numericUpDownSaat.TabIndex = 1;
            // 
            // numericUpDownDakika
            // 
            this.numericUpDownDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownDakika.Location = new System.Drawing.Point(322, 150);
            this.numericUpDownDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDakika.Name = "numericUpDownDakika";
            this.numericUpDownDakika.Size = new System.Drawing.Size(59, 49);
            this.numericUpDownDakika.TabIndex = 2;
            // 
            // numericUpDownSaniye
            // 
            this.numericUpDownSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSaniye.Location = new System.Drawing.Point(437, 150);
            this.numericUpDownSaniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSaniye.Name = "numericUpDownSaniye";
            this.numericUpDownSaniye.Size = new System.Drawing.Size(59, 49);
            this.numericUpDownSaniye.TabIndex = 3;
            // 
            // buttonBasla
            // 
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(211, 229);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(127, 48);
            this.buttonBasla.TabIndex = 4;
            this.buttonBasla.Text = "Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDurdur.Location = new System.Drawing.Point(369, 229);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(127, 48);
            this.buttonDurdur.TabIndex = 5;
            this.buttonDurdur.Text = "Durdur";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            this.buttonDurdur.Click += new System.EventHandler(this.buttonDurdur_Click);
            // 
            // timerZaman
            // 
            this.timerZaman.Interval = 1000;
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDurdur);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.numericUpDownSaniye);
            this.Controls.Add(this.numericUpDownDakika);
            this.Controls.Add(this.numericUpDownSaat);
            this.Controls.Add(this.labelZaman);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.NumericUpDown numericUpDownSaat;
        private System.Windows.Forms.NumericUpDown numericUpDownDakika;
        private System.Windows.Forms.NumericUpDown numericUpDownSaniye;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonDurdur;
        private System.Windows.Forms.Timer timerZaman;
    }
}

