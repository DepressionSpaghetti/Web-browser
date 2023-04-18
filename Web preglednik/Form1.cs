using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;

namespace Web_preglednik
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        #region Navigation
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }
        
        private void btnContext_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }
        #endregion



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter) webBrowser1.Navigate(textBox1.Text);
        }

        private void bookmarkSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Bookmark name", "Bookmark", "", 407, 15);
            
            //ctxBookmarks.DropDownItems.Add(bookmarksName());

        }

        private void bookmarkJson()
        {
            var appConfig = new ConfigurationBuilder()
                .AddJsonFile($@"config\credentials.json")
                .Build();
        }
    }
}
