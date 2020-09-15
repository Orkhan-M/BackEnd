using backendproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeRight> NoticeRights { get; set; }
        public Choose Choose { get; set; }
        public List<Event> Events { get; set; }
    }
}
