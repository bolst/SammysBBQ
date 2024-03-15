
using SammysBBQ.Pages.Menu;

namespace SammysBBQ.Data
{
    public class MenuItemController : AbstractController<MenuItemController>
    {
        public List<MenuItemContent> BBQMenuItems()
        {
            MenuItemContent Brisket = new MenuItemContent("Brisket");
            MenuItemContent PulledPork = new MenuItemContent("Pulled Pork");
            MenuItemContent Lamb = new MenuItemContent("Lamb", ImageSources.PulledLambCut1, "Indulge in the irresistible flavors of our slow-cooked pulled pork, a culinary masterpiece that promises to tantalize your taste buds with every savory bite. Crafted with care and expertise, our pulled pork is a celebration of tender, succulent meat infused with a symphony of seasonings and spices. Hand - selected pork shoulder is meticulously prepared and cooked to perfection over a low flame, allowing the rich flavors to develop and meld harmoniously.As the meat tenderizes, it absorbs the essence of our secret blend of spices, creating a mouthwatering symphony of taste that is both bold and nuanced.");
            MenuItemContent Beef = new MenuItemContent("Beef", ImageSources.BeefRibs);
            MenuItemContent Chicken = new MenuItemContent("Chicken", ImageSources.ChickenWings);
            MenuItemContent BeefPorkRibs = new MenuItemContent("Beef/Pork Ribs", ImageSources.StLouisRibs2);
            MenuItemContent Fish = new MenuItemContent("Fish (Rainbow Trout, Salmon)");

            return new List<MenuItemContent>
            {
                Brisket,
                PulledPork,
                Lamb,
                Beef,
                Chicken,
                BeefPorkRibs,
                Fish,
            };
        }
    }
}
