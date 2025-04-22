using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApologySite.Data;
using ApologySite.Models;

public class MessagesModel : PageModel
{
    public List<Message> AllMessages => MessageStore.Messages;

    public IActionResult OnPostDone(int id)
    {
        MessageStore.RemoveById(id); 
        return RedirectToPage();
    }
}
