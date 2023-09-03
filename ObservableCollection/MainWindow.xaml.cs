using System.Windows;
using System.Collections;
using System.Collections.ObjectModel;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            Entryes = new ObservableCollection<string>(new string[] { "No ", "Money", "No", "Honey" });
            InitializeComponent();

        }

        private ObservableCollection<string> entryes;

        public ObservableCollection<string> Entryes 
        { 
            get { return entryes; } 
            set { entryes = value; } 
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entryes.Add(txtEntry.Text);
            txtEntry.Clear();
            txtEntry.Focus();
        }

        private void BtnClr_Click(object sender, RoutedEventArgs e)
        {
            Entryes.Clear();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {

            Entryes.Remove(lvEntries.SelectedItem.ToString());

        }
    }
}
