using GymWebApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymWebApp.Models;

namespace GymWebApp.Utility
{
    public static class GymnastUtility
    {
        public static GymViewModel GetViewModel(this Gymnast gymnast)
        {
            var gymnastVM = new GymViewModel()
            {
                Age = gymnast.Age,
                AgeSections = gymnast.AgeSection,
                CreatedAt = gymnast.CreatedAt,
                ID = gymnast.ID,
                Name = gymnast.Name,
                PictureURL = gymnast.PictureURL,
                Apparatuss = gymnast.Apparatus
            };
            return gymnastVM;
        }

        public static List<GymViewModel> GetViewModels(this List<Gymnast> gymnasts)
        {
            var allGymnastsVM = new List<GymViewModel>();
            foreach (var gymnast in gymnasts)
            {
                allGymnastsVM = Add(new GymViewModel()
                {
                    Age = gymnast.Age,
                    AgeSections = gymnast.AgeSection,
                    CreatedAt = gymnast.CreatedAt,
                    ID = gymnast.ID,
                    Name = gymnast.Name,
                    PictureURL = gymnast.PictureURL,
                    Apparatuss = gymnast.Apparatus
                });
            }
            return allGymnastsVM;
            
            }

        private static List<GymViewModel> Add(GymViewModel gymViewModel)
        {
            throw new NotImplementedException();
        }
    }
    }

