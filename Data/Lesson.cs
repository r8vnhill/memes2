namespace Ravenhill.Data;

public class Lesson(string name, string description, string icon) {
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public string Icon { get; set; } = icon;
}