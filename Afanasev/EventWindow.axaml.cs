using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Afanasev;

public partial class EventWindow : Window
{
    public EventWindow()
    {
        InitializeComponent();
    }
    public EventWindow(string msg)
    {
        InitializeComponent();
        EventTxt.Text = msg;
    }

    private void OK_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        this.Close();
    }
}