using AutoMapper;
using CoreCodeCamp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile:Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CamViewModel>();
            this.CreateMap<CamViewModel, Camp>();
            this.CreateMap<Talk, TalkViewModel>();
            this.CreateMap<TalkViewModel, Talk>();
        }
    }
}
