using System.Web;
using System.Web.Mvc;

namespace _10242_Pillay_Semeshan_DOE522_FA2_Question_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
