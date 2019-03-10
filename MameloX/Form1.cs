using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MameloX
{
    public partial class Form1 : Form
    {

        List<String> favoritos = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtFinder.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFinder.Text = "https://www.google.com/";
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            actualizarFavoritos();
        }

        private void actualizarFavoritos()
        {
            comboBox1.Items.Clear();
            foreach(string direccion in favoritos)
            {
                comboBox1.Items.Add(direccion);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                webBrowser1.Navigate(txtFinder.Text);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.SelectedItem.ToString());
            txtFinder.Text = comboBox1.SelectedItem.ToString();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtFinder.Text = webBrowser1.Url.ToString();
        }
    }
}
