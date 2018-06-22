using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestCarousel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            

            var viewModel = new MainViewModel
            {
                Stats = new DashboardStats
                {
                    Count1 = 111,
                    Count2 = 222,
                    Count3 = 333,
                    Count4 = 444,
                    Count5 = 555,
                    Count6 = 666,
                    Count7 = 777,
                    Count8 = 888
                }
            };
            BindingContext = viewModel;

            InitializeComponent();
        }
    }
}
