
namespace SammysBBQ.Data
{
    public class ImageController : AbstractController<ImageController>
    {
        public List<string> SpotlightImages()
        {
            return new List<string>()
            {
                "img/spotlight/ppork_sandwich.jpeg",
                "img/spotlight/bacon_crackers.jpeg",
                "img/spotlight/chicken_sausage_app.jpeg",
                "img/spotlight/steak_tacos.jpeg",
            };
        }

        public string Logo(bool bkg = true)
        {
            string retval = "img/logo";

            retval += bkg ? ".jpg" : "-nobkg.png";

            return retval;
        }
    }
}
