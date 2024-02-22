using SammysBBQ.Data;

namespace SammysBBQ.Pages.Order
{
    public enum SocialType
    {
        Instagram, Facebook, Phone
    }

    public static class SocialTypeExtensions
    { 
        public static string Source(SocialType T)
        {
            switch (T)
            {
                case SocialType.Instagram:
                    return "img/socials/instagram.png";
                case SocialType.Facebook:
                    return "img/socials/facebook.png";
                case SocialType.Phone:
                    return "img/socials/phone.png";
                default:
                    return ImageController.Instance.Logo(false);
            }

        }

        public static string Name(SocialType T)
        {
            switch (T)
            {
                case SocialType.Instagram:
                    return "@sammys.q.bbq";
                case SocialType.Facebook:
                    return "Sam Scala";
                case SocialType.Phone:
                    return "(519) 123-4567";
                default:
                    return String.Empty;
            }

        }
        
        public static string Link(SocialType T)
        {
            switch (T)
            {
                case SocialType.Instagram:
                    return "https://www.instagram.com/sammys.q.bbq";
                case SocialType.Facebook:
                    return "https://www.facebook.com/sam.scala.71";
                case SocialType.Phone:
                    return "tel:519-111-1231";
                default:
                    return String.Empty;
            }

        }
    }

}
