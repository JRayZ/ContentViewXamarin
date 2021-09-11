using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewXamarin.Models
{
    public class MenuOption
    {
        public MenuOption(string picturePath, int countPlaces, string title)
        {
            PicturePath = picturePath;
            CountPlaces = countPlaces;
            Title = title;
        }

        public string PicturePath { get; }
        public int CountPlaces { get; }
        public string Title { get; }
    }
}
