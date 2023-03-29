public class Comment
{
    public string _commentStr = " ";
    public string _commentAuthor = " ";

    public void CreateComment()
        {
        Console.WriteLine("What is the comment?");
        _commentStr = Console.ReadLine();
        Console.WriteLine("Who typed the comment?");
        _commentAuthor = Console.ReadLine();
        
        }

    public void Display()
    {
        Console.WriteLine($"{_commentStr}\n{_commentAuthor}");
    }
}
