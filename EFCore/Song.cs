namespace ef_base
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int length { get; set; }


        public Album album { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}