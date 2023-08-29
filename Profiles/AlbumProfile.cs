using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;

namespace AlbumApi.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<CreateAlbumDto, Album>();
            CreateMap<Album, ReadingAlbumDto>();
            CreateMap<UpdateAlbumDto, Album>();
            CreateMap<Album, UpdateAlbumDto>();
            CreateMap<Album, ReadNomeAlbum>().ForMember(x => x.Nome, opt => opt.MapFrom(album => album.Titulo));
        }
    }
}
