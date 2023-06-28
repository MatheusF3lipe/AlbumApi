using AlbumApi.Data;
using AlbumApi.Data.Dtos;
using AlbumApi.Models;
using AutoMapper;
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
        public IEnumerable<Album> BuscarValores()
        {

            return _context.album.Include(p => p.Musicas).ToList();
        }



        [HttpGet("{id}")]
        public IActionResult BuscarAlbumId(int id)
        {
            var albumDto = _context.album.FirstOrDefault(a => a.Id == id);
            if (albumDto == null) return NotFound();
            var porra = _mapper.Map<Album>(albumDto);
            return Ok(porra);
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


    }
}
