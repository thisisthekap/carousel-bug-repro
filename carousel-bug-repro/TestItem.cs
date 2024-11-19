namespace carousel_bug_repro;

public class TestItem
{
    public TestItem(string title, string htmlText)
    {
        Title = title;
        HtmlText = htmlText;
    }

    public string Title { get; set; }
    public string HtmlText { get; set; }
}