namespace ToDoApp.Models;

public class TeamMember
{
    public int Id;
    public string UserName;
    public TeamMember(int id, string username)
    {
        this.Id = id;
        this.UserName = username;
    }
}