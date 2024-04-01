using System;
using System.Windows;

namespace WpfDemoApp;

/// <summary>
/// Interaction logic for MyDialog.xaml
/// </summary>
public partial class MyHelloWindow : Window
{
    private int[] items = new int[10_000_000];
    private FakePublisher? _fakePublisher;

    public MyHelloWindow()
    {
        InitializeComponent();
    }

    public void SubscribeFakePublisher(FakePublisher publisher)
    {
        _fakePublisher = publisher;
        _fakePublisher.PublishEvent += EventPublished;
    }

    public void EventPublished(object? sender, EventArgs e)
    {
    }

    private void OnClose(object sender, EventArgs e)
    {
    }
}
