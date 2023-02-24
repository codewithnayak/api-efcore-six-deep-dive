namespace EFCoreDeepDive.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool InCinemas { get; set; }

        public string PosterUrl { get; set; }
    }
}
