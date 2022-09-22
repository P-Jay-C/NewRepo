using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel? Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Pineapple) PizzaPrice += 1;
            if (Pizza.Beaf ) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 5;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", routeValues: new { Pizza.PizzaName, PizzaPrice });
        }
    } 
}