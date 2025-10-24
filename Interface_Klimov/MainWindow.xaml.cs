using Interface_Klimov.Classes;
using System.Windows;
using System.Windows.Input;

namespace Interface_Klimov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UsersContext usersContext = new Classes.UsersContext();
        public MessagesContext messagesContext = new Classes.MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;
        
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            LoadUser();
        }

        private void SendMessages(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (IdSelectUser == -1) return;
                MessagesContext newMessages = new MessagesContext(Message.Text, DateTime.Now, IdSelectUser);
                newMessages.Save();
                Message.Text = "";
                SelectUser(null);
            }
        }

        public void LoadUser()
        {
            foreach (Models.Users User in usersContext.AllUsers)
            {
                ParentUser.Children.Add(new Elements.Users(User));
            }
        }

        public void SelectUser(Models.Users User)
        {
            if (User != null)
            {
                IdSelectUser = usersContext.AllUsers.FindIndex(x => x == User);
            }
            parentMessage.Children.Clear();
            foreach (MessagesContext Messages in MessagesContext.AllMessages.FindAll(x => x.IdUser == IdSelectUser))
            {
                parentMessage.Children.Add(new Elements.Messages(Messages));
            }
            BlockMessage.IsEnabled = true;
        }
    }
}