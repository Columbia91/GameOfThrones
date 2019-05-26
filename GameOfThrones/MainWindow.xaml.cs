using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GameOfThrones.Models;
using GameOfThrones.Services;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Media;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Information information = GotShowApi.GetInformation();
        private List<Show> filteredCharacters;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            filteredCharacters = information.Show;
            charactersListBox.ItemsSource = filteredCharacters;
        }

        private void WantedCharacterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string originalText = wantedCharacterTextBox.Text;
            string upper = originalText.ToUpper();
            string lower = originalText.ToLower();

            filteredCharacters = null;
            filteredCharacters = (from personage in information.Show
                                    where
                                    personage.Name.StartsWith(lower)
                                    || personage.Name.StartsWith(upper)
                                    || personage.Name.Contains(originalText)
                                    select personage).ToList();

            charactersListBox.ItemsSource = filteredCharacters;
        }

        private void CharactersListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            var character = filteredCharacters[charactersListBox.SelectedIndex];
            window.ShowDescription(character);
            window.ShowDialog();
        }

        private void WantedCharacterTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (wantedCharacterTextBox.Text == "Поиск...")
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = string.Empty;
                textBox.GotFocus -= WantedCharacterTextBox_GotFocus;
                textBox.Foreground = Brushes.LightGray;
            }
        }
    }
}
