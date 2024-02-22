
namespace SammysBBQ.Data
{
    public class FlyerController : AbstractController<FlyerController>
    {
        public string CateringFlyer() { return "img/catering-flyer.jpg"; }
        public string MainFlyer() { return "img/sammys-flyer.jpg";  }
    }
}
