using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Models;

namespace MyApp.Pages.Books
{
    public class IndexModel : PageModel
    {
        //private readonly IMapper _mapper;

        //public IndexModel(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        public BookViewModel BookInfo { get; set; }

        public void OnGet()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Book, BookViewModel>();
            });

            var mapper = config.CreateMapper();

            var book = new Book
            {
                Id = 1,
                Name = "Learning ASP.NET Core MVC",
                DatePublished = DateTime.Now,
                Price = 100,
                UserId = 125,
                TimeCreated = DateTime.Now
            };

            BookInfo = mapper.Map<Book, BookViewModel>(book);

        }
    }
}
