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

namespace SerializzaDeserializza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Libreria libreria = new Libreria();
        class Libri
        {
            
            public string _titolo { get ; set; }
            public string _autore { get; set; }

            public Libri()
            { }
            public Libri(string titolo, string autore)
            {
                _titolo = titolo;
                _autore = autore;
            }
            public string Serializza()
            {
                return $"{_titolo};{_autore}";
            }        
        }

        class Libreria
        {
            public List<Libri> _libri = new List<Libri>();

            public void Leggi()
            {                
                using (StreamReader sr = new StreamReader(@"Libri.txt"))
                {

                    string[] array = new string[2];
                    string linea = sr.ReadLine();
                    while (linea != null)
                    {                   
                        if(linea != null)
                        {                          
                            array = linea.Split(';');
                            Libri libro = new Libri(array[0], array[1]);
                            _libri.Add(libro);
                        }
                        linea = sr.ReadLine();
                    }
                }
            }

            public void Scrivi()
            {
                using (StreamWriter sw = new StreamWriter("Libri.txt"))
                {
                    for (int i = 0; i < _libri.Count; i++)
                    {
                        sw.WriteLine(_libri[i].Serializza());
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Libri.txt") == true)
            {
                libreria.Leggi();
                for (int i = 0; i < libreria._libri.Count; i++)
                {
                    listbox.Items.Add(libreria._libri[i].Serializza());
                }
            }      
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(txt_titolo.Text != "" && txt_autore.Text != "")
            {
                libreria._libri.Add(new Libri(txt_titolo.Text, txt_autore.Text));
                Read();
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < libreria._libri.Count; i++)
            {
                if(txt_autore.Text == libreria._libri[i]._autore && txt_titolo.Text == libreria._libri[i]._titolo)
                {
                    MessageBox.Show("Libro trovato in posizione: " + i);
                }
            }
        }
        
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_titolo.Text != "" && txt_autore.Text != "" && listbox.SelectedIndex != -1)
            {
                int a = listbox.SelectedIndex;
                libreria._libri[a]._titolo = txt_titolo.Text;
                libreria._libri[a]._autore = txt_autore.Text;
                Read();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(listbox.SelectedIndex != -1)
            {
                int a = listbox.SelectedIndex;
                libreria._libri.RemoveAt(a);
                Read();
            }        
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            libreria.Scrivi();
        }

        public void Read()
        {
            listbox.Items.Clear();
            for (int i = 0; i < libreria._libri.Count; i++)
            {
                listbox.Items.Add(libreria._libri[i].Serializza());
            }
        }
    }
}
