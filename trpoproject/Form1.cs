using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpoproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogMainMenu_Click(object sender, EventArgs e)
        {
            panelLog.Visible = true;
        }

        private void ButtonSignMainMenu_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = true;
        }

        private void ButtonExitMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLoginLog_Click(object sender, EventArgs e)  //АВТОРИЗАЦИЯ
        {
            string login = textBoxLoginSignIn.Text;
            string password=TextBoxLoginLog.Text;
            if (login =="" | password == "")
            {
                MessageBox.Show("You must enter all the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
            //Form2 frm = new Form2();
            //this.Hide();
            //frm.ShowDialog();
            //this.Close();
        }

        private void TextBoxLoginLog_click(object sender, EventArgs e)
        {
            TextBoxLoginLog.Text = "";
        }

        private void textboxPasswordLog_click(object sender, EventArgs e)
        {
            textBoxPasswordLog.Text = "";
        }

        private void ButtonBackLogToMain_Click(object sender, EventArgs e)
        {
            panelLog.Visible = false;
        }

        private void textBoxLoginSignIn_Click(object sender, EventArgs e)
        {
            textBoxLoginSignIn.Text = "";
        }

        private void textBoxPassSignIn_Click(object sender, EventArgs e)
        {
            textBoxPassSignIn.Text = "";
        }

        private void textBoxRepeatPassSignIn_Click(object sender, EventArgs e)
        {
            textBoxRepeatPassSignIn.Text = "";
        }

        private void ButtonBackSignIn_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = false;
        }

        private void ButtonSignSignIn_Click(object sender, EventArgs e) //РЕГИСТРАЦИЯ
        {
            string login = textBoxLoginSignIn.Text;
            string password1 = textBoxPassSignIn.Text;
            string password2 = textBoxRepeatPassSignIn.Text;
            if(login=="" | password1 == "" | password2 == "")
            {
                MessageBox.Show("You must enter all the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password1 == password2)
                {
                    try
                    {
                        string databaseName = @"D:\study\3 курс\ТРПО\bd\accounts.db";
                        SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                        connection.Open();
                        string cmd = $"INSERT INTO accounts (Login, Password) VALUES ('{login}', '{password1}')";
                        SQLiteCommand command = new SQLiteCommand(cmd, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Successfull! Let's log in!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelSignIn.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Account witch this login is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Passwords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}