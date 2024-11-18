using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();
    
    public void OnGet(int skip, int take)
    {
        var temp = new List<Category>();
        
        //await Task.Delay(5000);
        for (int i = 0; i <= 1787; i++)
        {
            temp.Add(new Category(
                i,
                $"Category {i}",
                i*18.95M));
        }
        
        CategoryList = temp
            .Skip(skip*take)
            .Take(take)
            .ToList();
    }
    
    public record Category(
        int Id,
        string Title,
        decimal Price);
}