namespace EmeraldCaptians.Domain.Catalog;

public class rating
{
    public int Stars {get;set;}
    public string username{get;set;}
    public string review {get;set;}
}

public rating(int stars,string username,string review)
{
 if (stars <1 || stars >5)
 {
    throw new ArgumentException("Star rating must be 1,2,3,4,5");
 }
if (string.IsNullOrEmpty(username))
{
    throw new ArgumentException("Username can't be empty");
}
this.Stars= stars;
this.username= username;
this.review= review;
}