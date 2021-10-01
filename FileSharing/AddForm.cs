using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileSharing
{
    public partial class AddForm : Form
    {
        // Dictionary<string, string> images = new Dictionary<string, string>();
        struct FileImage
        {
            public Icon icon;
            public string key;
        };

        public AddForm()
        {
            InitializeComponent();
            AddFolderList.Columns.Add("Folder Name", 350);
            AddFolderList.Columns.Add("File Path", 350);
            AddFolderList.Columns.Add("File Size", 200, HorizontalAlignment.Right);

            //ImageList imageList1 = new ImageList();
            //imageList1.ColorDepth = ColorDepth.Depth32Bit;
            //AddFolderList.SmallImageList = imageList1;

            //DirectoryInfo dir = new DirectoryInfo(@"D:\Program\DevelopTool");

            //ListViewItem item;            
            //FileInfo[] files = dir.GetFiles();
            //int len = files.Length;
            //FileImage[] images = new FileImage[len];
            //AddFolderList.BeginUpdate();
            //for (int i=0; i< len; i++)
            //{
            //    string filename = files[i].FullName;
            //    string fileext = files[i].Extension.ToLower();
            //    item = new ListViewItem(files[i].Name, 3);
            //    Icon iconForFile = SystemIcons.WinLogo;
            //    string imageKey = fileext == ".exe" ? Helper.Hash(filename) : fileext;
            //    images[i].key = imageKey;
            //    if (imageList1.Images.IndexOfKey(images[i].key) == -1)
            //    {
            //        iconForFile = Icon.ExtractAssociatedIcon(filename);
            //        imageList1.Images.Add(images[i].key, iconForFile);
            //        images[i].icon = iconForFile;
            //    }
            //    AddFolderList.Items.Add(item);
            //}
            //AddFolderList.EndUpdate();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
