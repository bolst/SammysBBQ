
using SammysBBQ.Pages.Menu;

namespace SammysBBQ.Data
{
    public class MenuItemController : AbstractController<MenuItemController>
    {
        public List<string> BBQMenuItems()
        {
            return new List<string>
            {
                "Brisket",
                "Pulled pork",
                "Lamb",
                "Beef",
                "Chicken",
                "Beef/Pork Ribs",
                "Fish",
            };
        }
    }
}
