using formulaOneDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace formulaOneWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        dbTools db = new dbTools();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cmbTabelle.DataSource = db.getTableName();
                cmbTabelle.DataBind();
            }
            gridView.DataSource = db.GetTable(cmbTabelle.Text);
            gridView.DataBind();
        }

        protected void cmbTabelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridView.DataSource = db.GetTable(cmbTabelle.Text);
            gridView.DataBind();
        }

        
    }
    public void getCountry(string isoCode = "")
    {
        HttpWebRequest apiRequest = WebRequest.Create("https://localhost:44308/api/Country/" + isoCode + "") as HttpWebRequest;
        string apiResponse = "";
        try
        {
            using(HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
                //var oCountry = NewtonSoft.Json.JsonConvert.DeserializeObject<dynamic>(apiResponse);
                oCountry[] oCountry = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(apiResponse);
                lbxNazioni.DataSource = oCountry;
                lbxNazioni.DataBind();
                lbxNazioni.Visible = true;
            }
        }
        catch(System.Net.WebException ex)
        {
            Console.Write(ex.Message);
        }
    }
}