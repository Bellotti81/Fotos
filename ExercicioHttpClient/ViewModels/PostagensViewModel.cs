using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHttpClient.ViewModels
{
    public class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public int userid;
        [ObservableProperty]
        public string title;
        [ObservableProperty]
        public string body;
    }
}
