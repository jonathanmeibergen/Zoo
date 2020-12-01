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
using System.Windows.Threading;
using Zoo.Animals;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Dictionary<Animal, string> Zoo { get; set; }
        private List<Animal> Zoo { get; set; }

        private Dictionary<Type, Action> ZooKeeper;

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

            ZooKeeper = new Dictionary<Type, Action> {
                //{ typeof(Elephant), () => Zoo.ToList().FindAll(a => a.Key is Elephant).ForEach(m => m.Key.Eat()) },
                { typeof(Monkey), () => Zoo.FindAll(a => a is Monkey).ForEach(m => m.Eat()) },
                { typeof(Elephant), () => Zoo.FindAll(a => a is Elephant).ForEach(m => m.Eat()) },
                { typeof(Lion), () => Zoo.FindAll(a => a is Lion).ForEach(l => l.Eat())},
                { typeof(Animal), () => Zoo.ToList().ForEach(a => a.Eat()) }
            };
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        //private List<Animal> FindAnimals(Type type)
        //{
        //    return Zoo.FindAll(a => CompareTypes(a.GetType(), type)).ForEach(a => a.Eat());
        //}

        //private bool CompareTypes<T1, T2>(T1 a, T2 b)
        //{
        //    return a.GetType() == b.GetType();
        //}
        private void timer_Tick(object sender, EventArgs e)
        {
            Zoo.ToList().ForEach(a => a.UseEnergy());
            Zoo.ToList().ForEach(a => { if(!a.Alive) { Zoo.Remove(a); } });
            lsZoo.ItemsSource = null;
            lsZoo.ItemsSource = Zoo;
        }

        public void FeedAnimals(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string btnClicked = btn.Tag.ToString();
            Assembly asm = Assembly.Load("Zoo");
            Type type = asm.GetType($"Zoo.Animals.{btnClicked}");

            ZooKeeper[type]();

            lsZoo.ItemsSource = null;
            lsZoo.ItemsSource = Zoo;
            //lsZoo.ItemsSource = Zoo.Keys.ToList();

        }
    }
}
