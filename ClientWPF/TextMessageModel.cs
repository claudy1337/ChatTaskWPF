using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls.ConversationalUI;

namespace ClientWPF
{
    public class TextMessageModel
    {
        public string Text { get; set; }
        public Author Author { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
