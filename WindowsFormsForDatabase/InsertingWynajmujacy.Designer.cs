namespace WinFormsApp1
{
    partial class InsertingWynajmujacy
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
            this.label1 = new System.Windows.Forms.Label();
            this.ZabudowaniaPanel = new System.Windows.Forms.Panel();
            this.LokalZabudowanieLabel = new System.Windows.Forms.Label();
            this.AddZabLok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDAddressZabTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UmowyNajmuPanel = new System.Windows.Forms.Panel();
            this.UmowaNajmuButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WynajmujacyPanel = new System.Windows.Forms.Panel();
            this.WynajmujacyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CzynszTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KaucjaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataZawarciaDate = new System.Windows.Forms.DateTimePicker();
            this.ZabudowaniaPanel.SuspendLayout();
            this.UmowyNajmuPanel.SuspendLayout();
            this.WynajmujacyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aby dodać wynajmującego, należy określić zabudowanie, lokal oraz szczegóły umowy";
            // 
            // ZabudowaniaPanel
            // 
            this.ZabudowaniaPanel.Controls.Add(this.LokalZabudowanieLabel);
            this.ZabudowaniaPanel.Controls.Add(this.AddZabLok);
            this.ZabudowaniaPanel.Controls.Add(this.label2);
            this.ZabudowaniaPanel.Controls.Add(this.IDAddressZabTextBox);
            this.ZabudowaniaPanel.Controls.Add(this.label3);
            this.ZabudowaniaPanel.Location = new System.Drawing.Point(16, 49);
            this.ZabudowaniaPanel.Name = "ZabudowaniaPanel";
            this.ZabudowaniaPanel.Size = new System.Drawing.Size(318, 201);
            this.ZabudowaniaPanel.TabIndex = 5;
            // 
            // LokalZabudowanieLabel
            // 
            this.LokalZabudowanieLabel.AutoSize = true;
            this.LokalZabudowanieLabel.Location = new System.Drawing.Point(3, 100);
            this.LokalZabudowanieLabel.Name = "LokalZabudowanieLabel";
            this.LokalZabudowanieLabel.Size = new System.Drawing.Size(306, 15);
            this.LokalZabudowanieLabel.TabIndex = 9;
            this.LokalZabudowanieLabel.Text = "Dodano zabudowanie i uzupełniono automatycznie lokal";
            this.LokalZabudowanieLabel.Visible = false;
            // 
            // AddZabLok
            // 
            this.AddZabLok.Location = new System.Drawing.Point(213, 53);
            this.AddZabLok.Name = "AddZabLok";
            this.AddZabLok.Size = new System.Drawing.Size(75, 23);
            this.AddZabLok.TabIndex = 8;
            this.AddZabLok.Text = "Dodaj";
            this.AddZabLok.UseVisualStyleBackColor = true;
            this.AddZabLok.Click += new System.EventHandler(this.AddZabLok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zabudowanie i wynajęte lokale";
            // 
            // IDAddressZabTextBox
            // 
            this.IDAddressZabTextBox.Location = new System.Drawing.Point(84, 50);
            this.IDAddressZabTextBox.Name = "IDAddressZabTextBox";
            this.IDAddressZabTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDAddressZabTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID adresu:";
            // 
            // UmowyNajmuPanel
            // 
            this.UmowyNajmuPanel.Controls.Add(this.DataZawarciaDate);
            this.UmowyNajmuPanel.Controls.Add(this.label7);
            this.UmowyNajmuPanel.Controls.Add(this.KaucjaTextBox);
            this.UmowyNajmuPanel.Controls.Add(this.label10);
            this.UmowyNajmuPanel.Controls.Add(this.CzynszTextBox);
            this.UmowyNajmuPanel.Controls.Add(this.label6);
            this.UmowyNajmuPanel.Controls.Add(this.UmowaNajmuButton);
            this.UmowyNajmuPanel.Controls.Add(this.label4);
            this.UmowyNajmuPanel.Enabled = false;
            this.UmowyNajmuPanel.Location = new System.Drawing.Point(458, 49);
            this.UmowyNajmuPanel.Name = "UmowyNajmuPanel";
            this.UmowyNajmuPanel.Size = new System.Drawing.Size(318, 201);
            this.UmowyNajmuPanel.TabIndex = 9;
            // 
            // UmowaNajmuButton
            // 
            this.UmowaNajmuButton.Location = new System.Drawing.Point(149, 172);
            this.UmowaNajmuButton.Name = "UmowaNajmuButton";
            this.UmowaNajmuButton.Size = new System.Drawing.Size(169, 26);
            this.UmowaNajmuButton.TabIndex = 8;
            this.UmowaNajmuButton.Text = "Dodaj nową umowę najmu";
            this.UmowaNajmuButton.UseVisualStyleBackColor = true;
            this.UmowaNajmuButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Umowy najmu";
            // 
            // WynajmujacyPanel
            // 
            this.WynajmujacyPanel.Controls.Add(this.textBox1);
            this.WynajmujacyPanel.Controls.Add(this.label5);
            this.WynajmujacyPanel.Controls.Add(this.WynajmujacyButton);
            this.WynajmujacyPanel.Controls.Add(this.label8);
            this.WynajmujacyPanel.Controls.Add(this.textBox4);
            this.WynajmujacyPanel.Controls.Add(this.label9);
            this.WynajmujacyPanel.Enabled = false;
            this.WynajmujacyPanel.Location = new System.Drawing.Point(458, 256);
            this.WynajmujacyPanel.Name = "WynajmujacyPanel";
            this.WynajmujacyPanel.Size = new System.Drawing.Size(312, 189);
            this.WynajmujacyPanel.TabIndex = 10;
            // 
            // WynajmujacyButton
            // 
            this.WynajmujacyButton.Location = new System.Drawing.Point(237, 163);
            this.WynajmujacyButton.Name = "WynajmujacyButton";
            this.WynajmujacyButton.Size = new System.Drawing.Size(75, 23);
            this.WynajmujacyButton.TabIndex = 8;
            this.WynajmujacyButton.Text = "Dodaj nowego wynajmująceego";
            this.WynajmujacyButton.UseVisualStyleBackColor = true;
            this.WynajmujacyButton.Click += new System.EventHandler(this.WynajmujacyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Wynajmujący";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Zabudowanie:";
            // 
            // CzynszTextBox
            // 
            this.CzynszTextBox.Location = new System.Drawing.Point(128, 50);
            this.CzynszTextBox.Name = "CzynszTextBox";
            this.CzynszTextBox.Size = new System.Drawing.Size(100, 23);
            this.CzynszTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Miesięczny czynsz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data zawarcia";
            // 
            // KaucjaTextBox
            // 
            this.KaucjaTextBox.Location = new System.Drawing.Point(128, 79);
            this.KaucjaTextBox.Name = "KaucjaTextBox";
            this.KaucjaTextBox.Size = new System.Drawing.Size(100, 23);
            this.KaucjaTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kaucja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zabudowanie:";
            // 
            // DataZawarciaDate
            // 
            this.DataZawarciaDate.Location = new System.Drawing.Point(88, 111);
            this.DataZawarciaDate.Name = "DataZawarciaDate";
            this.DataZawarciaDate.Size = new System.Drawing.Size(200, 23);
            this.DataZawarciaDate.TabIndex = 11;
            this.DataZawarciaDate.Value = new System.DateTime(2022, 6, 11, 12, 53, 51, 0);
            // 
            // InsertingWynajmujacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WynajmujacyPanel);
            this.Controls.Add(this.UmowyNajmuPanel);
            this.Controls.Add(this.ZabudowaniaPanel);
            this.Controls.Add(this.label1);
            this.Name = "InsertingWynajmujacy";
            this.Text = "Form1";
            this.ZabudowaniaPanel.ResumeLayout(false);
            this.ZabudowaniaPanel.PerformLayout();
            this.UmowyNajmuPanel.ResumeLayout(false);
            this.UmowyNajmuPanel.PerformLayout();
            this.WynajmujacyPanel.ResumeLayout(false);
            this.WynajmujacyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel ZabudowaniaPanel;
        private Button AddZabLok;
        private Label label2;
        private TextBox IDAddressZabTextBox;
        private Label label3;
        private Panel UmowyNajmuPanel;
        private Button UmowaNajmuButton;
        private Label label4;
        private Panel WynajmujacyPanel;
        private Button WynajmujacyButton;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private Label LokalZabudowanieLabel;
        private Label label7;
        private TextBox KaucjaTextBox;
        private Label label10;
        private TextBox CzynszTextBox;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private DateTimePicker DataZawarciaDate;
    }
}