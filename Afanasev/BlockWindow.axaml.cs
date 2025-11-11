using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Afanasev;

public partial class BlockWindow : Window
{
    public BlockWindow()
    {
        InitializeComponent();
    }

    private void ExitBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        this.Close();
    }
}