namespace EFCoreDeepDive.Entities
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public CinemaHallType CinemaHallType { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public HashSet<Movie> Movies { get; set; }
    }
}
