using ClientWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.ConversationalUI;

namespace ClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChatViewModel ViewModel { get; set; }

        public MainWindow(string name)
        {
            InitializeComponent();

            this.Icon = new BitmapImage(new Uri("pack://application:,,,/images/chat_icon.png", UriKind.RelativeOrAbsolute));
            LoadData(name);
        }
        void LoadData(string name)
        {
            if (name != null && name != string.Empty)
            {


                this.ViewModel = new ChatViewModel(name);

                this.DataContext = this.ViewModel;

                this.myChat.CurrentAuthor = this.ViewModel.CurrentAuthor;
            }
        }


        private void OnPromptClosed(object sender, WindowClosedEventArgs e)
        {
            

        }

        private void RadChat_SendMessage(object sender, Telerik.Windows.Controls.ConversationalUI.SendMessageEventArgs e)
        {
            this.ViewModel.CurrentMessage = e.Message as TextMessage;

            this.ViewModel.SendCurrentMessage();
            //List<TextMessage> sad = ViewModel.AllMessages.ToList();
            //this.DataContext = this.ViewModel;

            var textMessage = new TextMessage(this.myChat.CurrentAuthor, "Some text message", "sent", DateTime.Now);
            textMessage.InlineViewModel.StatusVisibility = Visibility.Visible;
            
            this.myChat.AddMessage(textMessage);


        }       
    }
}
