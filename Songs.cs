using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Atributes
{
    internal class Songs
    {
        public string title;
        public string artist;
        public string album;
        public int duration;

        public static int songCount = 0;

        public Songs(String atitle,String aartist ,String aalbum, int aduration)
        {
            title = atitle;
            artist = aartist;
            album = aalbum; 
            duration = aduration;
            songCount++; //increment song count
        }

        
    }
}
