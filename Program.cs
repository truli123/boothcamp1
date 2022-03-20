using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace album
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Album myAlbum = new Album();
            myAlbum.Name = "Black Album";
            myAlbum.Performer = " Metallica";
            myAlbum.Year = 1991;
            myAlbum.CountryOrigin = "USA";
            Album myAlbum1 = new Album();

            myAlbum1.Name = "Never Mind";
            myAlbum1.Performer = " Nirvana";
            myAlbum1.Year = 1990;
            myAlbum1.CountryOrigin = "USA";

            Song1 mySong = new Song1();
            Console.WriteLine("{0} {1} {2} {3} ",
            myAlbum.Name, myAlbum.Performer, myAlbum.Year, myAlbum.CountryOrigin);
            //mySong.LeadingSong();
            Console.WriteLine("press any button");
            Console.ReadLine();
            Console.WriteLine("{0} {1} {2} {3} ",
                 myAlbum1.Name, myAlbum1.Performer, myAlbum1.Year, myAlbum1.CountryOrigin);
            mySong.BandSong();
            Console.WriteLine("press any button to continue");
            Console.ReadLine();
        }
    }
    public class Album
    {
        public string Name { get; set; }
        public string Performer { get; set; }
        public int Year { get; set; }
        public string CountryOrigin { get; set; }

    }


    abstract class Song
    {
        public abstract void BandSong();
        public void LeadingSong()
        {
            Console.WriteLine("One");
        }
    }


   /* class Song1 : Song
    {
        public override void BandSong()
        {
            Console.WriteLine("Lithium");
        }
    }*/

}





