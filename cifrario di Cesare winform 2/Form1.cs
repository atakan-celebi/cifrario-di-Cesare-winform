using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cifrario_di_Cesare_winform_2
{
    public partial class Form1 : Form
    {
        static string CifraCesare(string input, int chiave)
        {
            char[] risultato = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLetter(c))
                {
                    char baseLettera = char.IsUpper(c) ? 'A' : 'a';
                    risultato[i] = (char)((((c - baseLettera) + chiave) % 26 + 26) % 26 + baseLettera);
                }
                else
                {
                    risultato[i] = c;
                }
            }

            return new string(risultato);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtChiave.Text, out int Chiave));
            txtCifrato.Text = CifraCesare(txtMessaggio.Text,Chiave);
            txtDecifrato.Text = txtMessaggio.Text;
        }
    }
}
