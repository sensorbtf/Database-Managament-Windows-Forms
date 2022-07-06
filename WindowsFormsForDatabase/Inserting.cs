using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WinFormsApp1

{
    public partial class Adresy : Form
    {
        public Adresy()
        {
            InitializeComponent();
        }

        private void DodajAdressButton_Click(object sender, EventArgs e)// dodawanie adresu
        {
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
                con.Open();
                Regex postCodeValidation = new Regex(@"\d{2}-\d{3}");
                Regex NullValidation = new Regex(@"(.|\s)*\S(.|\s)*");
                if (postCodeValidation.Match(KodPocztowy.Text).Success && NullValidation.Match(Miasto.Text).Success && NullValidation.Match(Ulica.Text).Success && NullValidation.Match(NrBudynku.Text).Success)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Adresy(Miasto, Ulica, KodPocztowy, NumerBudynku) " +
                               "VALUES('" + Miasto.Text + "','" + Ulica.Text + "','" + KodPocztowy.Text + "','" + NrBudynku.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Adres dodany");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    OwnerButton.Visible = true;
                    ZabudowanieButton.Visible = true;
                    WynajmujacyButton.Visible = true;
                    ChoiceOfAdding.Visible = true;
                    W≥aúcicielPanel.Visible = false;
                    DodajNowyAdresPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sprawdü podane dane - b≥πd");
                }
            }
        }

        private void ZabudowanieButton_Click(object sender, EventArgs e)
        {
            OwnerButton.Visible = false;
            ZabudowanieButton.Visible = false;
            WynajmujacyButton.Visible = false;
            ChoiceOfAdding.Visible = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Zabudowania(AdresZabudowania) " + "SELECT max(idAdresu) FROM Adresy", con);
            var i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Zabudowanie dodane");

                OwnerButton.Visible = false;
                ZabudowanieButton.Visible = false;
                WynajmujacyButton.Visible = false;
                ChoiceOfAdding.Visible = false;
                W≥aúcicielPanel.Visible = true;
            }
            else
                MessageBox.Show("Error in Zabudowania");

        }
        private void OwnerButtonAdding_Click_1(object sender, EventArgs e)
        {
            Regex NullValidation = new Regex(@"(.|\s)*\S(.|\s)*");
            if (NullValidation.Match(ImieW≥aúcicielaTextBox.Text).Success && NullValidation.Match(NazwiskoW≥aúcicielaTextBox.Text).Success 
                && NullValidation.Match(NumerTelefonuW≥aúcicielaTextBox.Text).Success)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True"))
                {
                    String query = "INSERT INTO Wlasciciele(idZabudowania, Imie, Nazwisko, NumerTelefonu, AdresWlasciciela) VALUES (@idZabudowania,@Imie,@Nazwisko, @NumerTelefonu, @idAdresuWlasciciela)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idZabudowania", GetMaxIdZabudowania());
                        command.Parameters.AddWithValue("@Imie", ImieW≥aúcicielaTextBox.Text);
                        command.Parameters.AddWithValue("@Nazwisko", NazwiskoW≥aúcicielaTextBox.Text);
                        command.Parameters.AddWithValue("@NumerTelefonu", int.Parse(NumerTelefonuW≥aúcicielaTextBox.Text));
                        command.Parameters.AddWithValue("@idAdresuWlasciciela", GetMaxIdAdresu());

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        MessageBox.Show("Dodano w≥aúciciela");
                    }
                }
            }
            else
                MessageBox.Show("Sprawdz dane");
        }
        private void WynajmujacyButton_Click(object sender, EventArgs e)
        {
            InsertingWynajmujacy FormForRenter = new InsertingWynajmujacy();
            FormForRenter.Show();
        }
        public int GetMaxIdAdresu()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand idAdresuQuery = new SqlCommand("SELECT max(idAdresu) FROM Adresy", con);

            int idAdresuMax = Convert.ToInt32(idAdresuQuery.ExecuteScalar());

            return idAdresuMax;
        }
        public int GetMaxIdZabudowania()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand idZabQuery = new SqlCommand("SELECT max(idZabudowania) FROM Zabudowania", con);

            int idZabMax = Convert.ToInt32(idZabQuery.ExecuteScalar());

            return idZabMax;
        }

        private void OwnerButton_Click(object sender, EventArgs e)
        {
            OwnerButton.Visible = false;
            ZabudowanieButton.Visible = false;
            WynajmujacyButton.Visible = false;
            ChoiceOfAdding.Visible = false;
            WlascicielPanel2.Visible = true;
 
        }

        private void AddOwner2_Click(object sender, EventArgs e)
        {
            Regex NullValidation = new Regex(@"(.|\s)*\S(.|\s)*");
            if (NullValidation.Match(ImieWlasciciela2.Text).Success && NullValidation.Match(NazwiskoWlasciciela2.Text).Success && NullValidation.Match(NumerTelefonuWlasciciela2.Text).Success)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True"))
                {
                    String query = "INSERT INTO Wlasciciele(idZabudowania, Imie, Nazwisko, NumerTelefonu, AdresWlasciciela) VALUES (@idZabudowania,@Imie,@Nazwisko, @NumerTelefonu, @idAdresuWlasciciela)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idZabudowania", int.Parse(IDZabudowaniaWlasciciel2.Text));
                        command.Parameters.AddWithValue("@Imie", ImieWlasciciela2.Text);
                        command.Parameters.AddWithValue("@Nazwisko", NazwiskoWlasciciela2.Text);
                        command.Parameters.AddWithValue("@NumerTelefonu", int.Parse(NumerTelefonuWlasciciela2.Text));
                        command.Parameters.AddWithValue("@idAdresuWlasciciela", int.Parse(IDAdresuWlasciciela2.Text));

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Dodano w≥aúciciela");
                    }
                }
            }
            else
                MessageBox.Show("Sprawdz dane");
        }
    }
}