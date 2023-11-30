using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Введите имя";
            UserPasswordField.Text = "Введите пароль";
        }


        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.Black;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.Black;
            }
        }

        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
                UserLoginField.ForeColor = Color.Gray;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }
        }


        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Введите имя")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }

            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Введите имя")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "SELECT COUNT(id) FROM users WHERE login = @login AND password = @password",
                db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));

            db.OpenConnection();

            int countUser = Convert.ToInt32(command.ExecuteScalar());      // позволяет выполнить команды, кот. должны вернуть значение (исп. при каунт или сумм в SQL)
            if (countUser > 0)
            {
                this.Hide();    // скрывает текущее окно
                PingPong pingPong = new PingPong();
                pingPong.ShowDialog();
                this.Close();
            }


            else MessageBox.Show("Пользователь не существует");
            db.CloseConnection();
        }

        private string Hash(string input)       // метод кеширования для шифровки паролей
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void linkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();    // скрывает текущее окно
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
