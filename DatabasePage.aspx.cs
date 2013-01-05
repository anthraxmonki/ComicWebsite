using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;




public partial class DatabasePage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //Grabs and verifies the file path of the needed comic
        //grabs a random Explosm comic

        ComicsDBDataContext db = new ComicsDBDataContext();

        Random oRandomComic = new Random();
        int iRandomComic = oRandomComic.Next(1000, 3041);


        var doesComicActuallyExist = db.ComicDatas.Any(c => c.FileName.Equals("Explosm" + Convert.ToString(iRandomComic)) );


        while(doesComicActuallyExist == false)
        {

            iRandomComic = oRandomComic.Next(1000, 1016);
            doesComicActuallyExist = db.ComicDatas.Any(c => c.FileName.Equals("Explosm" + Convert.ToString(iRandomComic)) );

        }

        ComicData comic = db.ComicDatas.Single(c => c.FileName == ( "Explosm" + Convert.ToString(iRandomComic) ));
        ImageButton1.ImageUrl = comic.FilePath;






    }
















    protected void LinqButton_Click(object sender, EventArgs e)
    {
        ComicsDBDataContext db = new ComicsDBDataContext();

        string sDirectory    = @"~\Comics\Explosm\";

        int iIncrementFrom    = 1210;
        int iIncrementTo      = 3040;

        //ComicData columns
        string sFileName      = "Explosm";
        string sFileExtension = ".png";
        string sWebsite       = "Explosm";
        int    iBumps         = 0;
        string sAbsolutePath = (sDirectory + sFileName + Convert.ToString(iIncrementFrom) + sFileExtension);


        DateTime oDateNow = DateTime.Now;



        //This is how the webpage determines if the filepath exists because
        //(System.IO.File.Exists() doesn't work the way I try to use it)
        string sCompleteFilePath = HttpContext.Current.Server.MapPath(sDirectory + sFileName + Convert.ToString(iIncrementFrom) + sFileExtension);



            do
            {
                //checks to see if the directory file even exists, if not then skip && increment
                if(System.IO.File.Exists(sCompleteFilePath) == true)
                {        

                    //returns true if there if FileName exists in the database.
                    var hasName = db.ComicDatas.Any(p => p.FileName.Equals(sFileName + Convert.ToString(iIncrementFrom)) );

                    //if the FileName does not exist in the column
                    if (hasName == false)
                    {

                        ComicData oColumn = new ComicData();

                        oColumn.FileName = (sFileName + Convert.ToString(iIncrementFrom));
                        oColumn.FileExtension = sFileExtension;
                        oColumn.Website = sWebsite;
                        oColumn.Bumps = iBumps;
                        oColumn.FilePath = sAbsolutePath;
                        oColumn.DateAdded = oDateNow;


                        db.ComicDatas.InsertOnSubmit(oColumn);
                        db.SubmitChanges();
                    }
                }


                iIncrementFrom += 1;

                //re-bind with the incremented data
                sCompleteFilePath = HttpContext.Current.Server.MapPath(sDirectory + sFileName + Convert.ToString(iIncrementFrom) + sFileExtension);
                //re-bind with the incremented data
                sAbsolutePath = (sDirectory + sFileName + Convert.ToString(iIncrementFrom) + sFileExtension);


           } while (iIncrementFrom <= iIncrementTo);





    }






}