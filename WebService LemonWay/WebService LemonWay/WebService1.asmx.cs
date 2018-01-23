using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using Newtonsoft.Json;// Copyright(c) 2007 James Newton-King
using System.Numerics;


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
        public string Fibonacci(int n)
        {
            if (n <= 0 || n > 100)
            {
                return "-1";
            }

            BigInteger w;

            if (n <= 0) return "0";
            if (n == 1) return "1";
            BigInteger u = 0;
            BigInteger v = 1;
            

            for (int i = 2; i <= n; i++)
            {
                w = u + v;
                u = v;
                v = w;
            };
            
            return v.ToString();
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
