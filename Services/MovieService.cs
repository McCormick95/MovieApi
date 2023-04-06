using System.Collections.Generic;
using System.Collections;
using MovieApi.Models;
using MovieApi.Repository;

namespace MovieApi.Services{
    public class MovieService : IMovieService{

        private IMovieRepository _repo;

        public MovieService(IMovieRepository repo){
            _repo = repo;
        }

        public IEnumerable<Movie> GetMovies(){
            IEnumerable<Movie> myList = _repo.GetAll();
            
            return myList;
        }
    }
}