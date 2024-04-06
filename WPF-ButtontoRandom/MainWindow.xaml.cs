using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_ButtontoRandom;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_MouseDown(object sender, MouseButtonEventArgs e)
    {
        Button button = sender as Button;
        if(e.ChangedButton == MouseButton.Right)
        {
            Title = button.Content.ToString();    
            button.Visibility = Visibility.Collapsed;
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        Random random = new();
        SolidColorBrush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
        button.Background = brush;
        MessageBox.Show($"Button's color code -> {brush}");
    }
}