using Afanasev.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Linq;

namespace Afanasev;

public partial class EditUserWindow : Window
{
    public int user_id;
    public EditUserWindow()
    {
        InitializeComponent();
        LoadUsers();
        LoadRoles();
    }

    private void EditUser_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var newLogin = loginTxt.Text;
        var newPassword = passwordTxt.Text;
        using var context = new Db500Context();
        var usersLogin = context.Users.Select(x=>x.Login).ToList();

        usersLogin.Remove(context.Users.Where(x => x.UserId == user_id).Select(x => x.Login).First());
        if (!usersLogin.Contains(newLogin))
        {

            User newUser = context.Users.Where(x => x.UserId == user_id).FirstOrDefault();
            newUser.Login = newLogin;
            newUser.Password = newPassword;
            newUser.RoleId = context.Roles.Where(x => x.RoleName == RoleCombo.SelectedItem.ToString()).Select(x => x.RoleId).First();
            context.SaveChanges();
            var EventWin = new EventWindow("Пользователь успешно обновлён");
            EventWin.Show();
        }
        else
        {
            ErrorTxt.Text = "Пользователь с данным логином уже существует";
        }
    }

    private void Back_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var admWin = new AdminWindow();
        admWin.Show();
        this.Close();
    }

    private void UserSelect_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        using var context = new Db500Context();
        var loginChanged = UserSelect.SelectedItem;
        var user = context.Users.Where(x => x.Login == loginChanged).FirstOrDefault();
        user_id=user.UserId;
        loginTxt.Text = user.Login;
        passwordTxt.Text = user.Password;
        RoleCombo.SelectedIndex = user.RoleId-1;
    }

    public void LoadUsers()
    {
        using var context = new Db500Context();
        var users = context.Users.Select(x=>x.Login).ToList();
        UserSelect.ItemsSource = users;
    }

    public void LoadRoles()
    {
        using var db = new Db500Context();
        var Roles = db.Roles.Select(x => x.RoleName).ToList();
        RoleCombo.ItemsSource = Roles;
    }
}