using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChaiShai
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RectangleProgram r = new RectangleProgram();
            bool a = r.IntersectingRectangle;
            if (a)
                TextBoxOne.Text = "SomeOne just Fucked me!";
        }
    }
}