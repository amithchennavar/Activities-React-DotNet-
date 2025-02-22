
using System.Diagnostics;
using AutoMapper;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        // this is where we add our profiles
        public MappingProfiles()
        {
            CreateMap<Activity,Activity>();
        }
    }
}