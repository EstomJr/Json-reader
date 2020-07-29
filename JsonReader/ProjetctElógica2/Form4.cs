using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ProjetctElógica2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader("d:\\C#\\JsonReader\\projeto.json"))
            {
                string json = r.ReadToEnd();
                Hero hero = JsonConvert.DeserializeObject<Hero>(json);
                dynamic array = JsonConvert.DeserializeObject(json);
            }
        }
        public class Hero
        {
            public string nome { get; set; }
            public string idade { get; set; }
            public string identidadeSecreta { get; set; }
            public string poderes { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer excluir o item?", "Nome", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hero h = new Hero();
                var json = JsonConvert.SerializeObject(h);
                JObject jo = JObject.Parse(json);
                jo.Property("nome").Remove();
                json = jo.ToString();
            }else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer excluir o item?", "Nome", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hero h = new Hero();
                var json = JsonConvert.SerializeObject(h);
                JObject jo = JObject.Parse(json);
                jo.Property("idade").Remove();
                json = jo.ToString();
            }
            else
            {
                this.Close();
            }
        }
    }

}
