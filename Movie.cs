namespace modul10_103022330059
{
    public class Movie
    {
        public string title { get; set; }

        public string director { get; set; }

        public List<string> stars { get; set; }

        public  string description { get; set; }

        public Movie(string Title, string Director, List<string> Stars, string Description)
        {
            this.title = Title;
            this.director = Director;
            this.stars = Stars;
            this.description = Description;
        }
    }
}
