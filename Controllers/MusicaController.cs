using AlbumApi.Data;
using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
            return _mapper.Map<List<ReadingMusicaDto>>(_context.musica.ToList());
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarMusica(int id, [FromBody] UpdateMusicaDto updateMusica)
        {
            var musicaDt = _context.musica.FirstOrDefault(musica => musica.Id == id);
            if (musicaDt == null) return NotFound();
            _mapper.Map(updateMusica, musicaDt);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPatch("{id}")]
        public IActionResult AtualizarParcialMusica(int id, [FromBody] JsonPatchDocument<UpdateMusicaDto> patch)
        {
            Musica musica = _context.musica.FirstOrDefault(x => x.Id == id);
            if (musica == null) return NotFound();
            // Mapeamento isolado
            var MusicaAtualizada = _mapper.Map<UpdateMusicaDto>(musica);
            patch.ApplyTo(MusicaAtualizada, ModelState);
            if (!TryValidateModel(MusicaAtualizada))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(MusicaAtualizada, musica);
            _context.SaveChanges();
            return Ok(ModelState);
        }
    };
}