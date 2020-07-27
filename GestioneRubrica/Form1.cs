using GestioneRubrica.Code;
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

namespace GestioneRubrica
{
    public partial class Form1 : Form
    {
        private List<Contatto> contatti;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_caricaCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = openFileDialog1.FileName != string.Empty
                ? Path.GetFileName(openFileDialog1.FileName)
                : "";
            var dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                contatti = ReadCsv(openFileDialog1.FileName);
                BindData();
                btn_addContact.Enabled = true;
                btn_saveCSV.Enabled = true;
            }
        }

        private void BindData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contatti;
            dataGridView1.Columns[2].HeaderText = "Numero di telefono";
        }

        private List<Contatto> ReadCsv(string fileName)
        {
            using (var strReader = new StreamReader(fileName))
            {
                var list = new List<Contatto>();
                while (true)
                {
                    string line = strReader.ReadLine();
                    if (line == null) break;
                    var splittedLine = line.Split(',');
                    var contatto = new Contatto()
                    {
                        Nome = splittedLine[0],
                        Cognome = splittedLine[1],
                        NumeroTelefono = splittedLine[2]
                    };
                    list.Add(contatto);
                }
                return list;
            }
        }

        /// <summary>
        /// Legge i dati dal CSV utilizzando la classe File invece di streamReader
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private List<Contatto> ReadCsvWithFileClass(string fileName)
        {
            var list = new List<Contatto>();

            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                list.Add(new Contatto(line));
            }
            return list;
        }

        private void btn_addContact_Click(object sender, EventArgs e)
        {
            var addContactForm = new AddContact();
            var dlgResult = addContactForm.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                contatti.Add(addContactForm.ContattoAggiunto);
                BindData();
            }
        }

        private void btn_saveCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
            var sfdResult = saveFileDialog1.ShowDialog();
            if (sfdResult == DialogResult.OK)
            {
                using (var strWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var contatto in contatti)
                    {
                        strWriter.WriteLine($"{contatto.Nome},{contatto.Cognome},{contatto.NumeroTelefono}");
                    }
                }
            }

        }
    }
}
