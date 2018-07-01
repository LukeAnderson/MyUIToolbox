using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms
{
    public partial class DelegateMessageSenderForm : Form
    {

        public MessageSender messageSender;

        public MessageReciever messageReciever1;
        public MessageReciever messageReciever2;
        public MessageReciever messageReciever3;

        public DelegateMessageSenderForm()
        {
            InitializeComponent();

            messageSender = new MessageSender(sendRichTextBox, sendButton);

            messageReciever1 = new MessageReciever(messageSender, recieverRichTextBox1);
            messageReciever2 = new MessageReciever(messageSender, recieverRichTextBox2);
            messageReciever3 = new MessageReciever(messageSender, recieverRichTextBox3);
        }
    }
}
