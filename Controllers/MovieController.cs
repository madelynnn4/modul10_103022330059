using System.Net.NetworkInformation;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Mvc;

namespace modul10_103022330059.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static readonly List<Movie> movieLists = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins, Morgan Freeman, Bob Gunton"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola",  new List<string>{"Marlon Brando, Al Pacino, James Caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan",  new List<string>{"Christian Bale, Heath Ledger, Aaron Eckhart"}, "TWhen a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieLists;
        }
        [HttpGet("{idx}")]
        public Movie Get(int idx)
        {
            return movieLists[idx];
        }
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            movieLists.Add(movie);
        }
        [HttpDelete("{idx}")]
        public void Delete(int idx)
        {
            movieLists.RemoveAt(idx);
        }
    }
}
