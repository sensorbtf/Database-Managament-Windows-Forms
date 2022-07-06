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
    public partial class InsertingWynajmujacy : Form
    {
        public InsertingWynajmujacy()
        {
            InitializeComponent();
        }

        private void AddZabLok_Click(object sender, EventArgs e)
        {
            var adresZab = int.Parse(IDAddressZabTextBox.Text);

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            Regex NullValidation = new Regex(@"(.|\s)*\S(.|\s)*");
            if (NullValidation.Match(IDAddressZabTextBox.Text).Success)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Zabudowania(AdresZabudowania) " + "VALUES('" + adresZab + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Zabudowanie dodane");
                    
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO WynajeteLokale(idZabudowania)" + "VALUES('" + adresZab + "')", con);
                    int i2 = cmd2.ExecuteNonQuery(); //???
                    if (i2 != 0)
                    {
                        MessageBox.Show("Wynajęty lokal dodany");
                        LokalZabudowanieLabel.Visible = true;
                        UmowyNajmuPanel.Enabled = true;
                    }
                    else
                        MessageBox.Show("Error");
                }
                else
                    MessageBox.Show("Error");
                
            }
            else
            {
                MessageBox.Show("Sprawdź podane dane - błąd");
            }
        }

        private void button2_Click(object sender, EventArgs e) // button dla umowynajmu
        {
            Regex numberValidation = new Regex(@"(.|\s)*\S(.|\s)*");//zmienic
            if (numberValidation.Match(CzynszTextBox.Text).Success && numberValidation.Match(KaucjaTextBox.Text).Success)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True"))
                {
                    String query = "INSERT INTO UmowyNajmu(idLokalu, CenaZaMiesiac, Kaucja, DataPodpisania) " +
                        "VALUES (@idLokalu, @CenaZaMiesiac, @Kaucja, @DataPodpisania)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idLokalu", GetMaxIdLokalu());
                        command.Parameters.AddWithValue("@CenaZaMiesiac", decimal.Parse(CzynszTextBox.Text));
                        command.Parameters.AddWithValue("@Kaucja", decimal.Parse(KaucjaTextBox .Text));
                        command.Parameters.AddWithValue("@DataPodpisania", DataZawarciaDate);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        MessageBox.Show("Umowa dodana");
                        UmowyNajmuPanel.Enabled = false;
                        WynajmujacyPanel.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sprawdź podane dane - błąd");
            }

            // idLokalu, CenaZaMiesiac, Kaucja, DataPodpisania, DataRezygnacji
            // idLokalu z automatu, data podpisania - dzis, a data rezygnacji = null
        }

        private void WynajmujacyButton_Click(object sender, EventArgs e)
        {
            //Regex NullValidation = new Regex(@"(.|\s)*\S(.|\s)*");
            //if (NullValidation.Match(ImieWłaścicielaTextBox.Text).Success && NullValidation.Match(NazwiskoWłaścicielaTextBox.Text).Success
            //    && NullValidation.Match(NumerTelefonuWłaścicielaTextBox.Text).Success)
            //{
            //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True"))
            //    {
            //        String query = "INSERT INTO Wlasciciele(idZabudowania, Imie, Nazwisko, NumerTelefonu, AdresWlasciciela) VALUES (@idZabudowania,@Imie,@Nazwisko, @NumerTelefonu, @idAdresuWlasciciela)";

            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@idZabudowania", GetMaxIdZabudowania());
            //            command.Parameters.AddWithValue("@Imie", ImieWłaścicielaTextBox.Text);
            //            command.Parameters.AddWithValue("@Nazwisko", NazwiskoWłaścicielaTextBox.Text);
            //            command.Parameters.AddWithValue("@NumerTelefonu", int.Parse(NumerTelefonuWłaścicielaTextBox.Text));
            //            command.Parameters.AddWithValue("@idAdresuWlasciciela", GetMaxIdAdresu());

            //            connection.Open();
            //            int result = command.ExecuteNonQuery();

            //            MessageBox.Show("Dodano właściciela");
            //        }
            //    }
            //}
            //else
            //    MessageBox.Show("Sprawdz dane");


            //// idUmowy, Imie, Nazwisko, NumerTelefonu, AdresWynajmujacego
            //// IdUmowy z automatu (metoda), adres tez z automatu
        }
        public int GetMaxIdAdresu()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand idAdresuQuery = new SqlCommand("SELECT max(idAdresu) FROM Adresy", con);

            int idAdresuMax = Convert.ToInt32(idAdresuQuery.ExecuteScalar());

            return idAdresuMax;
        }
        public int GetMaxIdUmowy()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand idUmowyQuery = new SqlCommand("SELECT max(idUmowy) FROM UmowyNajmu", con);

            int idUmowyMax= Convert.ToInt32(idUmowyQuery.ExecuteScalar());

            return idUmowyMax;
        }
        public int GetMaxIdLokalu()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2BSV6D;Initial Catalog=BazaSpoldzielniMieszkaniowej;Integrated Security=True");
            con.Open();

            SqlCommand idUmowyQuery = new SqlCommand("SELECT max(idLokalu) FROM WynajeteLokale", con);

            int idUmowyMax = Convert.ToInt32(idUmowyQuery.ExecuteScalar());

            return idUmowyMax;
        }
    }
}
