public class Video
{
   string _title = " ";
   string _author = " ";
   string _length = " ";
   int _commentCount1 = 0;
   int _commentCount = 0;
   string _commentCountStr = "";
    List<Comment> _comments = new List<Comment>();
    
    
    public void CreateVideo()
    {
        Console.WriteLine("What is the title of the Video?");
        _title = Console.ReadLine();
        Console.WriteLine("who posted the video?");
        _author = Console.ReadLine();
        Console.WriteLine("How long is the video?");
        _length = Console.ReadLine();
        Console.WriteLine("How many comments are there?");
        _commentCountStr = Console.ReadLine();
        _commentCount1 = int.Parse(_commentCountStr);
        for (int i = 0; i < _commentCount1; i++)
        {
            Comment c = new Comment();
            c.CreateComment();
            _comments.Add(c);
        }
    }
    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
        CommentCount();
        foreach (Comment comment in _comments)
        {       
            comment.Display();
        }
    }
    private void CommentCount()
    {
        foreach (Comment comment in _comments )
        {
            _commentCount++;
        }
        Console.WriteLine($"{_commentCount}");
    }
}