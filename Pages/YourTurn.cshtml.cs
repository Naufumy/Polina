using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApologySite.Data;
using ApologySite.Models;

public class YourTurnModel : PageModel
{
    [BindProperty]
    public List<Message> Blocks { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        int nextId = MessageStore.Messages.Count > 0
            ? MessageStore.Messages.Max(m => m.Id) + 1
            : 1;

        foreach (var block in Blocks)
        {
            block.Id = nextId++;
            MessageStore.Add(block);
        }

        return RedirectToPage("/Messages");
    }
}
