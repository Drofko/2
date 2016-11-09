using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conventer_Valut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;
            if(textBox2.Text=="")
            {
                from = listBox1.SelectedItem.ToString();
            }
            else
            {
                from = textBox2.Text;
            }
            if (textBox3.Text == "")
            {
                to = listBox2.SelectedItem.ToString();
            }
            else
            {
                to = textBox3.Text;
            }
            if(from==to)
            {
                MessageBox.Show("Это одна и та же валюта. Перевод невозможен!", "Внимание!");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Введите количество валюты для перевода!", "Внимание!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from + " %D0%B2 " + to );
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
