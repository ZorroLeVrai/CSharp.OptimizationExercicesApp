using System;

namespace WpfDemoApp;

public class FakePublisher
{
    public EventHandler<EventArgs>? PublishEvent;

    public void Invoke()
    {
        PublishEvent?.Invoke(this, EventArgs.Empty);
    }
}
