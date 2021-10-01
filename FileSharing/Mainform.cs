using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSharing
{
    public partial class Mainform : Form
    {        
        public Mainform()
        {
            InitializeComponent();

            DownloadList.Columns.Add("Provider", 150);
            DownloadList.Columns.Add("IP", 150);
            DownloadList.Columns.Add("File Name", 250);
            DownloadList.Columns.Add("File Size", 150, HorizontalAlignment.Right);
            DownloadList.Columns.Add("Peer Num", 100, HorizontalAlignment.Right);
            DownloadList.Columns.Add("Score", 100, HorizontalAlignment.Right);


            for (int index = 0; index < 35; index++)
            {
                string[] arr = new string[6];
                ListViewItem itm;
                arr[0] = "Gaepo";
                arr[1] = "192.168.115.163";
                arr[2] = "Developtool";
                arr[3] = "4,567,123";
                arr[4] = "4";
                arr[5] = "25";
                itm = new ListViewItem(arr);
                DownloadList.Items.Add(itm);
            }


        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            RankingForm ranking = new RankingForm();
            ranking.ShowDialog();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
}
