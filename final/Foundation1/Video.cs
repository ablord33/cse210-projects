public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments;

    public Video()
    {
        comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(string comment)
    {
        comments.Add(new Comment { Text = comment });
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}