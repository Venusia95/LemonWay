using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Numerics;

namespace InterfaceAppelWS

{
    public partial class Interface : Form
    {
        localhost.WebService1 obj = new localhost.WebService1();
        public Interface()
        {
            InitializeComponent();
        }

        private void btnFibonancci_Click(object sender, EventArgs e)
        {
            string resultatFibo;
            Form WaitForm = new Wait();

            //Affichage de l'écran d'attente
            WaitForm.Show();
            WaitForm.Refresh();

            //Attendre 2 secondes
            System.Threading.Thread.Sleep(2000);
            //Lancement du WebService
            resultatFibo = obj.Fibonacci(10);
            WaitForm.Close();

            //Affichage du résultat
            MessageBox.Show(resultatFibo);

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            string saisieNombre = txtNombre.Text;
            int conversionFibo;
            try
            {
                //Vérification qu'il s'agit d'un nombre
                conversionFibo = Convert.ToInt32(saisieNombre);
            }
            catch
            {
                lblFibo.Text = "Merci de saisir un nombre.";
                lblFibo.ForeColor = Color.Red;
                return;
            }

            Form WaitForm = new Wait();

            //Affichage de l'écran d'attente
            WaitForm.Show();
            WaitForm.Refresh();

            //Lancement du WebService
            string conversionFiboResultat;

            conversionFiboResultat = obj.Fibonacci(conversionFibo);
            WaitForm.Close();

            //Affichage du résultat
            if (conversionFiboResultat == "-1")
                {lblFibo.ForeColor = Color.Red;}
            else
                {lblFibo.ForeColor = Color.Black; }

            lblFibo.Text = conversionFiboResultat;

        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            string saisieXml = rtbXml.Text;
            string resultJson = "";

            Form WaitForm = new Wait();

            //Affichage de l'écran d'attente
            WaitForm.Show();
            WaitForm.Refresh();

            //Lancement du WebService
            resultJson = obj.XmlToJson(saisieXml);
            WaitForm.Close();
            
            
            //Affichage du résultat
            if (resultJson.Substring(0, 7) == "Bad Xml")
            { lblJson.ForeColor = Color.Red; }
            else
            { lblJson.ForeColor = Color.Black; }

            lblJson.Text = resultJson.ToString();
        }
    }
}
