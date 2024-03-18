using SammysBBQ.Data;
using System.Text.Json;

namespace SammysBBQ.Pages.Order
{
    public enum SocialType
    {
        Instagram, Facebook, Phone, Email
    }


    public static class SocialTypeExtensions
    {
        public readonly static string PhoneNumber = "519-991-5596";



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
                    return ImageFactory.Instance.Logo(false);
            }

        }

        public static async Task<string?> Name(SocialType T)
        {
            string key = "";
            switch (T)
            {
                case SocialType.Instagram:
                    key = "instagram";
                    break;
                case SocialType.Facebook:
                    key = "facebook";
                    break;
                case SocialType.Phone:
                    key = "phone";
                    break;
                default:
                    return String.Empty;
            }

            JsonDocument? data = await ApiDataFactory.Instance.Get(new List<string>() { "root", "order", "socials", key });

            if (data == null)
            {
                return null;
            }


            return data.RootElement.GetProperty("data").GetProperty("handle").ToString();

        }

        public static async Task<string?> Link(SocialType T)
        {

            string key = "";
            switch (T)
            {
                case SocialType.Instagram:
                    key = "instagram";
                    break;
                case SocialType.Facebook:
                    key = "facebook";
                    break;
                case SocialType.Phone:
                    key = "phone";
                    break;
                default:
                    return String.Empty;
            }

            JsonDocument? data = await ApiDataFactory.Instance.Get(new List<string>() { "root", "order", "socials", key });

            if (data == null)
            {
                return null;
            }


            return data.RootElement.GetProperty("data").GetProperty("link").ToString();


        }
    }

}
