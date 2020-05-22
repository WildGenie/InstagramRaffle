namespace InstagramRaffle
{
  partial class RaffleForm
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.KazananlarText = new System.Windows.Forms.TextBox();
      this.YedeklerText = new System.Windows.Forms.TextBox();
      this.AyiklananText = new System.Windows.Forms.TextBox();
      this.AyiklanacakText = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.AyiklaVeSirala = new System.Windows.Forms.Button();
      this.Istatistik = new System.Windows.Forms.Button();
      this.Cekilis = new System.Windows.Forms.Button();
      this.Temizle = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.IstatistikText = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.Controls.Add(this.KazananlarText, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.YedeklerText, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.AyiklananText, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.AyiklanacakText, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.IstatistikText, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 729);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // KazananlarText
      // 
      this.KazananlarText.BackColor = System.Drawing.Color.GreenYellow;
      this.tableLayoutPanel1.SetColumnSpan(this.KazananlarText, 2);
      this.KazananlarText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.KazananlarText.Location = new System.Drawing.Point(4, 303);
      this.KazananlarText.Margin = new System.Windows.Forms.Padding(4);
      this.KazananlarText.Multiline = true;
      this.KazananlarText.Name = "KazananlarText";
      this.KazananlarText.ReadOnly = true;
      this.KazananlarText.Size = new System.Drawing.Size(792, 192);
      this.KazananlarText.TabIndex = 5;
      // 
      // YedeklerText
      // 
      this.YedeklerText.BackColor = System.Drawing.Color.LightCyan;
      this.tableLayoutPanel1.SetColumnSpan(this.YedeklerText, 2);
      this.YedeklerText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.YedeklerText.Location = new System.Drawing.Point(4, 533);
      this.YedeklerText.Margin = new System.Windows.Forms.Padding(4);
      this.YedeklerText.Multiline = true;
      this.YedeklerText.Name = "YedeklerText";
      this.YedeklerText.ReadOnly = true;
      this.YedeklerText.Size = new System.Drawing.Size(792, 192);
      this.YedeklerText.TabIndex = 2;
      // 
      // AyiklananText
      // 
      this.AyiklananText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AyiklananText.Location = new System.Drawing.Point(4, 138);
      this.AyiklananText.Margin = new System.Windows.Forms.Padding(4);
      this.AyiklananText.Multiline = true;
      this.AyiklananText.Name = "AyiklananText";
      this.AyiklananText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.AyiklananText.Size = new System.Drawing.Size(642, 126);
      this.AyiklananText.TabIndex = 1;
      // 
      // AyiklanacakText
      // 
      this.AyiklanacakText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AyiklanacakText.Location = new System.Drawing.Point(4, 4);
      this.AyiklanacakText.Margin = new System.Windows.Forms.Padding(4);
      this.AyiklanacakText.Multiline = true;
      this.AyiklanacakText.Name = "AyiklanacakText";
      this.AyiklanacakText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.AyiklanacakText.Size = new System.Drawing.Size(642, 126);
      this.AyiklanacakText.TabIndex = 0;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.AyiklaVeSirala);
      this.flowLayoutPanel2.Controls.Add(this.Istatistik);
      this.flowLayoutPanel2.Controls.Add(this.Cekilis);
      this.flowLayoutPanel2.Controls.Add(this.Temizle);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(654, 4);
      this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 126);
      this.flowLayoutPanel2.TabIndex = 4;
      // 
      // AyiklaVeSirala
      // 
      this.AyiklaVeSirala.Location = new System.Drawing.Point(4, 4);
      this.AyiklaVeSirala.Margin = new System.Windows.Forms.Padding(4);
      this.AyiklaVeSirala.Name = "AyiklaVeSirala";
      this.AyiklaVeSirala.Size = new System.Drawing.Size(138, 23);
      this.AyiklaVeSirala.TabIndex = 0;
      this.AyiklaVeSirala.Text = "Ayıkla ve Sırala";
      this.AyiklaVeSirala.UseVisualStyleBackColor = true;
      this.AyiklaVeSirala.Click += new System.EventHandler(this.AyiklaVeSiralaClick);
      // 
      // Istatistik
      // 
      this.Istatistik.Location = new System.Drawing.Point(4, 35);
      this.Istatistik.Margin = new System.Windows.Forms.Padding(4);
      this.Istatistik.Name = "Istatistik";
      this.Istatistik.Size = new System.Drawing.Size(138, 23);
      this.Istatistik.TabIndex = 6;
      this.Istatistik.Text = "İstatistik";
      this.Istatistik.UseVisualStyleBackColor = true;
      this.Istatistik.Click += new System.EventHandler(this.IstatistikClick);
      // 
      // Cekilis
      // 
      this.Cekilis.Location = new System.Drawing.Point(4, 66);
      this.Cekilis.Margin = new System.Windows.Forms.Padding(4);
      this.Cekilis.Name = "Cekilis";
      this.Cekilis.Size = new System.Drawing.Size(138, 23);
      this.Cekilis.TabIndex = 3;
      this.Cekilis.Text = "Çekiliş";
      this.Cekilis.UseVisualStyleBackColor = true;
      this.Cekilis.Click += new System.EventHandler(this.CekilisClick);
      // 
      // Temizle
      // 
      this.Temizle.Location = new System.Drawing.Point(4, 97);
      this.Temizle.Margin = new System.Windows.Forms.Padding(4);
      this.Temizle.Name = "Temizle";
      this.Temizle.Size = new System.Drawing.Size(138, 23);
      this.Temizle.TabIndex = 7;
      this.Temizle.Text = "Temizle";
      this.Temizle.UseVisualStyleBackColor = true;
      this.Temizle.Click += new System.EventHandler(this.TemizleClick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 499);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Yedekler";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 268);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Kazananlar";
      // 
      // IstatistikText
      // 
      this.IstatistikText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.IstatistikText.Location = new System.Drawing.Point(654, 138);
      this.IstatistikText.Margin = new System.Windows.Forms.Padding(4);
      this.IstatistikText.Multiline = true;
      this.IstatistikText.Name = "IstatistikText";
      this.IstatistikText.ReadOnly = true;
      this.IstatistikText.Size = new System.Drawing.Size(142, 126);
      this.IstatistikText.TabIndex = 0;
      // 
      // RaffleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(800, 729);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "RaffleForm";
      this.Text = "Gelecek Bilimde Instagram Çekilişi";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox AyiklananText;
    private System.Windows.Forms.TextBox AyiklanacakText;
    private System.Windows.Forms.Button AyiklaVeSirala;
    private System.Windows.Forms.Button Istatistik;
    private System.Windows.Forms.Button Cekilis;
    private System.Windows.Forms.TextBox IstatistikText;
    private System.Windows.Forms.TextBox YedeklerText;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.TextBox KazananlarText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Temizle;
  }
}

