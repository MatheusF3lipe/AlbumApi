using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;

namespace AlbumApi.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<CreateAlbumDto, Album>().ReverseMap();
        }
    }
}
