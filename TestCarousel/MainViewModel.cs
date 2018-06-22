using System;
using MvvmHelpers;

namespace TestCarousel
{
    public class MainViewModel : BaseViewModel
    {
        private DashboardStats stats;
        public DashboardStats Stats
        {
            get => stats;
            set
            {
                SetProperty(ref stats, value);
            }
        }
    }

    public class DashboardStats
    {
        public int Count1 { get; set; }
        public int Count2 { get; set; }
        public int Count3 { get; set; }
        public int Count4 { get; set; }

        public int Count5 { get; set; }
        public int Count6 { get; set; }
        public int Count7 { get; set; }
        public int Count8 { get; set; }
    }
}
