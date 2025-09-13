using System.Windows;
using System.Windows.Controls;


namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToDoBtn(object sender, RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text;

            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock ToDoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10)
                };
                ToDoList.Children.Add(ToDoItem);
                ToDoInput.Clear();
            }
            else
            {
                MessageBox.Show("⚠️Empty!");
            }
        }
    }
}