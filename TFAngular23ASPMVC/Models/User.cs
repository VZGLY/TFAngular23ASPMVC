namespace TFAngular23ASPMVC.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Email { get; set; }

        public List<string> FavoriteMovie { get; set; }

        public User(int id, string firstname, string email, List<string>? movies = null)
        {
            ID = id;
            Firstname = firstname;
            Email = email;
            FavoriteMovie = movies;
        }
    }
}
