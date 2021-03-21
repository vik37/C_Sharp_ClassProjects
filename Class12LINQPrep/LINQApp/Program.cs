using LINQApp.Entities;
using LINQApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FOREACH with LINQ

            //var partOfMovies = new List<Movie>()
            //{
            //    new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
            //    new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
            //    new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
            //};
            ////foreach (var movie in partOfMovies)
            ////{
            ////    Console.WriteLine(movie.Title);
            ////}
            //partOfMovies.ForEach(m => Console.WriteLine(m.Title));

            #endregion


            #region Iterating Dictionary<TKey,TValue> with FOR using LINQ

            var moviesCodes = new Dictionary<int, Movie>()
            {
                {1,  new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 } },
                {2,  new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 } },
                {3,  new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 } }
            };

            for (int i = 0; i < moviesCodes.Count; i++)
            {
                KeyValuePair<int, Movie> movie = moviesCodes.ElementAt(i);
                Console.WriteLine($"Key: {movie.Key}, Value: {movie.Value.Title}");
            }

            #endregion


            #region LINQ in Action - EXAMPLES

            var movies = MoviesHelper.GetAllActionMovies();

            // 1. Find ALL movies with Title starting with 'T'
            var allMoviesTitleStartWithT = movies
                                                .Where(movie => movie.Title.StartsWith('T')).ToList();
            var allMoviesWithTitleStartWithTQuery =
                (from movie in movies
                where movie.Title.StartsWith('T')
                select movie).ToList();
            foreach (var movie in allMoviesTitleStartWithT)
            {
                Console.WriteLine(movie.Title); ;
            }
            {

            }
            // 2. Find the FIRST Movie with Title starting with 'G' 
            var firstMovieTitleWithG = movies.FirstOrDefault(movie => movie.Title.StartsWith('E'));
            if(firstMovieTitleWithG == null)
            {
                Console.WriteLine("Movie start with G is not exist");
            }
            Console.WriteLine(firstMovieTitleWithG.Title);

            // 3. Find the LAST Movie with Title starting with 'G'
            var lastMovieStartingWithGLambda = movies.Last(movie => movie.Title.StartsWith('G'));
            Console.WriteLine("Last movie starting with G" +  lastMovieStartingWithGLambda.Title);
            var firstMovieTitleWithQuery = (from movie in movies
                                            where movie.Title.StartsWith('G')
                                            select movie.Title).FirstOrDefault();
            if(lastMovieStartingWithGLambda == null)
                Console.WriteLine("Movie start with G is not exist");
            // 4. Find ALL movies TITLES that plays for more than 2 hours
            var allMoviesTitleLongerThenTwoOurs = movies
                                            .Where(movie => movie.Duration > 120)
                                            .Select(movie => movie.Title).ToList();
            allMoviesTitleLongerThenTwoOurs.ForEach(title => Console.WriteLine(title));
            foreach (var title in allMoviesTitleLongerThenTwoOurs)
            {
                Console.WriteLine(title);
            }
            // 4. Find ALL movies TITLES and Ratings that plays for more than 2 hours
            var allMoviesTitleAndRatingsLongerThenTwoOurs = movies
                                           .Where(movie => movie.Duration > 120)
                                           .Select(movie => new { naslov = movie.Title, Kvalitet = movie.Rating}).ToList();

            // 5. Find ALL movies TITLES produced before 2010 and ORDER by Title

            // 6. Find ALL movies TITLES produced after 2010, with Rating over 8.5 and ORDER by Title (Acessing/Descending Order)
            var allTitlesComplexConditionAcc = movies.Where(movie => movie.Year < 2010)
                                                       .Where(movie => movie.Rating < 8.5)
                                                     .OrderBy(movie => movie.Title)
                                                     .Select(movie => movie.Title)
                                                     .ToList();

            // 7. What is the AVERAGE RANKING of ALL movies
            var averageRating = movies.Average(movie => movie.Rating);

            // 8. Find the BEST RANKING movie (get only the TITLE and RANKING)
            var bastRankingMovie = movies.Max(movie => movie.Rating);
            var bestTitle = movies.Single(movie => movie.Rating == bastRankingMovie);
            // 9. Find the WORST RANKING movie (get only the TITLE and DURATION)
            var worstMoviesRanking = movies.Min(movie => movie.Rating);
            // 10. Get FIRST five movies
            var firstFive = movies.Take(5).ToList();


            // 11. Get LAST five movies
            var lastFive = movies.TakeLast(5).ToList();
            #endregion

            Console.ReadLine();
        }
    }
}