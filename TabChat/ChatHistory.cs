using System.Collections.ObjectModel;

namespace TabChat
{
    public class ChatHistory
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public ObservableCollection<string> Messages { get; set; }
    }
}
