using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shayan_material;
using shayan_material.Controls;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void shayan_RaisedButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://magicohost.org/whois/whois.php?domain=" + shayan_SingleLineTextField1.Text);
        }

        private void shayan_RaisedButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://magicohost.org/acc/cart.php?a=add&domain=register");
        }

        private void shayan_RaisedButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://magicohost.org/acc/cart.php");
        }
    }
}
