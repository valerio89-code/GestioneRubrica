using GestioneRubrica.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneRubrica
{
    public partial class AddContact : Form
    {
        public Contatto ContattoAggiunto { get; set; }
        public AddContact()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ContattoAggiunto = new Contatto()
            {
                Nome = tbx_nome.Text,
                Cognome = tbx_cognome.Text,
                NumeroTelefono = tbx_numeroTelefono.Text
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
