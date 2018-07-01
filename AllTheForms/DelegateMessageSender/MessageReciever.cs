using System;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms
{
    public class MessageReciever
    {
        MessageSender messageSender;
        RichTextBox messageRichTextBox;

        public MessageReciever(MessageSender messageSender, RichTextBox messageRichTextBox)
        {
            this.messageSender = messageSender;
            this.messageRichTextBox = messageRichTextBox;

            //1. subscribe to the messageSender's messageAvailable
            messageSender.messageAvailable += new EventHandler(OnMessageAvailable);

        }

        //2. this will call when a message is available
        private void OnMessageAvailable(object sender, EventArgs e)
        {
            messageRichTextBox.Text = messageSender.getMessage();
        }
    }
}