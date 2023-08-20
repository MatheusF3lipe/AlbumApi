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
            CreateMap<Album, ReadingAlbumDto>().ForMember(musicadt => musicadt.Musicas, opt => opt.MapFrom(Album => Album.Musicas));
            CreateMap<UpdateAlbum, Album>();
        }
    }
}
