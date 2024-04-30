namespace Ravenhill.Data;

public class Lesson(string name, string description, string link, int id) {
    public int Id { get; } = id;
    public string Name { get; } = name;
    public string Description { get; } = description;
    public string Link { get; } = link;
}