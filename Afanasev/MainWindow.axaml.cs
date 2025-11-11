using Avalonia.Controls;
using Afanasev.Models;
using System.Linq;

namespace Afanasev
{
    public partial class MainWindow : Window
    {
        public int countAtt=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countAtt == 3)
            {
                var blockWin = new BlockWindow();
                blockWin.Show();
                this.Close();
            }
            countAtt++;
            var login = loginTxt.Text;
            var password = passwordTxt.Text;
            using var context = new Db500Context();
            var users = context.Users.ToList();

            if (login != null || password != null)
            {
                foreach (var user in users)
                {
                    if (login == user.Login && password == user.Password)
                    {
                        if (user.RoleId == 1)
                        {
                            var adminWin = new AdminWindow();
                            adminWin.Show();
                            var eventWin = new EventWindow("Вы успешно авторизовались");
                            eventWin.Show();    
                            this.Close();
                        }
                        break;
                    }
                }
                errorTxt.Text = "Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные";
            }
            else
            {
                errorTxt.Text = "Пожалуйста, заполните все поля";
            }
        }
    }
}