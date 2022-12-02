using System;
using System.Collections.ObjectModel;
using ScenarioDays.Sample2.Models;

namespace ScenarioDays.Sample2.ViewModels
{
    public class StationsViewModel : BindableObject
    {
        public StationsViewModel()
        {
            Cards = new ObservableCollection<SquareCard>
            {
                new SquareCard
                {
                    Title = "Daddy Yankee Radio",
                    ImageUrl = "http://e-cdn-images.deezer.com/images/artist/5f45206580cde1388f71ccc7f8226768/500x500.jpg"
                },
                new SquareCard
                {
                    Title = "Snoop Dogg Radio",
                    ImageUrl = "https://images.shazam.com/artistart/a18_s800b1b5.jpg"
                }
            };
        }

        public ObservableCollection<SquareCard> Cards { get; }
    }
}
