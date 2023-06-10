
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MonkeyPhotosProject.Models;
//using static Java.Util.Jar.Attributes;

namespace MonkeyPhotosProject.ViewModel
{
    public class MainPageViewModel :ViewModelBase
    {
        int count = 0;
        private MonkeyResources _monkey;
        public MonkeyResources monkey {
            get { return _monkey; }
            set { _monkey = value; OnPropertyChanged(); } }
        public MainPageViewModel()
        {
            upButtonCommand = new Command(upButtonPressed);
            downButtonCommand = new Command(downButtonPressed);
            monkey = monkeys[0];
        }

        #region monkey list
        private List<MonkeyResources> monkeys = new List<MonkeyResources>()
        {
           new MonkeyResources("Name: Baboon",
                "Location: Africa & Asia",
                 "Details: Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                 "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
                 "Population: 10000",
               "Latitude: -8.783195",
               "Longitude: 34.508523"),

           new MonkeyResources("Name:Capuchin Monkey",
                 "Location: Central & South America",
                 "Details: The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                 "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
                "Population: 23000",
               "Latitude: 12.769013",
               "Longitude: -85.602364"),

           new MonkeyResources("Name: Blue Monkey",
    "Location: Central and East Africa",
    "Details: The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
    "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg",
    "Population: 12000",
    "Latitude: 1.957709",
    "Longitude: 37.297204"),

           new MonkeyResources("Name: Squirrel Monkey",
    "Location: Central & South America",
    "Details: The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg",
    "Population: 11000",
    "Latitude: -8.783195",
    "Longitude: -55.491477"),

            new MonkeyResources("Name: Golden Lion Tamarin",
    "Location: Brazil",
    "Details: The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
    "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/tamarin.jpg",
    "Population: 19000",
    "Latitude: -14.235004",
    "Longitude: -51.92528"),

            new MonkeyResources("Name: Howler Monkey",
    "Location: South America",
    "Details: Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/alouatta.jpg",
    "Population: 8000",
    "Latitude: -8.783195",
    "Longitude: -55.491477"),
          
            new MonkeyResources("Name: Japanese Macaque",
    "Location: Japan",
    "Details: The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
    "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/macasa.jpg",
    "Population: 1000",
    "Latitude: 36.204824",
    "Longitude: 138.252924"),

            new MonkeyResources("Name: Mandrill",
    "Location: Southern Cameroon, Gabon, and Congo",
    "Details: The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/mandrill.jpg",
    "Population: 17000",
    "Latitude: 7.369722",
    "Longitude: 12.354722"),

            new MonkeyResources("Name: Proboscis Monkey",
    "Location: Borneo",
    "Details: The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
    "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/borneo.jpg",
    "Population: 15000",
    "Latitude: 0.961883",
    "Longitude: 114.55485"),

            new MonkeyResources("Name: Sebastian",
    "Location: Seattle",
    "Details: This little trouble maker lives in Seattle with James and loves traveling on adventures with James and tweeting @MotzMonkeys. He by far is an Android fanboy and is getting ready for the new Nexus 6P!",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/sebastian.jpg",
    "Population: 1",
    "Latitude: 47.606209",
    "Longitude: -122.332071"),

            new MonkeyResources("Name: Henry",
    "Location: Phoenix",
    "Details: An adorable Monkey who is traveling the world with Heather and live tweets his adventures @MotzMonkeys. His favorite platform is iOS by far and is excited for the new iPhone Xs!",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/henry.jpg",
    "Population: 1",
    "Latitude: 33.448377",
    "Longitude: -112.074037"),
            
            new MonkeyResources("Name: Red-shanked douc",
    "Location: Vietnam",
    "Details: The red-shanked douc is a species of Old World monkey, among the most colourful of all primates. The douc is an arboreal and diurnal monkey that eats and sleeps in the trees of the forest.",
    " https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/douc.jpg",
    "Population: 1300",
    "Latitude: 16.111648",
    "Longitude: 108.262122"),

            new MonkeyResources("Name: Mooch",
    "Location: Seattle",
    "Details: An adorable Monkey who is traveling the world with Heather and live tweets his adventures @MotzMonkeys. His favorite platform is iOS by far and is excited for the new iPhone 6s!",
    "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/Mooch.PNG",
    "Population: 1",
    "Latitude: 47.608013",
    "Longitude: -122.335167")
            
        };
        #endregion 
        public ICommand upButtonCommand { get; set; }
        private void upButtonPressed()
        {
            count++;
            if (count >= monkeys.Count) count = 0;
            monkey = monkeys[count];
        }
        public ICommand downButtonCommand { get; set; }
        private void downButtonPressed()
        {
            count--;
            if (count < 0) count = monkeys.Count-1;
            monkey = monkeys[count];
        }

    }

    }

