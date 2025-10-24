using System.Windows.Controls;
using System.Windows.Input;

namespace Interface_Klimov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        public Models.Users ThisUser;
        
        public Users(Models.Users User)
        {
            InitializeComponent();
            ThisUser = User;
            FIO.Text = User.FIO;
        }

        private void SelectUser(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.SelectUser(ThisUser);
        }
    }
}
