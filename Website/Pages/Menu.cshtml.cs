 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();
   
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menutype { get; set; } = new List<string>() { "combo", "entree", "side", "drink" };

        [BindProperty]
        public float? minprice { get; set; }

        [BindProperty]
        public float? maxprice { get; set; }

        [BindProperty]
        public List<string> ingredientEx { get; set; } = new List<string>();

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            Menu.AddAllMenuItems();
            if (search != null)
            {
                Menu.SearchByName(search);
            }

            if (menutype != null)
            {
                Menu.SearchByType(menutype);
            }

            if (minprice != null)
            {
                Menu.SearchByMinPrice(minprice);
            }

            if (maxprice != null)
            {
                Menu.SearchByMaxPrice(maxprice);
            }

            if (ingredientEx != null)
            {
                Menu.ExcludeIngredients(ingredientEx);
            }
        }
    }
}