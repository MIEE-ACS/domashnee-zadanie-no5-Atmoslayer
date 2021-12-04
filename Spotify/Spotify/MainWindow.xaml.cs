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

    
    public class Song
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public double Length { get; set; }
        public int Year { get; set; }

        
        public Song()
        {
            Author = "";
            Name = "";
            Album = "";
            Length = 0;
            Year = 0;
        
    }
        
        public void AddSong(string a, string b, string c, double d, int e)
        {
            Author = a;
            Name = b;
            Album = c;
            Length = d;
            Year = e;
        }
        

    }


    public partial class MainWindow : Window

    {

        Song[] Playlist = new Song[7];




        public MainWindow()
        {
            InitializeComponent();

            

            Playlist[0] = new Song();
            Playlist[1] = new Song();
            Playlist[2] = new Song();
            Playlist[3] = new Song();
            Playlist[4] = new Song();
            Playlist[5] = new Song();
            Playlist[6] = new Song();

            Playlist[0].AddSong("Motionless in White", "Another Life", "Disguise", 3.25, 2020);
            Playlist[1].AddSong("We Butter The Bread With The Butter","20km/h","Das Album",3.18,2021);
            Playlist[2].AddSong ("Эпидемия","Возвращение Корвина","Призраки и тени",5.41,2021);
            Playlist[3].AddSong ("Fullmoon", "Sonata Arctica", "Ecliptica Revisited 15th Anniversary",5.12,2014 );
            Playlist[4].AddSong ("GONE.Fludd","Тени Хиросимы", "DIGITAL FANTAZY", 2.14,2021 );
            Playlist[5].AddSong ("Metallica","Seeak and Destroy","Kill 'Em All",6.55,1983 );
            Playlist[6].AddSong ("Parkway Drive","Prey","Reverence",4.19,2018 );

           

            Tb1.Text += "Автор/Название/Альбом/Длительность/Год/";
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
        
        
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            string usAuthor = Tb2.Text;
            bool flag = false;
            
            for (int i = 0; i < 7; i++)
            {

                if (usAuthor == Playlist[i].Author)
                {
                    Tb1.Text = "Песни от этого исполнителя: ";
                    Tb1.Text += "\n";
                    Tb1.Text += "\n";
                    Tb1.Text += "Автор/Название/Альбом/Длительность/Год/";
                    Tb1.Text += "\n";
                    Tb1.Text += "\n";
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
                    flag = true;
                }
            
            
            }
            if (flag == false)
            {
                Tb1.Text = "Совпадения не найдены. Проверьте правильность введённых данных";
            }
        
        Bt1.IsEnabled = false;


        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            Bt1.IsEnabled = true;
            Bt3.IsEnabled = true;
            Tb2.Text = "";
            Tb3.Text = "";
            Tb1.Text = "Автор/Название/Альбом/Длительность/Год/";
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

        
        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            string userdata = Tb3.Text;
            double usLengt1h = 0;

            try
            {
                usLengt1h = double.Parse(userdata);

                if (usLengt1h <= 0)
                {
                    Tb1.Text = "Отрицательное время это круто, но положительное лучше";
                    Bt3.IsEnabled = false;
                }
                else
                {

                    bool flag = false;

                    Tb1.Text = "Песни, длительность которых привышает введённое значение: ";
                    Tb1.Text += "\n";
                    Tb1.Text += "\n";
                    Tb1.Text += "Автор/Название/Альбом/Длительность/Год/";
                    Tb1.Text += "\n";
                    Tb1.Text += "\n";

                    for (int i = 0; i < 7; i++)
                    {

                        if (usLengt1h < Playlist[i].Length)
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
                            flag = true;
                        }


                    }
                    if (flag == false)
                    {
                        Tb1.Text = "Совпадения не найдены. Проверьте правильность введённых данных";
                    }
                    Bt3.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                Tb1.Text = "Проверьте правильность введённых данных";
                Bt3.IsEnabled = false;
            }

            
        }
    
    
    
    
    
    
    
    
    
    }
}
