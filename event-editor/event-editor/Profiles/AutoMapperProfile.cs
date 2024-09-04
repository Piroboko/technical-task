using AutoMapper;
using event_editor.Entities;
using event_editor.Models.Request;

namespace event_editor.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UserRegister, User>();
        }
    }
}
