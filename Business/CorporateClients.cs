using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class CorporateClients
    {
        public int ccid { set; get; }

        public string ccname { set; get; }

        public int cccontact { set; get; }

        public string ccaddress { set; get; }

        public string ccusername { set; get; }

        public string ccpassword { set; get; }

        public int insertCorporateClients()
        {
            try
            {
                string sql = "INSERT INTO tbl_CorporateClientRequest (ccname,cccontact,ccaddress,ccusername,ccpassword) VALUES ('" + ccname + "'," + cccontact + ",'" + ccaddress + "','" + ccusername + "','" + ccpassword+ "')";
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int updateCorporateClients()
        {
            try
            {
                string sql = "UPDATE tbl_CorporateClientRequest SET ccname='" + ccname + "', cccontact=" + cccontact + ", ccaddress='" + ccaddress + "', ccusername='" + ccusername + "', ccpassword='" + ccpassword + "' WHERE ccid=" + ccid;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet findCorporateClients()
        {
            try
            {
                string sql = "SELECT * FROM tbl_CorporateClientRequest WHERE ccid=" + ccid;
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int deleteCorporateClients()
        {
            try
            {
                string sql = "DELETE FROM tbl_CorporateClientRequest WHERE ccid=" + ccid;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet searchAllCorporateClients()
        {
            try
            {
                string sql = "SELECT * FROM tbl_CorporateClientRequest";
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

    }
}
