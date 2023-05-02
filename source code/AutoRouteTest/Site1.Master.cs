using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoRouteTest
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string folder = Server.MapPath("~/pages");
            string[] files = Directory.GetFiles(folder);

            StringBuilder sb = new StringBuilder();

            foreach (string file in files)
            {
                if (!file.EndsWith(".aspx"))
                    continue;

                string fileName = Path.GetFileNameWithoutExtension(file);

                string menuName = GetMenuName(fileName);

                sb.Append($"<a href='/{fileName}'>{menuName}</a>");
            }

            sb.Append("<a href='/settings'>Settings</a>");

            ph1.Controls.Add(new LiteralControl(sb.ToString()));
        }

        string GetMenuName(string fileName)
        {
            StringBuilder sb = new StringBuilder();

            bool requireSpaceOnNextCapital = false;

            foreach(char c in fileName)
            {
                if (char.IsUpper(c))
                {
                    if (requireSpaceOnNextCapital)
                        sb.Append(" ");
                    else
                        requireSpaceOnNextCapital = true;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}