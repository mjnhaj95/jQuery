using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JequeyDemo
{
    public class Emplyee
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string email { set; get; }
        public int age { set; get; }
    }
        public partial class WebForm1 : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                string json = "[{\"firstName\":\"CDG\",\"lastName\":\"App\",\"email\":\"cdg@gmail.com\",\"age\":14},{\"firstName\":\"John\",\"lastName\":\"Key\",\"email\":\"john@gmail.com\",\"age\":16}]";

                JavaScriptSerializer javaScriptSeralizer = new JavaScriptSerializer();

                var listEmployee = javaScriptSeralizer.Deserialize<List<Emplyee>>(json);

            }
        }
    }