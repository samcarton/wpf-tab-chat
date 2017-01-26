using System.Collections.ObjectModel;
using System.Windows;

namespace TabChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = CreateChatManager();
        }

        // Create the chat manager with some prepopulated chat messages
        ChatManager CreateChatManager()
        {
            return new ChatManager
            {
                ChatHistories = new ObservableCollection<ChatHistory>(
                    new[] {
                    new ChatHistory {Sender= "Bob", Receiver = "Alice", Messages = CreateMessages("Bob", "Alice") },
                    new ChatHistory {Sender= "X", Receiver = "Y", Messages = CreateMessages("X", "Y") },
                    new ChatHistory {Sender= "Foo", Receiver = "Bar", Messages = CreateMessages("Foo", "Bar") },
                    })
            };
        }

        ObservableCollection<string> CreateMessages(string sender, string receiver)
        {
            return new ObservableCollection<string>(new[] { $"Hi {receiver}, wasup", $"Yeah not much {sender}", "Ok" });
        }
    }
}
