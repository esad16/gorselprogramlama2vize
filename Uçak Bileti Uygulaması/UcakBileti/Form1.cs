using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UcakBileti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ucakbileti;Integrated Security=True");
        int renk, butons, abilet;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox3.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox4.Items.Add(i);
            }
            comboBox5.Items.Add(DateTime.Now.Year);
            for (int i = 0; i < 10; i++)
            {
                comboBox7.Items.Add("0" + i);
            }
            for (int i = 10; i < 24; i++)
            {
                comboBox7.Items.Add(i);
            }
            comboBox8.Items.Add("00");
            comboBox8.Items.Add("15");
            comboBox8.Items.Add("30");
            comboBox8.Items.Add("45");
            comboBox6.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            listele();


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT * FROM dolukoltuk";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    butons = int.Parse(dr[0].ToString());
                    butonsvk();
                }
                baglanti.Close();
            }
            bf();
        }

        void bt()
        {
            button63.Enabled = true;
            button62.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button45.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button53.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;

        }

        void bf()
        {
            button63.Enabled = false;
            button62.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;
            button48.Enabled = false;
            button49.Enabled = false;
            button50.Enabled = false;
            button51.Enabled = false;
            button52.Enabled = false;
            button53.Enabled = false;
            button54.Enabled = false;
            button55.Enabled = false;
            button56.Enabled = false;
            button57.Enabled = false;
            button58.Enabled = false;
            button59.Enabled = false;
            button60.Enabled = false;

        }

        void butonsvy()
        {
            if (butons == 1)
            {
                button63.BackColor = Color.Lime;
            }
            else if (butons == 2)
            {
                button62.BackColor = Color.Lime;
            }
            else if (butons == 3)
            {
                button3.BackColor = Color.Lime;
            }
            else if (butons == 4)
            {
                button4.BackColor = Color.Lime;
            }
            else if (butons == 5)
            {
                button5.BackColor = Color.Lime;
            }
            else if (butons == 6)
            {
                button6.BackColor = Color.Lime;
            }
            else if (butons == 7)
            {
                button7.BackColor = Color.Lime;
            }
            else if (butons == 8)
            {
                button8.BackColor = Color.Lime;
            }
            else if (butons == 9)
            {
                button9.BackColor = Color.Lime;
            }
            else if (butons == 10)
            {
                button10.BackColor = Color.Lime;
            }
            else if (butons == 11)
            {
                button11.BackColor = Color.Lime;
            }
            else if (butons == 12)
            {
                button12.BackColor = Color.Lime;
            }
            else if (butons == 13)
            {
                button13.BackColor = Color.Lime;
            }
            else if (butons == 14)
            {
                button14.BackColor = Color.Lime;
            }
            else if (butons == 15)
            {
                button15.BackColor = Color.Lime;
            }
            else if (butons == 16)
            {
                button16.BackColor = Color.Lime;
            }
            else if (butons == 17)
            {
                button17.BackColor = Color.Lime;
            }
            else if (butons == 18)
            {
                button18.BackColor = Color.Lime;
            }
            else if (butons == 19)
            {
                button19.BackColor = Color.Lime;
            }
            else if (butons == 20)
            {
                button20.BackColor = Color.Lime;
            }
            else if (butons == 21)
            {
                button21.BackColor = Color.Lime;
            }
            else if (butons == 22)
            {
                button22.BackColor = Color.Lime;
            }
            else if (butons == 23)
            {
                button23.BackColor = Color.Lime;
            }
            else if (butons == 24)
            {
                button24.BackColor = Color.Lime;
            }
            else if (butons == 25)
            {
                button25.BackColor = Color.Lime;
            }
            else if (butons == 26)
            {
                button26.BackColor = Color.Lime;
            }
            else if (butons == 27)
            {
                button27.BackColor = Color.Lime;
            }
            else if (butons == 28)
            {
                button28.BackColor = Color.Lime;
            }
            else if (butons == 29)
            {
                button29.BackColor = Color.Lime;
            }
            else if (butons == 30)
            {
                button30.BackColor = Color.Lime;
            }
            else if (butons == 31)
            {
                button31.BackColor = Color.Lime;
            }
            else if (butons == 32)
            {
                button32.BackColor = Color.Lime;
            }
            else if (butons == 33)
            {
                button33.BackColor = Color.Lime;
            }
            else if (butons == 34)
            {
                button34.BackColor = Color.Lime;
            }
            else if (butons == 35)
            {
                button35.BackColor = Color.Lime;
            }
            else if (butons == 36)
            {
                button36.BackColor = Color.Lime;
            }
            else if (butons == 37)
            {
                button37.BackColor = Color.Lime;
            }
            else if (butons == 38)
            {
                button38.BackColor = Color.Lime;
            }
            else if (butons == 39)
            {
                button39.BackColor = Color.Lime;
            }
            else if (butons == 40)
            {
                button40.BackColor = Color.Lime;
            }
            else if (butons == 41)
            {
                button41.BackColor = Color.Lime;
            }
            else if (butons == 42)
            {
                button42.BackColor = Color.Lime;
            }
            else if (butons == 43)
            {
                button43.BackColor = Color.Lime;
            }
            else if (butons == 44)
            {
                button44.BackColor = Color.Lime;
            }
            else if (butons == 45)
            {
                button45.BackColor = Color.Lime;
            }
            else if (butons == 46)
            {
                button46.BackColor = Color.Lime;
            }
            else if (butons == 47)
            {
                button47.BackColor = Color.Lime;
            }
            else if (butons == 48)
            {
                button48.BackColor = Color.Lime;
            }
            else if (butons == 49)
            {
                button49.BackColor = Color.Lime;
            }
            else if (butons == 50)
            {
                button50.BackColor = Color.Lime;
            }
            else if (butons == 51)
            {
                button51.BackColor = Color.Lime;
            }
            else if (butons == 52)
            {
                button52.BackColor = Color.Lime;
            }
            else if (butons == 53)
            {
                button53.BackColor = Color.Lime;
            }
            else if (butons == 54)
            {
                button54.BackColor = Color.Lime;
            }
            else if (butons == 55)
            {
                button55.BackColor = Color.Lime;
            }
            else if (butons == 56)
            {
                button56.BackColor = Color.Lime;
            }
            else if (butons == 57)
            {
                button57.BackColor = Color.Lime;
            }
            else if (butons == 58)
            {
                button58.BackColor = Color.Lime;
            }
            else if (butons == 59)
            {
                button59.BackColor = Color.Lime;
            }
            else if (butons == 60)
            {
                button60.BackColor = Color.Lime;
            }
        }

        void butonsvk()
        {
            if (butons == 1)
            {
                button63.BackColor = Color.Red;
            }
            else if (butons == 2)
            {
                button62.BackColor = Color.Red;
            }
            else if (butons == 3)
            {
                button3.BackColor = Color.Red;
            }
            else if (butons == 4)
            {
                button4.BackColor = Color.Red;
            }
            else if (butons == 5)
            {
                button5.BackColor = Color.Red;
            }
            else if (butons == 6)
            {
                button6.BackColor = Color.Red;
            }
            else if (butons == 7)
            {
                button7.BackColor = Color.Red;
            }
            else if (butons == 8)
            {
                button8.BackColor = Color.Red;
            }
            else if (butons == 9)
            {
                button9.BackColor = Color.Red;
            }
            else if (butons == 10)
            {
                button10.BackColor = Color.Red;
            }
            else if (butons == 11)
            {
                button11.BackColor = Color.Red;
            }
            else if (butons == 12)
            {
                button12.BackColor = Color.Red;
            }
            else if (butons == 13)
            {
                button13.BackColor = Color.Red;
            }
            else if (butons == 14)
            {
                button14.BackColor = Color.Red;
            }
            else if (butons == 15)
            {
                button15.BackColor = Color.Red;
            }
            else if (butons == 16)
            {
                button16.BackColor = Color.Red;
            }
            else if (butons == 17)
            {
                button17.BackColor = Color.Red;
            }
            else if (butons == 18)
            {
                button18.BackColor = Color.Red;
            }
            else if (butons == 19)
            {
                button19.BackColor = Color.Red;
            }
            else if (butons == 20)
            {
                button20.BackColor = Color.Red;
            }
            else if (butons == 21)
            {
                button21.BackColor = Color.Red;
            }
            else if (butons == 22)
            {
                button22.BackColor = Color.Red;
            }
            else if (butons == 23)
            {
                button23.BackColor = Color.Red;
            }
            else if (butons == 24)
            {
                button24.BackColor = Color.Red;
            }
            else if (butons == 25)
            {
                button25.BackColor = Color.Red;
            }
            else if (butons == 26)
            {
                button26.BackColor = Color.Red;
            }
            else if (butons == 27)
            {
                button27.BackColor = Color.Red;
            }
            else if (butons == 28)
            {
                button28.BackColor = Color.Red;
            }
            else if (butons == 29)
            {
                button29.BackColor = Color.Red;
            }
            else if (butons == 30)
            {
                button30.BackColor = Color.Red;
            }
            else if (butons == 31)
            {
                button31.BackColor = Color.Red;
            }
            else if (butons == 32)
            {
                button32.BackColor = Color.Red;
            }
            else if (butons == 33)
            {
                button33.BackColor = Color.Red;
            }
            else if (butons == 34)
            {
                button34.BackColor = Color.Red;
            }
            else if (butons == 35)
            {
                button35.BackColor = Color.Red;
            }
            else if (butons == 36)
            {
                button36.BackColor = Color.Red;
            }
            else if (butons == 37)
            {
                button37.BackColor = Color.Red;
            }
            else if (butons == 38)
            {
                button38.BackColor = Color.Red;
            }
            else if (butons == 39)
            {
                button39.BackColor = Color.Red;
            }
            else if (butons == 40)
            {
                button40.BackColor = Color.Red;
            }
            else if (butons == 41)
            {
                button41.BackColor = Color.Red;
            }
            else if (butons == 42)
            {
                button42.BackColor = Color.Red;
            }
            else if (butons == 43)
            {
                button43.BackColor = Color.Red;
            }
            else if (butons == 44)
            {
                button44.BackColor = Color.Red;
            }
            else if (butons == 45)
            {
                button45.BackColor = Color.Red;
            }
            else if (butons == 46)
            {
                button46.BackColor = Color.Red;
            }
            else if (butons == 47)
            {
                button47.BackColor = Color.Red;
            }
            else if (butons == 48)
            {
                button48.BackColor = Color.Red;
            }
            else if (butons == 49)
            {
                button49.BackColor = Color.Red;
            }
            else if (butons == 50)
            {
                button50.BackColor = Color.Red;
            }
            else if (butons == 51)
            {
                button51.BackColor = Color.Red;
            }
            else if (butons == 52)
            {
                button52.BackColor = Color.Red;
            }
            else if (butons == 53)
            {
                button53.BackColor = Color.Red;
            }
            else if (butons == 54)
            {
                button54.BackColor = Color.Red;
            }
            else if (butons == 55)
            {
                button55.BackColor = Color.Red;
            }
            else if (butons == 56)
            {
                button56.BackColor = Color.Red;
            }
            else if (butons == 57)
            {
                button57.BackColor = Color.Red;
            }
            else if (butons == 58)
            {
                button58.BackColor = Color.Red;
            }
            else if (butons == 59)
            {
                button59.BackColor = Color.Red;
            }
            else if (butons == 60)
            {
                button60.BackColor = Color.Red;
            }
        }

        void temizle()
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
            comboBox6.SelectedItem = null;
            comboBox7.SelectedItem = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        void listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "SELECT * FROM musteribilgisi";
                    SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptor.Fill(ds, "musteribilgisi");
                    dataGridView1.DataSource = ds.Tables["musteribilgisi"];
                    cmd.CommandText = "SELECT COUNT(*) FROM musteribilgisi";
                    label15.Text = "Toplam kayıt sayısı: " + cmd.ExecuteScalar();
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu lütfen programı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO musteribilgisi(tckimlik, ad, soyad, telefon, saat, koltuk, nereden, nereye, tarih, atarih) VALUES(@tckimlik, @ad, @soyad, @telefon, @saat, @koltuk, @nereden, @nereye, @tarih, @atarih)";
                    cmd.Parameters.AddWithValue("@tckimlik", textBox1.Text); 
                    cmd.Parameters.AddWithValue("@ad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox4.Text);
                    cmd.Parameters.AddWithValue("@saat", comboBox7.Text + ":" + comboBox8.Text);
                    cmd.Parameters.AddWithValue("@koltuk", comboBox6.Text);
                    cmd.Parameters.AddWithValue("@nereden", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@nereye", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@tarih", comboBox3.Text + "." + comboBox4.Text + "." + comboBox5.Text);
                    cmd.Parameters.AddWithValue("@atarih", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd.CommandText = "INSERT INTO dolukoltuk(dolukoltuksayisi) VALUES('" + comboBox6.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd.CommandText = "DELETE FROM boskoltuk WHERE boskoltuksayisi = '" + comboBox6.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Bilet başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abilet--;
                    groupBox2.Visible = true;
                    groupBox1.Visible = false;
                    temizle();
                    if (abilet == 0)
                    {
                        bf();
                    }

                    switch (renk)
                    {
                        case 1:
                            button63.BackColor = Color.Red;
                            break;
                        case 2:
                            button62.BackColor = Color.Red;
                            break;
                        case 3:
                            button3.BackColor = Color.Red;
                            break;
                        case 4:
                            button4.BackColor = Color.Red;
                            break;
                        case 5:
                            button5.BackColor = Color.Red;
                            break;
                        case 6:
                            button6.BackColor = Color.Red;
                            break;
                        case 7:
                            button7.BackColor = Color.Red;
                            break;
                        case 8:
                            button8.BackColor = Color.Red;
                            break;
                        case 9:
                            button9.BackColor = Color.Red;
                            break;
                        case 10:
                            button10.BackColor = Color.Red;
                            break;
                        case 11:
                            button11.BackColor = Color.Red;
                            break;
                        case 12:
                            button12.BackColor = Color.Red;
                            break;
                        case 13:
                            button13.BackColor = Color.Red;
                            break;
                        case 14:
                            button14.BackColor = Color.Red;
                            break;
                        case 15:
                            button15.BackColor = Color.Red;
                            break;
                        case 16:
                            button16.BackColor = Color.Red;
                            break;
                        case 17:
                            button17.BackColor = Color.Red;
                            break;
                        case 18:
                            button18.BackColor = Color.Red;
                            break;
                        case 19:
                            button19.BackColor = Color.Red;
                            break;
                        case 20:
                            button20.BackColor = Color.Red;
                            break;
                        case 21:
                            button21.BackColor = Color.Red;
                            break;
                        case 22:
                            button22.BackColor = Color.Red;
                            break;
                        case 23:
                            button23.BackColor = Color.Red;
                            break;
                        case 24:
                            button24.BackColor = Color.Red;
                            break;
                        case 25:
                            button25.BackColor = Color.Red;
                            break;
                        case 26:
                            button26.BackColor = Color.Red;
                            break;
                        case 27:
                            button27.BackColor = Color.Red;
                            break;
                        case 28:
                            button28.BackColor = Color.Red;
                            break;
                        case 29:
                            button29.BackColor = Color.Red;
                            break;
                        case 30:
                            button30.BackColor = Color.Red;
                            break;
                        case 31:
                            button31.BackColor = Color.Red;
                            break;
                        case 32:
                            button32.BackColor = Color.Red;
                            break;
                        case 33:
                            button33.BackColor = Color.Red;
                            break;
                        case 34:
                            button34.BackColor = Color.Red;
                            break;
                        case 35:
                            button35.BackColor = Color.Red;
                            break;
                        case 36:
                            button36.BackColor = Color.Red;
                            break;
                        case 37:
                            button37.BackColor = Color.Red;
                            break;
                        case 38:
                            button38.BackColor = Color.Red;
                            break;
                        case 39:
                            button39.BackColor = Color.Red;
                            break;
                        case 40:
                            button40.BackColor = Color.Red;
                            break;
                        case 41:
                            button41.BackColor = Color.Red;
                            break;
                        case 42:
                            button42.BackColor = Color.Red;
                            break;
                        case 43:
                            button43.BackColor = Color.Red;
                            break;
                        case 44:
                            button44.BackColor = Color.Red;
                            break;
                        case 45:
                            button45.BackColor = Color.Red;
                            break;
                        case 46:
                            button46.BackColor = Color.Red;
                            break;
                        case 47:
                            button47.BackColor = Color.Red;
                            break;
                        case 48:
                            button48.BackColor = Color.Red;
                            break;
                        case 49:
                            button49.BackColor = Color.Red;
                            break;
                        case 50:
                            button50.BackColor = Color.Red;
                            break;
                        case 51:
                            button51.BackColor = Color.Red;
                            break;
                        case 52:
                            button52.BackColor = Color.Red;
                            break;
                        case 53:
                            button53.BackColor = Color.Red;
                            break;
                        case 54:
                            button54.BackColor = Color.Red;
                            break;
                        case 55:
                            button55.BackColor = Color.Red;
                            break;
                        case 56:
                            button56.BackColor = Color.Red;
                            break;
                        case 57:
                            button57.BackColor = Color.Red;
                            break;
                        case 58:
                            button58.BackColor = Color.Red;
                            break;
                        case 59:
                            button59.BackColor = Color.Red;
                            break;
                        case 60:
                            button60.BackColor = Color.Red;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu lütfen programı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button63.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("1");
                    comboBox6.SelectedItem = "1";
                    renk = 1;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            listele();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diyalog = MessageBox.Show("Kayıdı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diyalog == DialogResult.Yes)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        butons = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = baglanti;
                        cmd.CommandText = "DELETE FROM musteribilgisi WHERE sirano='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cmd.CommandText = "INSERT INTO boskoltuk(boskoltuksayisi) VALUES('" + dataGridView1.CurrentRow.Cells[6].Value + "')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cmd.CommandText = "DELETE FROM dolukoltuk WHERE dolukoltuksayisi = '" + dataGridView1.CurrentRow.Cells[6].Value + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        baglanti.Close();
                        listele();
                        MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        butonsvy();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu lütfen programı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button62.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("2");
                    comboBox6.SelectedItem = "2";
                    renk = 2;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("3");
                    comboBox6.SelectedItem = "3";
                    renk = 3;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("4");
                    comboBox6.SelectedItem = "4";
                    renk = 4;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("5");
                    comboBox6.SelectedItem = "5";
                    renk = 5;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("6");
                    comboBox6.SelectedItem = "6";
                    renk = 6;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("7");
                    comboBox6.SelectedItem = "7";
                    renk = 7;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("8");
                    comboBox6.SelectedItem = "8";
                    renk = 8;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("9");
                    comboBox6.SelectedItem = "9";
                    renk = 9;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("10");
                    comboBox6.SelectedItem = "10";
                    renk = 10;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("11");
                    comboBox6.SelectedItem = "11";
                    renk = 11;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button12.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("12");
                    comboBox6.SelectedItem = "12";
                    renk = 12;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button13.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("13");
                    comboBox6.SelectedItem = "13";
                    renk = 13;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button14.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("14");
                    comboBox6.SelectedItem = "14";
                    renk = 14;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button15.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("15");
                    comboBox6.SelectedItem = "15";
                    renk = 15;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button16.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("16");
                    comboBox6.SelectedItem = "16";
                    renk = 16;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button17.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("17");
                    comboBox6.SelectedItem = "17";
                    renk = 17;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button18.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("18");
                    comboBox6.SelectedItem = "18";
                    renk = 18;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button19.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("19");
                    comboBox6.SelectedItem = "19";
                    renk = 19;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button20.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("20");
                    comboBox6.SelectedItem = "20";
                    renk = 20;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button21.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("21");
                    comboBox6.SelectedItem = "21";
                    renk = 21;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button22.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("22");
                    comboBox6.SelectedItem = "22";
                    renk = 22;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button23.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("23");
                    comboBox6.SelectedItem = "23";
                    renk = 23;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button24.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("24");
                    comboBox6.SelectedItem = "24";
                    renk = 24;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button25.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("25");
                    comboBox6.SelectedItem = "25";
                    renk = 25;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button26.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("26");
                    comboBox6.SelectedItem = "26";
                    renk = 26;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button27.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("27");
                    comboBox6.SelectedItem = "27";
                    renk = 27;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button28.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("28");
                    comboBox6.SelectedItem = "28";
                    renk = 28;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button29.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("29");
                    comboBox6.SelectedItem = "29";
                    renk = 29;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button30.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("30");
                    comboBox6.SelectedItem = "30";
                    renk = 30;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button31.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("31");
                    comboBox6.SelectedItem = "31";
                    renk = 31;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button32.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("32");
                    comboBox6.SelectedItem = "32";
                    renk = 32;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button33.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("33");
                    comboBox6.SelectedItem = "33";
                    renk = 33;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button34.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("34");
                    comboBox6.SelectedItem = "34";
                    renk = 34;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button35.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("35");
                    comboBox6.SelectedItem = "35";
                    renk = 35;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button36.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("36");
                    comboBox6.SelectedItem = "36";
                    renk = 36;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button37.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("37");
                    comboBox6.SelectedItem = "37";
                    renk = 37;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button38.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("38");
                    comboBox6.SelectedItem = "38";
                    renk = 38;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button39.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("39");
                    comboBox6.SelectedItem = "39";
                    renk = 39;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button40.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("40");
                    comboBox6.SelectedItem = "40";
                    renk = 40;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button41.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("41");
                    comboBox6.SelectedItem = "41";
                    renk = 41;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button42.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("42");
                    comboBox6.SelectedItem = "42";
                    renk = 42;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button43.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("43");
                    comboBox6.SelectedItem = "43";
                    renk = 43;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button44.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("44");
                    comboBox6.SelectedItem = "44";
                    renk = 44;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button45.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("45");
                    comboBox6.SelectedItem = "45";
                    renk = 45;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button46.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("46");
                    comboBox6.SelectedItem = "46";
                    renk = 46;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button47.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("47");
                    comboBox6.SelectedItem = "47";
                    renk = 47;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button48.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("48");
                    comboBox6.SelectedItem = "48";
                    renk = 48;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button49.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("49");
                    comboBox6.SelectedItem = "49";
                    renk = 49;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button50.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("50");
                    comboBox6.SelectedItem = "50";
                    renk = 50;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button51.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("51");
                    comboBox6.SelectedItem = "51";
                    renk = 51;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button52.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("52");
                    comboBox6.SelectedItem = "52";
                    renk = 52;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button53.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("53");
                    comboBox6.SelectedItem = "53";
                    renk = 53;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button54.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("54");
                    comboBox6.SelectedItem = "54";
                    renk = 54;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button55.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("55");
                    comboBox6.SelectedItem = "55";
                    renk = 55;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button56.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("56");
                    comboBox6.SelectedItem = "56";
                    renk = 56;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button57.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("57");
                    comboBox6.SelectedItem = "57";
                    renk = 57;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button58.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("58");
                    comboBox6.SelectedItem = "58";
                    renk = 58;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            abilet = Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(numericUpDown2.Value) + Convert.ToInt32(numericUpDown3.Value);
            if (abilet != 0)
            {
                bt();
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            abilet = 0;
            bf();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button59.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("59");
                    comboBox6.SelectedItem = "59";
                    renk = 59;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (abilet > 0)
            {
                if (button60.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu koltuk dolu lütfen başka koltuk seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBox6.Items.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    comboBox6.Items.Add("60");
                    comboBox6.SelectedItem = "60";
                    renk = 60;
                }
            }
            else if (abilet == 0)
            {
                bf();
            }
        }
    }
}