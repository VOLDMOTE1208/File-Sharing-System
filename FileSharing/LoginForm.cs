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
using System.Net;
using System.Net.Http;

namespace FileSharing
{
    public partial class LoginForm : Form
    {
        public string respond;
        public LoginForm()
        {
            InitializeComponent();
            this.TopMost = true;
            if (File.Exists("login_auth.txt"))
            {
                string[] lines = File.ReadAllLines("login_auth.txt");
                UserName_Edit.Text = lines[0];
                Password_Edit.Text = lines[1];
            }
        }

        private void HTTPPost(string user, string pass)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://192.168.115.164:5656/log_in/?user=" + user + "&password=" + pass);

                var postData = "n=42&s=string value";
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();    //response
                respond = responseString.ToString();
                MessageBox.Show(respond, "title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Server connection Error!", "title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UserName_Edit.Text) && !string.IsNullOrWhiteSpace(Password_Edit.Text))
            {
                string username = UserName_Edit.Text;
                //Mainform.login_user = username;
                string password = Password_Edit.Text;

                HTTPPost(username, password);

                StreamWriter writer = new StreamWriter("login_auth.txt");
                writer.WriteLine(username);
                writer.WriteLine(password);
                writer.Close();

                if (respond == "Log in successful!")
                {
                    this.Hide();
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Password_ShowState.Checked == true)
                Password_Edit.PasswordChar = '\0';
            else
                Password_Edit.PasswordChar = '*';
        }
    }
}
