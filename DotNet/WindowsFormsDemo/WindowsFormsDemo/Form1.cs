using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace WindowsFormsDemo
{
    /// <summary>
    /// Tämä luokka tekee sitä ja tätä...
    /// </summary>
    /// <inheritdoc/>    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string polku = @"C:\VismaAcademy\Git\DotNet\WindowsFormsDemo\WindowsFormsDemo\bin\Debug\WindowsFormsDemo.xml";
        }

        /// <summary>
        /// Tähän kuvaus tapahtumankäsittelijästä nimeltä Button1.Click.
        /// </summary>
        /// <param name="sender">Lähettäjän tiedot</param>
        /// <param name="e">Tietoja tapahtumasta</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("Pöö!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var anon = new { a = 1, b = "ABC" };
            var nimi = "Masa M.";
            ArgumentOutOfRangeException x = new ArgumentOutOfRangeException();

            #region HTTP-koodia
            HttpClient client = new HttpClient();
            string url = "https://www.ilmatieteenlaitos.fi/saa/lappeenranta";
            string html = client.GetStringAsync(url).Result;
            HaeLämpötila(html);

            client.Dispose();
            #endregion
        }

        private static void HaeLämpötila(string html)
        {
            // MessageBox.Show(html.Substring(0, 500));
            string haku = "<div class=\"temperature";
            int indeksi = html.IndexOf(haku);
            if (indeksi > 0)
            {
                string lämpötila = html.Substring(indeksi + 61, 1);
                MessageBox.Show("Lämpötila Lappenrannassa: " + lämpötila + " astetta.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
