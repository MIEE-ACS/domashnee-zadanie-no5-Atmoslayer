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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;


namespace Spotify
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Song[] Playlist = new Song[7];

            Playlist[0] = new Song { Author = "Motionless in White", Name = "Another Life", Album = "Disguise", Length = 3.25, Year = 2020 };
            Playlist[1] = new Song { Author = "We Butter The Bread With The Butter", Name = "20km/h", Album = "Das Album", Length = 3.18, Year = 2021 };
            Playlist[2] = new Song { Author = "Эпидемия", Name = "Возвращение Корвина", Album = "Призраки и тени", Length = 5.41, Year = 2021 };
            Playlist[3] = new Song { Author = "Fullmoon", Name = "Sonata Arctica", Album = "Ecliptica Revisited 15th Anniversary", Length = 5.12, Year = 2014 };
            Playlist[4] = new Song { Author = "GONE.Fludd", Name = "Тени Хиросимы", Album = "DIGITAL FANTAZY", Length = 2.14, Year = 2021 };
            Playlist[5] = new Song { Author = "Metallica", Name = "Seeak and Destroy", Album = "Kill 'Em All", Length = 6.55, Year = 1983 };
            Playlist[6] = new Song { Author = "Parkway Drive", Name = "Prey", Album = "Reverence", Length = 4.19, Year = 2018 };
        }

        public void Bt1_Click(object sender, RoutedEventArgs e, Song[] Playlist)
        {




            Tb1.Text += "Автор/Название/Альбом/Длительность/Длительность/Год/";
            Tb1.Text += "\n";
            Tb1.Text += "\n";

            for (int i = 0; i < 7; i++)
            {



                Tb1.Text += Playlist[i].Author;
                Tb1.Text += "/";
                Tb1.Text += Playlist[i].Name;
                Tb1.Text += "/";
                Tb1.Text += Playlist[i].Album;
                Tb1.Text += "/";
                Tb1.Text += Playlist[i].Length.ToString();
                Tb1.Text += "/";
                Tb1.Text += Playlist[i].Year.ToString();
                Tb1.Text += "/";
                Tb1.Text += "\n";
                Tb1.Text += "\n";
            }


        }



        public class Song
        {
            public string Author { get; set; }
            public string Name { get; set; }
            public string Album { get; set; }
            public double Length { get; set; }
            public int Year { get; set; }

        }
    }
}
