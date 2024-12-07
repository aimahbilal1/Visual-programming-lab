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
using System.Collections.ObjectModel;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Players { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>();
            PlayersListBox.ItemsSource = Players;
        }
        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Player name cannot be empty!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Players.Contains(playerName))
            {
                MessageBox.Show("This player is already in the team!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Players.Add(playerName);
            PlayerNameTextBox.Clear();
            MessageBox.Show($"{playerName} added to the team!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RemovePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedPlayer = (string)PlayersListBox.SelectedItem;

            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to remove!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Players.Remove(selectedPlayer);
            MessageBox.Show($"{selectedPlayer} removed from the team!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

