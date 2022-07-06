namespace WinFormsApp1
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
            this.FunduszButtonSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OwnerRenterAddressHouse = new System.Windows.Forms.Button();
            this.SelectingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddFund = new System.Windows.Forms.Button();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.IDZabTextBox = new System.Windows.Forms.TextBox();
            this.IDZabudowania = new System.Windows.Forms.Label();
            this.FundBudget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunduszButtonSelection
            // 
            this.FunduszButtonSelection.Location = new System.Drawing.Point(151, 162);
            this.FunduszButtonSelection.Name = "FunduszButtonSelection";
            this.FunduszButtonSelection.Size = new System.Drawing.Size(75, 23);
            this.FunduszButtonSelection.TabIndex = 0;
            this.FunduszButtonSelection.Text = "Fundusz";
            this.FunduszButtonSelection.UseVisualStyleBackColor = true;
            this.FunduszButtonSelection.Click += new System.EventHandler(this.FunduszButtonSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baza danych spółdzielni mieszkaniowej. ";
            // 
            // OwnerRenterAddressHouse
            // 
            this.OwnerRenterAddressHouse.Location = new System.Drawing.Point(12, 127);
            this.OwnerRenterAddressHouse.Name = "OwnerRenterAddressHouse";
            this.OwnerRenterAddressHouse.Size = new System.Drawing.Size(117, 93);
            this.OwnerRenterAddressHouse.TabIndex = 2;
            this.OwnerRenterAddressHouse.Text = "Właściciela, wynajmującego, zabudowanie";
            this.OwnerRenterAddressHouse.UseVisualStyleBackColor = true;
            this.OwnerRenterAddressHouse.Click += new System.EventHandler(this.OwnerRenterAddressHouse_Click);
            // 
            // SelectingButton
            // 
            this.SelectingButton.Location = new System.Drawing.Point(12, 295);
            this.SelectingButton.Name = "SelectingButton";
            this.SelectingButton.Size = new System.Drawing.Size(102, 31);
            this.SelectingButton.TabIndex = 3;
            this.SelectingButton.Text = "Wynajmujący";
            this.SelectingButton.UseVisualStyleBackColor = true;
            this.SelectingButton.Click += new System.EventHandler(this.SelectingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Co chcesz dodać?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Przeglądaj dane";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddFund);
            this.panel1.Controls.Add(this.BudgetTextBox);
            this.panel1.Controls.Add(this.IDZabTextBox);
            this.panel1.Controls.Add(this.IDZabudowania);
            this.panel1.Controls.Add(this.FundBudget);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(271, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 109);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // AddFund
            // 
            this.AddFund.Location = new System.Drawing.Point(288, 78);
            this.AddFund.Name = "AddFund";
            this.AddFund.Size = new System.Drawing.Size(102, 31);
            this.AddFund.TabIndex = 7;
            this.AddFund.Text = "Dodaj fundusz";
            this.AddFund.UseVisualStyleBackColor = true;
            this.AddFund.Click += new System.EventHandler(this.AddFund_Click);
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(131, 75);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(100, 23);
            this.BudgetTextBox.TabIndex = 5;
            // 
            // IDZabTextBox
            // 
            this.IDZabTextBox.Location = new System.Drawing.Point(131, 37);
            this.IDZabTextBox.Name = "IDZabTextBox";
            this.IDZabTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDZabTextBox.TabIndex = 4;
            this.IDZabTextBox.TextChanged += new System.EventHandler(this.IDZabTextBox_TextChanged);
            // 
            // IDZabudowania
            // 
            this.IDZabudowania.AutoSize = true;
            this.IDZabudowania.Location = new System.Drawing.Point(14, 43);
            this.IDZabudowania.Name = "IDZabudowania";
            this.IDZabudowania.Size = new System.Drawing.Size(94, 15);
            this.IDZabudowania.TabIndex = 3;
            this.IDZabudowania.Text = "ID zabudowania:";
            // 
            // FundBudget
            // 
            this.FundBudget.AutoSize = true;
            this.FundBudget.Location = new System.Drawing.Point(14, 78);
            this.FundBudget.Name = "FundBudget";
            this.FundBudget.Size = new System.Drawing.Size(98, 15);
            this.FundBudget.TabIndex = 1;
            this.FundBudget.Text = "Budżet funduszu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wskaż id zabudowania oraz początkowy budżet funduszu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectingButton);
            this.Controls.Add(this.OwnerRenterAddressHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunduszButtonSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FunduszButtonSelection;
        private Label label1;
        private Button OwnerRenterAddressHouse;
        private Button SelectingButton;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox BudgetTextBox;
        private TextBox IDZabTextBox;
        private Label IDZabudowania;
        private Label FundBudget;
        private Label label4;
        private Button AddFund;
    }
}