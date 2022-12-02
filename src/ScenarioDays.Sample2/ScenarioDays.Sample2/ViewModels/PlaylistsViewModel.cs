using System;
using System.Collections.ObjectModel;
using ScenarioDays.Sample2.Models;

namespace ScenarioDays.Sample2.ViewModels
{
    public class PlaylistsViewModel : BindableObject
    {
        public PlaylistsViewModel()
        {
            Cards = new ObservableCollection<SquareCard>
            {
                new SquareCard
                {
                    Title = "Reggaeton",
                    ImageUrl = "https://www.impacrecords.com/wp-content/uploads/2018/04/JBalvinAmbiente-1.png"
                },
                new SquareCard
                {
                    Title = "Indie",
                    ImageUrl = "https://images.genius.com/ba268fbd6e7d58ae46f2fdf632b3493e.600x600x1.jpg"
                }
            };
        }

        public ObservableCollection<SquareCard> Cards { get; }
    }
}
