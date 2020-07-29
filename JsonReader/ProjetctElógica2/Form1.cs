using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;
using System.Web.Helpers;

namespace ProjetctElógica2
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("d:\\C#\\JsonReader\\projeto.json"))
            {
                string json = r.ReadToEnd();
                Hero hero = JsonConvert.DeserializeObject<Hero>(json);
                dynamic obj = JsonConvert.DeserializeObject(json);
                textBox1.Text = hero.nome;
                textBox2.Text = hero.idade;
               
            }
        }
        public class Hero
        {
            public string nome { get; set; }
            public string idade { get; set; }
            public string identidadeSecreta { get; set; }
            public string poderes { get; set; }

            //[JsonProperty("poderes")]
            //public string poderes { get; set; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nt = new Thread(NovoForme2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            
        }

        private void saveClick(object sender, EventArgs e)
        {
            Hero h = new Hero();

            h.nome = textBox1.Text;
            h.idade = textBox2.Text;

            var json = JsonConvert.SerializeObject(h);


           
            System.IO.File.WriteAllText(@"d:\C#\JsonReader\projeto.json", json);

            
        }


        private void Inserir_Click(object sender, EventArgs e)
        {
            nt = new Thread(NovoForme);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void NovoForme2()
        {
            Application.Run(new Form4());
        }
        private void NovoForme()
        {
            Application.Run(new Form3());
        }

        private void NovoForm()
        {
            Application.Run(new Form2());
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            nt = new Thread(NovoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        
    }

   
}
    


