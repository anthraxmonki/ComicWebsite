using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnticsPage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //TO-DO
        //Grab Antics comic data from the ComicsRUS database

        ComicsDBDataContext db = new ComicsDBDataContext();

        ComicData comic = db.ComicDatas.Single(c => c.Website == "Antics");
        ImageButton1.ImageUrl = comic.FilePath;




    }












}