namespace EFCoreDeepDive.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool InCinemas { get; set; }

        public string PosterUrl { get; set; }

        public HashSet<MovieActor> MovieActors { get; set; }

        public HashSet<Genre> Genres { get; set; }

        public HashSet<CinemaHall> CinemaHalls { get; set; }
    }
}
