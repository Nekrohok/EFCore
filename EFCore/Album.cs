namespace ef_base
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public Artist Artist { get; set; }
        public ICollection<Song> Songs { get; set; }


        //public string Artist { get; set; }

    }
}