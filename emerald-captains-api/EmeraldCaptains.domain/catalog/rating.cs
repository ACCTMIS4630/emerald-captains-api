namespace EmeraldCaptains.Domain.Catalog;

public class Rating
{
    public int Stars { get; set; }
    public string Username { get; set; }
    public string Review { get; set; }


    public Rating(int stars, string username, string review)
    {
        if (stars < 1 || stars > 5)
        {
            throw new ArgumentException("Star rating must be 1,2,3,4,5");
        }
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentException("Username can't be empty");
        }
        this.Stars = stars;
        this.Username = username;
        this.Review = review;
    }
}