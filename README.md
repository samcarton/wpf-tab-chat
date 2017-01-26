# wpf-tab-chat
WPF TabControl binding example.

The DataContext for the MainWindow is constructed with some dummy data and set in codebehind (MainWindow.xaml.cs).

- MainWindow.xaml just has a TabControl with the ItemsSource bound to ChatManager.ChatHistories. 
- The ItemTemplate is set to control the look of the Tab Headers. 
- The ContentTemplate is set to control the look of the tab content panels.
