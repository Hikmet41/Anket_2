
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Xml;

namespace Anket_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_elave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ad.Text) && !string.IsNullOrEmpty(tb_soyad.Text) && !string.IsNullOrEmpty(tb_email.Text) && !string.IsNullOrEmpty(tb_tel.Text) && !string.IsNullOrEmpty(tb_birhday.Text))
            {

                Person person = new Person(tb_ad.Text, tb_soyad.Text, tb_email.Text, tb_tel.Text, tb_birhday.Text);
                listBox1.Items.Add(person);
                tb_ad.Text = "";
                tb_soyad.Text = "";
                tb_email.Text = "";
                tb_tel.Text = "";
                tb_birhday.Text = "";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_filename.Text))
            {
                string fileName = $"../../../{tb_filename.Text}";
                string a = JsonConvert.SerializeObject(listBox1.Items, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, a);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            string fileName = $"../../../{tb_filename.Text}";
            if (File.Exists(fileName))
            {
                listBox1.Items.Clear();
                string json = File.ReadAllText(fileName);
                List<Person> list = JsonConvert.DeserializeObject<List<Person>>(json);
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                tb_filename.Text = fileName;

            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void button_deyis_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ad.Text) && !string.IsNullOrEmpty(tb_soyad.Text) && !string.IsNullOrEmpty(tb_email.Text) && !string.IsNullOrEmpty(tb_tel.Text) && !string.IsNullOrEmpty(tb_birhday.Text))
            {

                Person person = new Person(tb_ad.Text, tb_soyad.Text, tb_email.Text, tb_tel.Text, tb_birhday.Text);
                listBox1.Items[listBox1.SelectedIndex] = person;
                listBox1.SelectedIndex = -1;
                tb_ad.Text = "";
                tb_soyad.Text = "";
                tb_email.Text = "";
                tb_tel.Text = "";
                tb_birhday.Text = "";


                button_elave.Visible = true;
                button_deyis.Visible = false;

            }
        }
    }


}