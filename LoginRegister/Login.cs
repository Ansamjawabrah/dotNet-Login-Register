using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace LoginRegister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        IFirebaseConfig conf = new FirebaseConfig()
        {
            AuthSecret = "0v7BZ4bmbNv1wi424GVkriuhARxSU72n23oXym0Y",
            BasePath = "https://login-43b1b-default-rtdb.firebaseio.com/"

        };
        IFirebaseClient cli;
        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            button1.Hide();
            try
            {
             cli = new FireSharp.FirebaseClient(conf);

            }catch (Exception ex)
            {
            MessageBox.Show ("there has been an error");
            }
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          User u = new User()
            {   Email = UsernameTB.Text,
                UserName = textBox1.Text,
                Password = PasswordTB.Text

            };
            cli.Set("Users/" + UsernameTB.Text.ToString(), u);

        }



        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = cli.Get("Users/" + UsernameTB.Text).ResultAs<User>();
                if (user != null)
                {
                    if (user.Password == PasswordTB.Text)
                    {
                        MessageBox.Show("Hello" + " " + user.UserName);
                        
                    }
                    else MessageBox.Show("Wrong Password ");
                }
                else MessageBox.Show("There is no such a user with this name ! \n");

            }
            catch (Exception)
            {

                MessageBox.Show("Check your counction !");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
    
}

