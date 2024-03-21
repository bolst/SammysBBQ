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
        public readonly static string Email = "sammys.q.bbq@gmail.com";



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
                case SocialType.Email:
                    return "img/socials/gmail.png";
                default:
                    return ImageFactory.Instance.Logo(false);
            }

        }

        public static async Task<string?> Name(SocialType T)
        {
            switch (T)
            {
                case SocialType.Instagram:
                    return "@sammys.q.bbq";
                    break;
                case SocialType.Facebook:
                    return "Sammy's Q";
                    break;
                case SocialType.Phone:
                    {
                        string[] phoneNumSplit = PhoneNumber.Split('-');
                        return $"({phoneNumSplit[0]}) {phoneNumSplit[1]}-{phoneNumSplit[2]}";
                    }
                case SocialType.Email:
                    return Email;
                default:
                    return String.Empty;
            }
        }

        public static async Task<string?> Link(SocialType T)
        {
            switch (T)
            {
                case SocialType.Instagram:
                    return "https://www.instagram.com/sammys.q.bbq";
                    break;
                case SocialType.Facebook:
                    return "https://www.facebook.com/profile.php?id=61550601187339";
                    break;
                case SocialType.Phone:
                    return $"tel:{PhoneNumber}";
                    break;
                case SocialType.Email:
                    {
                        string subject = "";
                        string body = "";
                        return $"mailto:Sammy's%20Q<{Email}>?subject={subject}&body={body}";
                    }
                default:
                    return String.Empty;
            }

        }
    }

}
