namespace Ravenhill.Data;

public class LessonService {
    public static List<Lesson> Lessons { get; } = GetLessons();

    private static List<Lesson> GetLessons() {
        return [];
    }
}