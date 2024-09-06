using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

namespace prj35347_XML
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument Arquivo = new XmlDocument();

            if ( File.Exists(Request.PhysicalApplicationPath + "XML/Series.xml"))
            {
                Arquivo.Load(Request.PhysicalApplicationPath + "XML/Series.xml");
                XmlNodeList Series = Arquivo.GetElementsByTagName("SERIE");

                #region Table teste

                for (int i = 0; i < Series.Count; i++)
                {
                    litTable.Text += "<table class='Series'>";

                    litTable.Text += "<tr> <td> <img src='../../Images/TheFlash.jpg' class='Images'/> </td> </tr>";

                    litTable.Text += " <tr> <td> <h3> <strong>" + Series[i]["Nome"].InnerText + "</strong> </h3> </td> </tr>";

                    litTable.Text += " <tr> <td>" + Series[i]["Descricao"].InnerText + " </td> </tr>";

                    litTable.Text += "</table>";
                }

                #endregion
            }
        }
    }
}