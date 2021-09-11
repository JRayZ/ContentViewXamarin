using System;
using System.Collections.Generic;
using System.Text;
using ContentViewXamarin.Models;

namespace ContentViewXamarin.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; }
        public MenuOption FreeDinningMenuOption { get; }
        public MenuOption CafesMenuOption { get; }
        public MenuOption NearbyMenuOption { get; }
        public MenuOption FastFoodsMenuOption { get; }
        public MenuOption FeaturedFoodsMenuOption { get; }
        public HomeViewModel()
        {
            BarAndHotelsMenuOption = new MenuOption("Bars & Hotels", "BarsIcon.png", 50);
            FreeDinningMenuOption = new MenuOption("Free Dinning", "FreeDiningIcon.png", 25);
            CafesMenuOption = new MenuOption("Cafes", "CafeIcon.png", 38);
            NearbyMenuOption = new MenuOption("Nearby", "NearbyIcon.png", 24);
            FastFoodsMenuOption = new MenuOption("Fast Foods", "FastFoodIcon.png", 19);
            FeaturedFoodsMenuOption = new MenuOption("Featured Foods", "FeaturedFoodIcon.png", 41);
        }
    }
}
