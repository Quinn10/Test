using System.Linq;
using System.Collections.Generic;
using PSADSDK.Core.Data;
using System;
using System.Data;
using System.Web;

namespace EyeOnRisk.Classes.Record
{
    public class CategoryRecord
    {
        #region Properties
        public String ConnectionString { get; set; }
        public Guid? ID { get; set; }
        public String Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsInActive { get; set; }
        public bool? IsDeleted { get; set; }
        #endregion

        #region Constructors

        public CategoryRecord()
        {
            ConnectionString = HttpContext.Current.Session["User"].To<EyeOnRisk.Classes.GlobalUser>().ConnectionString.ToString();
        }

        public CategoryRecord(Guid? ID)
            : this()
        {
            this.ID = ID;
            Load();
        }

        #endregion

        #region Public Methods

        public void Load()
        {
            DataRow Category = TSql.ExecuteDataRow("spLoadCategory"
                , ConnectionString
                , new DataParam("ID", this.ID)
, Title = (String)Category["Title"], CreatedDate = (DateTime?)Category["CreatedDate"], IsInActive = (bool?)Category["IsInActive"], IsDeleted = (bool?)Category["IsDeleted"]);
        }

        public String Save(bool IsEdit, int number = 0)
        {
            if (!IsEdit)
            {
                bool ClientExists = TSql.ExecuteScalarQuery(String.Format("IF EXISTS(SELECT TOP 1 Title FROM Category WHERE Title = '[{0}]' OR Title = '{0}') BEGIN SELECT 1 AS DBExists END ELSE BEGIN SELECT 0 AS DBExists END", Title)
                            , ConnectionString).To<bool>();
                if (ClientExists)
                {
                    String IDExists = ("ID already exsits");
                    return IDExists;
                }
                else
                {
                    TSql.ExecuteNonQuery("spSaveCategory
                        , ConnectionString
                    String IDNew = "Saved";
                    return IDNew;
                }
            }
            TSql.ExecuteNonQuery("spSaveClient"
                , ConnectionString
            return "Saved";
        }
    }
    #endregion
}