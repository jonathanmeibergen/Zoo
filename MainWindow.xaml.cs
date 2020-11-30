using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using Zoo.Animals;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Animal> Zoo { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Zoo = new List<Animal>
            {
                new Monkey("Donkey Kong"),
                new Elephant("Jumbo"),
                new Lion("Simba")
            };
            lsZoo.ItemsSource = Zoo;
            //this.DataContext = Zoo;
        }

        public void FeedAnimals(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string btnClicked = btn.Tag.ToString();
            Assembly asm = Assembly.Load("Zoo");
            Type type = asm.GetType($"Zoo.Animals.{btnClicked}");

            var _switch = new Dictionary<Type, Action> {
                { typeof(Monkey), () => Zoo.FindAll(a => a is Monkey).ForEach(m => m.Eat()) },
                { typeof(Elephant), () => Zoo.FindAll(a => a is Elephant).ForEach(e => e.Eat()) },
                { typeof(Lion), () => Zoo.FindAll(a => a is Lion).ForEach(l => l.Eat())},
                { typeof(Animal), () => Zoo.ForEach(a => a.Eat())},
            };

            _switch[type]();

            lsZoo.ItemsSource = null;
            lsZoo.ItemsSource = Zoo;

            //var aa = gvZoo.
                //.ToList().ForEach(x => { 
                //TextBox dp = x.CellTemplate.LoadContent() as TextBox; 
                //                                  dp.GetBindingExpression(TextBox.TextProperty).UpdateTarget(); });

            //List<Animal> animals;
            //switch (btn)
            //{
            //    case Monkey t1:
            //        animals = Zoo.FindAll(a => a is Monkey);
            //        animals.ForEach(a => a.Eat());
            //        break;
            //    case "Elephants":
            //        animals = Zoo.FindAll(a => a.AnimalType == typeof(Monkey).Name);
            //        animals.ForEach(a => a.Eat());
            //        break;
            //    case "Lions":
            //        animals = Zoo.FindAll(a => a.AnimalType == typeof(Monkey).Name);
            //        animals.ForEach(a => a.Eat());
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
