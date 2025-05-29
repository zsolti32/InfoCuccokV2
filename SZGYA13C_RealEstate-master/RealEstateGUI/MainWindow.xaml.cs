using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using RealEstate;
using static RealEstateGUI.MainWindow;

namespace RealEstateGUI
{
    public partial class MainWindow : Window
    {
        List<Seller> sellers = new List<Seller>();
        List<int> hirdetesek = new List<int>();
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;password=;database=ingatlan";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    "SELECT sellers.id, sellers.name, sellers.phone, COUNT(realestates.sellerId) AS hirdetesek FROM sellers LEFT JOIN realestates ON realestates.sellerId = sellers.id GROUP BY sellers.id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Seller Seller = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        int Hirdetesek = reader.GetInt32(3);

                        sellers.Add(Seller);
                        hirdetesek.Add(Hirdetesek);
                        
                    }
                }
                connection.Close();
            }

            var ingatlanok = sellers.Select(k => k.Name).ToList();
            foreach (var nev in ingatlanok)
            {
                adatokList.Items.Add(nev);
            }
            adatokList.SelectedIndex = 0;

        }

        private void adatokList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            eladoNevLabel.Content = adatokList.SelectedItem;

            var tel = sellers.Where(a => a.Name == adatokList.SelectedItem).Select(a => a.Phone).First();
            eladoTelLabel.Content = $"{tel}";
        }

        private void betoltesBTN_Click(object sender, RoutedEventArgs e)
        {
            var selectedSellerIndex = sellers.FindIndex(s => s.Name == adatokList.SelectedItem);

            int sellerHirdetesekCount = hirdetesek[selectedSellerIndex];

            hirdetesekLabel.Content = $"{sellerHirdetesekCount}";
        }
    }
}