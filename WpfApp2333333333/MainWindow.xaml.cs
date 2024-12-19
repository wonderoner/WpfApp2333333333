using System.Windows;

namespace WpfApp2333333333
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            InitializeProducts();
            ProductListBox.ItemsSource = products;
        }
        private void InitializeProducts()
        {
            products = new List<Product>
            {
                new Product { Name = "Товар 1", Description = "Описание товара 1", Manufacturer = "Производитель 1", Price = 100.00m, Stock = 10 },
                new Product { Name = "Товар 2", Description = "Описание товара 2", Manufacturer = "Производитель 2", Price = 200.00m, Stock = 5 },
                new Product { Name = "Товар 3", Description = "Описание товара 3", Manufacturer = "Производитель 3", Price = 150.00m, Stock = 20 }
            };
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product
            {
                Name = "Товар",
                Description = "Крутой товар",
                Manufacturer = "Крутой произв",
                Price = 250.00m,
                Stock = 15
            };

            products.Add(newProduct);
            ProductListBox.Items.Refresh();
        }
    }
}



public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Manufacturer} - {Price:C} - Остаток: {Stock}";
    }
}
