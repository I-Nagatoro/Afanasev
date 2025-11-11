using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Afanasev;

public partial class AdminWindow : Window
{
    public AdminWindow()
    {
        InitializeComponent();
    }

    private void EditOldUser_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var EditUserWin = new EditUserWindow();
        EditUserWin.Show();
        this.Close();
    }

    private void AddNewUser_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var AddUserWin = new AddUserWindow();
        AddUserWin.Show();
        this.Close();
    }

    private void Exit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var MainWin = new MainWindow();
        MainWin.Show();
        this.Close();
    }
}