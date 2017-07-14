using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3_Structures
{
    struct Song_Albums
    {
        public String albumName;
        public String artist;
        public int yearOfLaunch;
        public String genre;

        public void getValues(String albumNum, String artNum, int yearLaunch, String genreName)
        {
            albumName = albumNum;
            artist = artNum;
            yearOfLaunch = yearLaunch;
            genre = genreName;
        }

        public void displayValues()
        {
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist Name: " + artist);
            Console.WriteLine("Launch Year: " + yearOfLaunch);
            Console.WriteLine("Genre: " + genre);
        }

    }
    class Pr3_Structures
    {
        static void Main(string[] args)
        {
            Song_Albums beatleAlbum = new Song_Albums();
            beatleAlbum.getValues("A hard day's night", "The Beatles", 1964, "Rock");

            Song_Albums bryanAdamsAlbum;
            bryanAdamsAlbum.albumName = "The Best of Me";
            bryanAdamsAlbum.artist = "Brian Adams";
            bryanAdamsAlbum.yearOfLaunch = 1999;
            bryanAdamsAlbum.genre = "Rock";

            beatleAlbum.displayValues();
            bryanAdamsAlbum.displayValues();

            Console.ReadLine();

        }
    }
}
