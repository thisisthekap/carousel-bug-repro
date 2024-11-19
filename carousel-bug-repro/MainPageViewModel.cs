namespace carousel_bug_repro;

public class MainPageViewModel : BindableObject
{
    public List<TestItem> TestItems { get; } =
    [
        new TestItem("Test 1", "This is <b>a test 1</b>"),
        new TestItem("Test 2", "This is <b>a test 2</b>"),
        new TestItem("Test 3", "This is <b>a test 3</b>")
    ];
}