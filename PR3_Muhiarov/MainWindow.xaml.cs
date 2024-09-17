using System;
using System.Collections.Generic;
using System.Configuration;
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
using static PR3_Muhiarov.MainWindow;

namespace PR3_Muhiarov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<User> users = new List<User>();
        public static int[] arr;

        public MainWindow()
        {
            InitializeComponent();
        }
        public class User
        {
            private int _Id;
            private string _Name;
            private string _Password;

            public int Id 
            {
                get 
                {
                    return _Id; 
                } 
                set 
                { 
                    _Id = value; 
                } 
            }
            public string Name { get { return _Name; } set { _Name = value; } }
            public string Password { get { return _Password;} set { _Password = value; } }
        }
        private static int [] Buble(int[] arr)
        {
            var list = users.ToList();
            users.Where(w => w.Id == arr[1]).ToList();
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User
            {
                Id = Convert.ToInt32(t1.Text),
                Name = t2.Text,
                Password = t3.Text,
            });

            foreach (var item in users)
            {
                Lb.Items.Add(item);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            users.Clear();
            Lb.Items.Clear();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Lb.Items.Clear();
            users.Sort();
            foreach (var item in users)
            {
                Lb.Items.Add(item);
            }
        }
    }
}
