using formulaOneDLL;
using System;
using System.Collections.Generic;
using System.Linq;
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
}