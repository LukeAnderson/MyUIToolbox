using System;
using System.Windows.Forms;

namespace MyUIToolBox
{
    public class MessageSender
    {
        private RichTextBox messageRichTextBox;
        private Button sendButton;

        //step 1. make the event
        public event EventHandler messageAvailable = delegate { };

        public MessageSender(RichTextBox messageRichTextBox, Button sendButton)
        { 
            this.messageRichTextBox = messageRichTextBox;
            this.sendButton = sendButton;

            this.sendButton.Click += new EventHandler(sendButton_Click);//this is also an event.
        }

        //event triggered when the send button is pressed
        private void sendButton_Click(object sender, EventArgs e)
        {
            //step 2. Notifiy subscribers that there is a message available 
            messageAvailable(this, new EventArgs());
        }
        
        //step 3. recievers will be notified and call this to get the message
        public string getMessage()
        {
            return messageRichTextBox.Text;
        }

    }
}