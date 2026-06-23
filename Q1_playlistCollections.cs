using System;
using System.Collections.Generic;
using System.Text;
//Create a menu-driven program for creating a playlist to show song index and title.
//Collections
namespace JUNE_080626
{
    class Song
    {
        public string Title;
        
        public Song(string title)
        {
            Title = title;
        }
    }
    internal class Q1_playlistCollections
    {
        public static void Run()
        {
            List<Song> playlist = new List<Song>();

            int choice;

            do
            {
                Console.WriteLine("\n----Playlist Menu----");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Display Playlist");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter song title: ");
                        string title = Console.ReadLine();

                        playlist.Add(new Song(title));

                        Console.WriteLine("Song added successfully.");
                        break;

                    case 2:
                        if (playlist.Count == 0)
                        {
                            Console.WriteLine("Playlist is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nPlaylist:");

                            for (int i = 0; i < playlist.Count; i++)
                            {
                                Console.WriteLine(
                                    (i + 1) + ". " +
                                    playlist[i].Title);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting..");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 3);
        }
    }
}
