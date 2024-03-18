
using SammysBBQ.Pages.Menu;

namespace SammysBBQ.Data
{
    public class MenuItemFactory : AbsSingleton<MenuItemFactory>
    {
        public List<MenuItemContent> DefaultBBQMenuItems()
        {
            MenuItemContent Brisket = new MenuItemContent()
            {
                ItemName = "Brisket",
                ItemImagePath = null,
                Description = null
            };
            MenuItemContent PulledPork = new MenuItemContent()
            {
                ItemName = "Pulled Pork",
                ItemImagePath = null,
                Description = null
            };
            MenuItemContent Lamb = new MenuItemContent()
            {
                ItemName = "Lamb",
                ItemImagePath = ImageSources.PulledLambCut1,
                Description = "Indulge in the irresistible flavors of our slow-cooked pulled pork, a culinary masterpiece that promises to tantalize your taste buds with every savory bite. Crafted with care and expertise, our pulled pork is a celebration of tender, succulent meat infused with a symphony of seasonings and spices. Hand - selected pork shoulder is meticulously prepared and cooked to perfection over a low flame, allowing the rich flavors to develop and meld harmoniously.As the meat tenderizes, it absorbs the essence of our secret blend of spices, creating a mouthwatering symphony of taste that is both bold and nuanced."
            };
            MenuItemContent Beef = new MenuItemContent()
            {
                ItemName = "Beef",
                ItemImagePath = ImageSources.BeefRibs,
                Description = null
            };
            MenuItemContent Chicken = new MenuItemContent()
            {
                ItemName = "Chicken",
                ItemImagePath = ImageSources.ChickenWings,
                Description = null
            };
            MenuItemContent BeefPorkRibs = new MenuItemContent()
            {
                ItemName = "Beef/Pork Ribs",
                ItemImagePath = ImageSources.StLouisRibs2,
                Description = null
            };
            MenuItemContent Fish = new MenuItemContent()
            {
                ItemName = "Fish (Rainbow Trout, Salmon)",
                ItemImagePath = null,
                Description = null
            };

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
