using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank_desktop_application.BL;
namespace bank_desktop_application.DL
{
    class add_user_DL
    {
        private static List<users_class> current_user = new List<users_class>();
        internal static List<users_class> Current_user { get => current_user; set => current_user = value; }

    }
}
