using System;
using System.Collections.ObjectModel;
using ScenarioDays.Sample3.Models;

namespace ScenarioDays.Sample3.ViewModels
{
    public class SneakersViewModel
    {
        public ObservableCollection<Sneakers> sneakers { get; set; }
        public ObservableCollection<SneakerColor> sneakerColor { get; set; }

        public SneakersViewModel()
        {
            sneakers = new ObservableCollection<Sneakers>
            {
                new Sneakers { Name="NMD_R1 candy", Price="162",Picture="sneakersone.png" },
                new Sneakers { Name="NMD_R1 pink white", Price="142",Picture="sneakerstwo.png" },
                new Sneakers { Name="NMD_R1 mint pink", Price="179",Picture="sneakersthree.png" },
                new Sneakers { Name="NMD_R1 white mint", Price="154",Picture="sneakersfour.png" }
            };

            sneakerColor = new ObservableCollection<SneakerColor>
            {
                //new SneakerColor { ColorOption = "#819e94" },
                //new SneakerColor { ColorOption = "#dde5ed" },
                //new SneakerColor { ColorOption = "#d6c2bf" }
          
                new SneakerColor { ColorOption = Color.FromArgb("#819e94") },
                new SneakerColor { ColorOption = Color.FromArgb("#dde5ed") },
                new SneakerColor { ColorOption = Color.FromArgb("#d6c2bf") }
            };
        }
    }
}
