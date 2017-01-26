using System.Collections.ObjectModel;

namespace TabChat
{
    public class ChatManager
    {
        public ObservableCollection<ChatHistory> ChatHistories { get; set; }
    }
}
