using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OwnerRenterAddressHouse_Click(object sender, EventArgs e)
        {
            Adresy MainForm = new Adresy();
            MainForm.Show();
        }

        private void FunduszButtonSelection_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void AddFund_Click(object sender, EventArgs e)
        {
            Regex NumberValidation = new Regex(@"^[0-9]+$");
            if (NumberValidation.Match(IDZabTextBox.Text).Success && NumberValidation.Match(IDZabTextBox.Text).Success)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True"))
                {
                    String query = "INSERT INTO Fundusze(idZabudowania, Budzet) VALUES (@idZabudowania, @Budzet)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idZabudowania", int.Parse(IDZabTextBox.Text));
                        command.Parameters.AddWithValue("@Budzet", decimal.Parse(BudgetTextBox.Text));

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        MessageBox.Show("Dodano fundusz");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sprawdz dane");
            }
            
        }

        private void SelectingButton_Click(object sender, EventArgs e)
        {
            InsertingWynajmujacy FormForRenter = new InsertingWynajmujacy();
            FormForRenter.Show();
        }

        private void IDZabTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
