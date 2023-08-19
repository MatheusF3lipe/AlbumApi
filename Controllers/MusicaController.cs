using AlbumApi.Data;
using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AlbumApi.Controllers
{
    [ApiController]
    [Route("Musica")]
    public class MusicaController : Controller
    {

        private IMapper _mapper;
        private AlbumContext _context;

        public MusicaController(IMapper mapper, AlbumContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public IActionResult CriaMusica([FromBody] CreateMusicaDto musicaDto)
        {
            Musica musica = _mapper.Map<Musica>(musicaDto);
            _context.musica.Add(musica);
            _context.SaveChanges();
            return Ok(musica);
        }

        [HttpGet]
        public IEnumerable<ReadingMusicaDto> retonoMusica()
        {
            return _mapper.Map<List<ReadingMusicaDto>>(_context.musica);
        }

    };
}