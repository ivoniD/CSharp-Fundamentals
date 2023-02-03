using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string tipe = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song NewSong = new Song();
                NewSong.TypeList = tipe;
                NewSong.Name = name;
                NewSong.Time = time;

                songs.Add(NewSong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(s => s.TypeList == command);

                foreach (Song fSong in filteredSongs)
                {
                    Console.WriteLine(fSong.Name);
                }
            }
        }

    }
}
