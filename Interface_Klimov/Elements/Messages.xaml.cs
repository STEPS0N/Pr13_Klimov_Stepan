using Interface_Klimov.Classes;
using System.Windows.Controls;
using System.Windows.Input;

namespace Interface_Klimov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Messages.xaml
    /// </summary>
    public partial class Messages : UserControl
    {
        public MessagesContext ThisMessage;
        
        public Messages(Classes.MessagesContext messages)
        {
            InitializeComponent();
            ThisMessage = messages;
            Message.Text = messages.Message;
            Date.Text = messages.Create.ToString("dd.MM.yyyy");
        }

        private void DeleteMessage(object sender, MouseButtonEventArgs e)
        {
            ThisMessage.Delete();
            MainWindow.mainWindow.parentMessage.Children.Remove(this);
        }
    }
}
