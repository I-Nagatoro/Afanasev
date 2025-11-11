using Afanasev.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Linq;

namespace Afanasev;

public partial class AddUserWindow : Window
{
    public AddUserWindow()
    {
        InitializeComponent();
        LoadRoles();
    }

    private void AddUser_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        using var db = new Db500Context();
        var usersLogin = db.Users.Select(x => x.Login).ToList();
        var login = loginTxt.Text;
        var password = passwordTxt.Text;
        if (usersLogin.Contains(login))
        {
            ErrorTxt.Text = "Пользователь с данным логином уже существует";
        }
        else
        {
            var newUser = new User
            {
                UserId = db.Users.Max(x=>x.UserId)+1,
                Login = login,
                Password = password,
                RoleId = db.Roles.Where(x=>x.RoleName==RoleCombo.SelectedItem.ToString()).Select(x=>x.RoleId).First()
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            var EventWin = new EventWindow("Пользователь успешно добавлен");
            EventWin.Show();
        }
    }

    private void Back_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var admWin = new AdminWindow();
        admWin.Show();
        this.Close();
    }

    public void LoadRoles()
    {
        using var db = new Db500Context();
        var Roles = db.Roles.Select(x=>x.RoleName).ToList();
        RoleCombo.ItemsSource = Roles;
    }
}