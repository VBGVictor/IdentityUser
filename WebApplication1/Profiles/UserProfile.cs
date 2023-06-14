using AutoMapper;
using WebApplication1.Data.DTO_s;
using WebApplication1.Models;

namespace WebApplication1.Profiles
{
    public class UserProfile : Profile
    {

        public UserProfile() 
        {

            CreateMap<CreateUserDto, User>();
        
        }


    }
}
