using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Models;

namespace StudentPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["StudentName"] = "Vu Phan Hoang An";
            ViewData["StudentID"] = "104775412";
            ViewData["Unit"] = "SWE40006 Software Deployment and Evolution";
            ViewData["Skills"] = new[] { "C#", "ASP.NET Core", "Azure", "PHP" };
            return View();
        }

        public IActionResult Music()
        {
            var model = new MusicViewModel
            {
                Genres = new List<string> { "Rock", "Blues", "Jazz", "Dance" },
                Artists = new List<ArtistItem>
                {
                    new() { Name = "Daft Punk", Genre = "Dance" },
                    new() { Name = "Led Zeppelin", Genre = "Rock" },
                    new() { Name = "Al Di Meola", Genre = "Jazz" },
                    new() { Name = "Jeff Beck", Genre = "Jazz-Rock" },
                    new() { Name = "Gary Moore", Genre = "Blues-Rock" },
                    new() { Name = "The Goo Goo Dolls", Genre = "Rock" },
                    new() { Name = "Fleetwood Mac", Genre = "Rock" },
                    new() { Name = "Guns N' Roses", Genre = "Rock" },
                    new() { Name = "Pink Floyd", Genre = "Rock" },
                    new() { Name = "Eric Clapton", Genre = "Blues-Rock" },
                },
                Songs = new List<SongItem>
                {
                    new() { Title = "Iris", Artist = "The Goo Goo Dolls" },
                    new() { Title = "Stairway to Heaven", Artist = "Led Zeppelin" },
                    new() { Title = "Touch", Artist = "Daft Punk" },
                    new() { Title = "November Rain", Artist = "Guns N' Roses" },
                    new() { Title = "Since I've Been Loving You", Artist = "Led Zeppelin" },
                    new() { Title = "Kashmir", Artist = "Led Zeppelin" },
                    new() { Title = "Comfortably Numb", Artist = "Pink Floyd" },
                    new() { Title = "Silver Springs", Artist = "Fleetwood Mac" },
                    new() { Title = "The Loner", Artist = "Gary Moore" },
                    new() { Title = "Black Dog", Artist = "Led Zeppelin" },
                    new() { Title = "Whole Lotta Love", Artist = "Led Zeppelin" },
                    new() { Title = "Parisienne Walkways", Artist = "Gary Moore" },
                    new() { Title = "Cause We've Ended As Lovers", Artist = "Jeff Beck" },
                    new() { Title = "People Get Ready", Artist = "Jeff Beck, Rod Stewart" },
                    new() { Title = "Layla", Artist = "Derek and the Dominos" },
                    new() { Title = "When The Levee Breaks", Artist = "Led Zeppelin" },
                    new() { Title = "Babe I'm Gonna Leave You", Artist = "Led Zeppelin" },
                    new() { Title = "Iron Man", Artist = "Black Sabbath" },
                    new() { Title = "Every Breath You Take", Artist = "The Police" },
                    new() { Title = "Beat It", Artist = "Michael Jackson, Eddie Van Halen" },
                    new() { Title = "Purple Rain", Artist = "Prince and the Revolution" },
                    new() { Title = "Sweet Child O' Mine", Artist = "Guns N' Roses" },
                    new() { Title = "Midnight Tango", Artist = "Al Di Meola" },
                },
                Albums = new List<AlbumItem>
                {
                    new() { Title = "Led Zeppelin IV", Artist = "Led Zeppelin" },
                    new() { Title = "Rumours", Artist = "Fleetwood Mac" },
                    new() { Title = "Use Your Illusions", Artist = "Guns N' Roses" },
                    new() { Title = "Dizzy Up The Girl", Artist = "The Goo Goo Dolls" },
                    new() { Title = "Led Zeppelin II", Artist = "Led Zeppelin" },
                    new() { Title = "Wild Frontier", Artist = "Gary Moore" },
                    new() { Title = "Blow By Blow", Artist = "Jeff Beck" },
                    new() { Title = "Paranoid", Artist = "Black Sabbath" },
                    new() { Title = "OK Computer", Artist = "Radiohead" },
                    new() { Title = "The Dark Side of The Moon", Artist = "Pink Floyd" },
                    new() { Title = "Communique", Artist = "Dire Straits" },
                    new() { Title = "Random Access Memories", Artist = "Daft Punk" },
                    new() { Title = "Van Halen", Artist = "Van Halen" },
                },
            };
            return View(model);
        }
    }
}
