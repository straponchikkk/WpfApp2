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
using WpfApp2.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<user> users = SingleTone.DB.user.Where(user => user.Login == login.Text && user.Password == password.Password).ToList();
            if (users.Count == 1)
            {
                user user = users[0];
                List <string> roles = new List <string>();
                string separator = ",";
                bool addSeparator = false;
                foreach (Role role in user.Role)
                {
                    if (addSeparator)
                        roles += separator;

                    roles = role.Name;

                    addSeparator = true;
                }
                MessageBox.Show($"Здравствуйте,{user.Login}, ваши роли {roles}");
                UsersTable usersTable= new UsersTable();
                Hide();
                usersTable.ShowDialog();
                Show();
            }
            
        }
    }
}
