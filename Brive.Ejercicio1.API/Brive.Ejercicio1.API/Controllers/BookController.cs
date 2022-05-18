using Brive.Ejercicio1.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brive.Ejercicio1.API.Controllers
{
    [EnableCors("Ejercicio1API")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public List<Book> books = new List<Book>();

        public BookController()
        {
            for (int i = 0; i <= 10; i++)
            {
                books.Add(new Book
                {
                    Id = i + 1,
                    title = $"title {i + 1}",
                    editorial = $"editorial {i + 1}",
                    pages = 150 + 1,
                    CreateDate = DateTime.UtcNow
                });
            }
        }
        //apibase/controllador/endpoint
        [HttpGet]
        [Route("books")]
        public ActionResult<List<Book>> GetAllBooks()
        {
            return StatusCode(StatusCodes.Status200OK, books);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, books.Where(book => book.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult<Book> SavePerson([FromBody] Book book)
        {
            return StatusCode(StatusCodes.Status200OK, book);
        }

        [HttpPut]
        public ActionResult<Book> EditedPerson([FromBody] Book book)
        {
            Book editedBook = books.Where(x => x.Id == book.Id).FirstOrDefault();
            if (editedBook == null)
                return StatusCode(StatusCodes.Status400BadRequest, editedBook);

            book.title = "Titulo Editado";
            book.editorial = "Editorial editada";
            book.pages = 180;
            book.CreateDate = editedBook.CreateDate;
          
            return StatusCode(StatusCodes.Status200OK, book);
        }

        [HttpDelete]
        public ActionResult<List<Book>> DeletePerson([FromBody] int id)
        {
            return StatusCode(StatusCodes.Status200OK, books.Where(book => book.Id != id));
        }

    }
}
