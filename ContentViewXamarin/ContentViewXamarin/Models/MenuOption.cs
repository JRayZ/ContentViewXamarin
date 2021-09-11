using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewXamarin.Models
{
    public class MenuOption
    {
        public MenuOption(string title, string picturePath, int countPlaces)
        {
            Title = title;
            PicturePath = picturePath;
            CountPlaces = countPlaces;
        }

        public string Title { get; }
        public string PicturePath { get; }
        public int CountPlaces { get; }
    }
}
