using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp11
{
    class song
    {
        public string title;
        public song(string title)
        {
            this.title = title;
        }
    }
    class playlist
    {
        public string name;
        public List<song> songs = new List<song>();

        public playlist(string name)
        {
            this.name = name;
        }
        public void addSong(song song)
        {
            songs.Add(song);
        }
        public void display()
        {
            Console.WriteLine("playlist : " + name);
            foreach(song song in songs)
            {
                Console.WriteLine(song.title);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            song s1 = new song("janan");
            song s2 = new song("stargy");

            playlist p1 = new playlist("my favrt");
            p1.addSong(s1);
            p1.addSong(s2);

            p1.display();
        }
    }
}
