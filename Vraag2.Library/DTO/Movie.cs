namespace Vraag2.Library
{
    /// <summary>
    /// Represents a JSON Movie object based on the IMDb dataset
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// alphanumeric unique identifier of the movie
        /// </summary>
        public string tconst { get; set; }

        /// <summary>
        /// the more popular title / the title used by the filmmakers on promotional materials at the point of release
        /// </summary>
        public string primaryTitle { get; set; }

        /// <summary>
        /// original title, in the original language
        /// </summary>
        public string originalTitle { get; set; }

        /// <summary>
        /// 0: non-adult movie; 1: adult movie
        /// </summary>
        public string isAdult { get; set; }

        /// <summary>
        /// represents the release year of a movie. In the case of TV Series, it is the series start year
        /// </summary>
        public string startYear { get; set; }

        /// <summary>
        /// primary runtime of the movie, in minutes
        /// </summary>
        public string runtimeMinutes { get; set; }

        /// <summary>
        /// includes up to three genres associated with the movies
        /// </summary>
        public string genres { get; set; }

        public override string ToString()
        {
            return $"{primaryTitle} ({originalTitle}) - {startYear}";
        }
    }
}
