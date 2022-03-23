namespace ToDoApp.Models;

public class CardModel
{
    public CardModel(string title, string content, string scale, int personId)
    {
        this.Title = title;
        this.Content = content;
        this.PersonId = personId;
        this.Scale = scale;
    }

    public string Title;
    public string Content;
    public string Scale;
    public int PersonId;
}