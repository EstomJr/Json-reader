using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace ProjetctElógica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader("d:\\C#\\JsonReader\\projeto.json"))
            {
                string json = r.ReadToEnd();
                Hero hero = JsonConvert.DeserializeObject<Hero>(json);
                dynamic array = JsonConvert.DeserializeObject(json);
                textBox1.Text = hero.nome;
                textBox2.Text = hero.idade;
                textBox3.Text = hero.identidadeSecreta;
                textBox4.Text = hero.poderes;
                
            }
        }
        public class Hero
        {
            public string nome { get; set; }
            public string idade { get; set; }
            public string identidadeSecreta { get; set; }
            public string poderes { get; set; }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hero h = new Hero();

            h.nome = textBox1.Text;
            h.idade = textBox2.Text;
            h.identidadeSecreta = textBox3.Text;
            h.poderes = textBox4.Text;

            var json = JsonConvert.SerializeObject(h);

            System.IO.File.WriteAllText(@"d:\\C#\\JsonReader\\projeto.json", json);
            this.Close();
        }
    }
}
