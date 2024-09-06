using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

namespace prj35347_XML_Series1
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
                    litTable.Text += "<a href='../../Series.aspx?cd=" + Series[i]["Codigo"].InnerText + "'";
                    litTable.Text += "  <section class='Series'>";
                    litTable.Text += "      <img src='../../Images/" + Series[i]["Foto"].InnerText + "' class='Images1'/>";
                    litTable.Text += "      <h3> <strong> " + Series[i]["Nome"].InnerText + " </strong> </h3>";
                    litTable.Text += "      <h6> " + Series[i]["Original"].InnerText + " - ";
                    litTable.Text +=            Series[i]["Ano"].InnerText + " - ";

                    XmlNodeList ListaCategorias = Series[i]["Categorias"].GetElementsByTagName("Categoria");

                    string Categorias = "";

                    for (int k = 0; k < ListaCategorias.Count; k++)
                    {
                        Categorias += ListaCategorias[k].InnerText + ", ";
                    }

                    litTable.Text += Categorias.ToString().Substring(0, Categorias.Length - 2) +"</h6>";
                    litTable.Text += "  </section>";
                    litTable.Text += "</a>";
                }

                #endregion
            }
        }
    }
}