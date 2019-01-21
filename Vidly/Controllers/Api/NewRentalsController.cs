using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No Movies Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
                return BadRequest("Customer Id is invalid");

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("One or more MoviesIds are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumebrAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumebrAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rental.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }

    }
}
