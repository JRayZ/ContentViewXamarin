using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewXamarin.Models
{
    class MenuOption
    {
        public MenuOption(string title, int countPlaces, string picturePath)
        {
            Title = title;
            CountPlaces = countPlaces;
            PicturePath = picturePath;
        }

        public string Title { get; }
        public int CountPlaces { get; }
        public string PicturePath { get; }
    }
}
