using System;
using System.Collections.Generic;
using System.Text;
using ContentViewXamarin.Models;

namespace ContentViewXamarin.ViewModels
{
    class HomeViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; }
        public MenuOption FreeDinningMenuOption { get; }
        public MenuOption CafesMenuOption { get; }
        public MenuOption NearbyMenuOption { get; }
        public MenuOption FastFoodsMenuOption { get; }
        public MenuOption FeaturedFoodsMenuOption { get; }
        public HomeViewModel()
        {
            BarAndHotelsMenuOption = new MenuOption("BarsIcon.png", 50, "Bars & Hotels");
            FreeDinningMenuOption = new MenuOption("FreeDinningIcon.png", 25, "Free Dinning");
            CafesMenuOption = new MenuOption("CafeIcon.png", 38, "Cafes");
            NearbyMenuOption = new MenuOption("NearbyIcon.png", 24, "Nearby");
            FastFoodsMenuOption = new MenuOption("FastFoodIcon.png", 19, "Fast Foods");
            FeaturedFoodsMenuOption = new MenuOption("FeaturedFoodIcon.png", 41, "Featured Foods");
        }
    }
}
