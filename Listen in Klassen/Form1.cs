using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listen_in_Klassen
{
    
    public partial class Form1 : Form
    {
        //Attribute
    
        StreamReader myReader = new StreamReader("user.csv");
        List<Person> PersonenListe = new List<Person> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (!myReader.EndOfStream)
            {
                string eineZeile = myReader.ReadLine();
                string[] UserArayEineZeile = eineZeile.Split(',');
                PersonenListe.Add(new Person(Int32.Parse(UserArayEineZeile[0]), UserArayEineZeile[1], UserArayEineZeile[2]));
            }

            foreach (var item in PersonenListe)
            {
                listBox1.Items.Add(item.name);
            }
            AllePersonenAusgeben();
        }


        private void AllePersonenAusgeben()
        {
            foreach (Person person in PersonenListe)
            {
                person.datenAusgeben(textBox1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Person person in PersonenListe)
            {
                if (listBox1.SelectedItem.ToString() == person.name)
                {
                    person.datenAusgeben(textBox1);
                }
            }

        }
    }
}
