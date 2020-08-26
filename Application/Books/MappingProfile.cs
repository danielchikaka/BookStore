using AutoMapper;
using Domain;

namespace Application.Books {
    public class MappingProfile : Profile {
        public MappingProfile () {
            CreateMap<Book, BookDto> ();
            // CreateMap<UserBook, AttendeeDto> ()
            //     .ForMember (d => d.Username, o => o.MapFrom (s => s.AppUser.UserName))
            //     .ForMember (d => d.DisplayName, o => o.MapFrom (s => s.AppUser.DisplayName));
        }
    }
}