﻿using Task_PurpleBuzz.Models;

namespace Task_PurpleBuzz.ViewModels.Home
{
    public class HomeIndexVM
    {
        public HomeIndexVM()
        {
            Works = new List<Models.Work>();
        }
        public List<Models.Work> Works { get; set; }
    }
}
