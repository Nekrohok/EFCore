namespace ef_base
{
    public class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public ICollection<Album> Albums { get; set; }




    }
}