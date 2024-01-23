using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_22_Static_Attrribute_ConsoleApp
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;  //increment each time a song is added
        }

        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green day", 2);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin", 5);


            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
