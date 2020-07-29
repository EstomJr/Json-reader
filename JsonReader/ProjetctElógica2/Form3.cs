using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjetctElógica2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader("d:\\C#\\JsonReader\\projeto.json"))
            {
                string json = r.ReadToEnd();
                Hero hero = JsonConvert.DeserializeObject<Hero>(json);
                dynamic array = JsonConvert.DeserializeObject(json);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;



            }
        }
        public class Hero
        {
            public string nome { get; set; }
            public string idade { get; set; }
            public string identidadeSecreta { get; set; }
            public string poderes { get; set; }
           // public ArrayList poderes { get; set; }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 60)
            {
                MessageBox.Show("ERROR! Permitido apenas 60 caracteres");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 10)
            {
                MessageBox.Show("ERROR! Permitido apenas 10 caracteres");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength > 60)
            {
                MessageBox.Show("ERROR! Permitido apenas 60 caracteres");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.TextLength > 10) 
            {
                MessageBox.Show("ERROR! Permitido apenas 10 caracteres");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hero h = new Hero();

            h.nome = textBox1.Text;
            h.idade = textBox2.Text;
            h.identidadeSecreta = textBox3.Text;
            h.poderes = textBox4.Text;

            var json = JsonConvert.SerializeObject(h);

            System.IO.File.WriteAllText(@"d:\C#\JsonReader\projeto.json", json);
            

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
            else
            {
                this.Close();
            }

            if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
            else
            {
                this.Close();
            }

            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
            else
            {
                this.Close();
            }

            if (textBox4.TextLength == 0)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
            else
            {
                this.Close();
            }





        }
    }
}
