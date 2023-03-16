using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls.ConversationalUI;

namespace ClientWPF
{
    public class MessageConverter : IMessageConverter
    {
        public MessageBase ConvertItem(object item)
        {
            var messageModel = (TextMessageModel)item;
            return new TextMessage(messageModel.Author, messageModel.Text, messageModel.CreationDate);
        }

        public object ConvertMessage(MessageBase message)
        {
            var textMessage = (TextMessage)message;
            return new TextMessageModel()
            {
                Author = textMessage.Author,
                Text = textMessage.Text,
                CreationDate = textMessage.CreationDate
            };
        }
    }
}
