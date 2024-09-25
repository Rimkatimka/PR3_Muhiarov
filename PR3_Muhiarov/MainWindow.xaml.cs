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
        public static int[] arr;
        public static int i = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arr = new int[42];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0,25);
            }
            foreach (var item in arr)
            {
                Lb.Items.Add(item);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Lb.Items.Clear();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Lb.Items.Clear();
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
            for (int i = 0; i < arr.Length; i++) ;
            foreach (var item in arr)
            {
                Lb.Items.Add(item);
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Lb.Items.Clear();
            Sort(arr, 0, (arr.Length - 1));
            foreach (var item in arr)
            {
                Lb.Items.Add(item);
            }
        }
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                Sort(arr, left, pivot - 1);
                Sort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }
    }
}
