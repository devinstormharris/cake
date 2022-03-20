namespace Cake.Models;

public class Birthday
{
    public Birthday(string name, DateTime date)
    {
        Name = name;
        Date = date;
    }

    private string Name { get; set; }
    private DateTime Date { get; set; }
}