using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;

namespace AlbumApi.Profiles
{
    public class MusicaProfile : Profile
    {
        public MusicaProfile()
        {
            CreateMap<CreateMusicaDto, Musica>();
            CreateMap<Musica, ReadingMusicaDto>();
            CreateMap<UpdateMusicaDto, Musica>();
            CreateMap<Musica, UpdateMusicaDto>();

        }
    }
}
