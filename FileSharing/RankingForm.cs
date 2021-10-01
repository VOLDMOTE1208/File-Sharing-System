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
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
            RankingList.Columns.Add("User", 475);
            RankingList.Columns.Add("Score", 530);
            
        }
    }
}
