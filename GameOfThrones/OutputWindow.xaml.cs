using GameOfThrones.Models;
using System.Windows;
using System.Windows.Media;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public OutputWindow()
        {
            InitializeComponent();
        }

        public void ShowDescription(Show character)
        {
            var converter = new ImageSourceConverter();
            portraitImage.Source = (ImageSource)converter.ConvertFromString(character.Image);

            nameTextBlock.Text += character?.Name ?? "no data";
            fatherTextBlock.Text += character?.Father ?? "no data";
            ageTextBlock.Text += character.Age.AgeAge?.ToString() ?? "no data";
            firstSeenTextBlock.Text += character?.FirstSeen ?? "no data";
            aliveTextBlock.Text += character.Alive == true ? "Yes" : "No";
            actorTextBlock.Text += character?.Actor ?? "no data";
        }
    }
}
