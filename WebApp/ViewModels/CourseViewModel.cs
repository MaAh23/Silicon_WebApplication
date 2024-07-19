namespace WebApp.ViewModels;

public class CourseViewModel
{
    public int Id { get; set; }
    public bool IsBestSeller { get; set; }
    public string Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string? DiscoundPrice { get; set; }
    public string Hourse { get; set; } = null!;
    public string LikeInProcent { get; set; } = null!;
    public string LikeInNumbers { get; set; } = null!;
}
