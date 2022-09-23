using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LevionJewelry.Models;
using System.Reflection;

namespace LevionJewelry.Pages;

public class IndexModel : PageModel
{
    public List<Jewelry> Item = Inventory.ToList();
   
    public void OnGet()
    {

    }
}


