
using AlbumApi.Data;
using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlbumApi.Controllers
{
    [ApiController]
    [Route("Album")]
    public class AlbumController : ControllerBase
    {
        private AlbumContext _context;
        private IMapper _mapper;

        public AlbumController(AlbumContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ReadingAlbumDto> BuscarValores([FromQuery] int skip = 0, int take = 0)
        {

            return _mapper.Map<List<ReadingAlbumDto>>(_context.album.Include(x => x.Musicas).Skip(skip).Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult BuscarAlbumId(int id)
        {
            var albumDto = _context.album.Include(a => a.Musicas).FirstOrDefault(a => a.Id == id);
            if (albumDto == null) return NotFound();
            var RetornoAlbumDto = _mapper.Map<Album>(albumDto);
            return Ok(RetornoAlbumDto);
        }

        [HttpPost]
        public void CreateAlbum([FromBody] CreateAlbumDto albumDto)
        {
            // Vai criar um objeto baseado no mapeamento e a transformação do Albumdto para album
            Album album = _mapper.Map<Album>(albumDto);
            _context.album.Add(album);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]

        public IActionResult removerId(int id)
        {
            var albumDto = _context.album.FirstOrDefault(a => a.Id == id);
            if (albumDto == null) return NotFound();
            _context.Remove(albumDto);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UpdateAlbum updateAlbumDto)
        {
            var albumAtualizado = _context.album.FirstOrDefault(x => x.Id == id);

            if (albumAtualizado == null)
            {
                return NotFound();
                Console.WriteLine("Falhou aqui");
            }
            _mapper.Map(updateAlbumDto, albumAtualizado);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]

        public IActionResult AtualizarParte(int id, JsonPatchDocument<UpdateAlbum> patch)
        {
            var updateAlbum = _context.album.FirstOrDefault(x => x.Id == id);
            if (updateAlbum == null) return NotFound();


            var AlbumParaAtualizar = _mapper.Map<UpdateAlbum>(updateAlbum);
            patch.ApplyTo(AlbumParaAtualizar, ModelState);

            if (!TryValidateModel(AlbumParaAtualizar))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(AlbumParaAtualizar, updateAlbum);
            _context.Update(updateAlbum);
            return NoContent();
        }

    }
}
