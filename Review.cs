public class Review
{
    private int _reviewId;
    private double _rating;
    private string _comment;

    public Review(int reviewId, double rating, string comment)
    {
        _reviewId = reviewId;
        _rating = rating;
        _comment = comment;
    }

    public double Rating() 
    { 
        return _rating; 
    }
    public string Comment()
    { 
        return _comment; 
    }



}
