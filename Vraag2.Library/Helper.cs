using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Vraag2.Library
{
    public static class Helper
    {
        private static List<Movie> movies;

        public static async void LoadMovies(string dataFolder)
        {
            // geeft een array met namen van alle bestanden (inclusief hun paden) in de opgegeven map terug
            string[] jsonFiles = Directory.GetFiles(dataFolder, "*.json");

            movies = new List<Movie>(jsonFiles.Length);

            await Task.Run(() =>
            {
                Parallel.ForEach(jsonFiles, (filePath) =>
                {
                    string fileContent = File.ReadAllText(filePath);
                    var movie = JsonConvert.DeserializeObject<Movie>(fileContent);
                    movies.Add(movie);
                });
            });
        }

        public static IEnumerable<Movie> SearchMovies(string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm) || searchTerm.Length < 2)
            {
                throw new InvalidInputException("Search term must be at least 2 characters long!");
            }
            else
            {
                return movies.Where(m => m.primaryTitle.ToLowerInvariant().Contains(searchTerm.ToLowerInvariant()));
            }
        }
    }
}
