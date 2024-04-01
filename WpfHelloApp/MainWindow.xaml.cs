using System.Windows;

namespace WpfDemoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private FakePublisher fakePublisher;

    public MainWindow()
    {
        InitializeComponent();

        fakePublisher = new FakePublisher();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MyHelloWindow myDialog = new MyHelloWindow();
        myDialog.Owner = this; // Set the owner to enable proper dialog behavior
        myDialog.SubscribeFakePublisher(fakePublisher);
        myDialog.ShowDialog();
    }
}
