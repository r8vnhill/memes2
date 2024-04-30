namespace Ravenhill.Data;

public class LessonService {
    public static List<Lesson> Lessons { get; } = GetLessons();

    private static List<Lesson> GetLessons() {
        return [
            new Lesson("Lesson 1", "This is the first lesson", "https://example.com/lesson1", 1)
        ];
    }
}