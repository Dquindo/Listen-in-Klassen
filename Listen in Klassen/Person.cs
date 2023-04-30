using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listen_in_Klassen
{
    class Person
    {

        //Atribute
        public int id;
        public string name;
        public string telefonnummer;
        private string passwort = "geheimpasswort";


        //Konstruktor
        public Person(int id, string name, string telefonnummer)
        {
            this.id = id;
            this.name = name;
            this.telefonnummer = telefonnummer;

        }

        //getter setter
        public bool setPasswort(string passwort)
        {
            if (passwort.Length >= 6)
            {
                this.passwort = passwort;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string getPasswort()
        {
            return this.passwort;
        }
        //Methoden
        public void datenAusgeben(TextBox txtBox)
        {
            txtBox.Text += "ID: " + this.id + "\r\nName: " + this.name + "\r\nTel. : " + this.telefonnummer + "\r\n";
            txtBox.Text += "\r\nPasswort: " + this.passwort + "\r\n";

        }

    }
}
