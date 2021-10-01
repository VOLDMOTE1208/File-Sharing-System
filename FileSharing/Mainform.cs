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
