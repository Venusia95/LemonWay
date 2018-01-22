using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using Newtonsoft.Json;// Copyright(c) 2007 James Newton-King


namespace WebService_LemonWay
{
    /// <summary>
    /// Cruchant Nathalie
    /// Projet WebService LemonWay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n<=0 || n>100)
            {
                return -1;
            }
            if (n>=2)
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
            else
            {
                return n;
            }
        }


        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);

                return json;
            }
            catch (Exception e) //Cas de mauvais format XML
            {
                return "Bad Xml format : " + e.Message;
            }
        }


    }
}
