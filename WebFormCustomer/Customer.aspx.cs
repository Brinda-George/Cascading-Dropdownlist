using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCustomer
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateCountriesDropDownList();
            }
        }

        private void PopulateCountriesDropDownList()
        {
            ddlCountries.DataSource = GetData("spGetCountries", null);
            ddlCountries.DataBind();

            ListItem liCountry = new ListItem("Select Country", "-1");
            ddlCountries.Items.Insert(0, liCountry);

            ListItem liState = new ListItem("Select State", "-1");
            ddlStates.Items.Insert(0, liState);

            ListItem liCity = new ListItem("Select City", "-1");
            ddlCities.Items.Insert(0, liCity);

            ListItem liLocality = new ListItem("Select Locality", "-1");
            ddlLocalities.Items.Insert(0, liLocality);

            ddlStates.Enabled = false;
            ddlCities.Enabled = false;
            ddlLocalities.Enabled = false;
        }

        private DataSet GetData(string SPName, SqlParameter SPParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (SPParameter != null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedValue == "-1")
            {
                ddlStates.SelectedIndex = 0;
                ddlCities.SelectedIndex = 0;
                ddlLocalities.SelectedIndex = 0;
                ddlStates.Enabled = false;
                ddlCities.Enabled = false;
                ddlLocalities.Enabled = false;
            }
            else
            {
                ddlStates.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CountryId";
                parameter.Value = ddlCountries.SelectedValue;

                ddlStates.DataSource = GetData("spGetStatesByCountryId", parameter);
                ddlStates.DataBind();

                ListItem liState = new ListItem("Select State", "-1");
                ddlStates.Items.Insert(0, liState);

                ListItem liCity = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCity);

                ListItem liLocality = new ListItem("Select Locality", "-1");
                ddlLocalities.Items.Insert(0, liLocality);

                ddlCities.SelectedIndex = 0;
                ddlLocalities.SelectedIndex = 0;
                ddlCities.Enabled = false;
                ddlLocalities.Enabled = false;
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStates.SelectedValue == "-1")
            {
                ddlCities.SelectedIndex = 0;
                ddlLocalities.SelectedIndex = 0;
                ddlCities.Enabled = false;
                ddlLocalities.Enabled = false;
            }
            else
            {
                ddlCities.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@StateId";
                parameter.Value = ddlStates.SelectedValue;

                ddlCities.DataSource = GetData("spGetCitiesByStateId", parameter);
                ddlCities.DataBind();

                ListItem liCity = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCity);

                ListItem liLocality = new ListItem("Select Locality", "-1");
                ddlLocalities.Items.Insert(0, liLocality);

                ddlLocalities.SelectedIndex = 0;
                ddlLocalities.Enabled = false;
            }
        }
        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCities.SelectedValue == "-1")
            {
                ddlLocalities.SelectedIndex = 0;
                ddlLocalities.Enabled = false;
            }
            else
            {
                ddlLocalities.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CityId";
                parameter.Value = ddlCities.SelectedValue;

                ddlLocalities.DataSource = GetData("spGetLocalitiesByCityId", parameter);
                ddlLocalities.DataBind();

                ListItem liLocality = new ListItem("Select Locality", "-1");
                ddlLocalities.Items.Insert(0, liLocality);
            }
        }
    }
}