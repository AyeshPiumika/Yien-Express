using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Business
{
    public class NormalClients
    {
        public int ncid { set; get; }

        public string ncname { set; get; }

        public int nccontact { set; get; }

        public int ncnic { set; get; }

        public string ncaddress { set; get; }

        public int insertNormalClients()
        {
            try
            {
                string sql = "INSERT INTO tbl_NormalClients (ncname,nccontact,ncnic,ncaddress) VALUES ('" + ncname + "'," + nccontact + "," + ncnic + ",'" + ncaddress + "')";
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int updateNormalClients()
        {
            try
            {
                string sql = "UPDATE tbl_NormalClients SET ncname='" + ncname + "', nccontact=" + nccontact + ", ncnic=" + ncnic + ", ncaddress='" + ncaddress + "' WHERE ncid=" + ncid;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet findNormalClients()
        {
            try
            {
                string sql = "SELECT * FROM tbl_NormalClients WHERE ncid=" + ncid;
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int deleteNormalClients()
        {
            try
            {
                string sql = "DELETE FROM tbl_NormalClients WHERE ncid=" + ncid;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet searchAllNormalClients()
        {
            try
            {
                string sql = "SELECT * FROM tbl_NormalClients";
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

    }
}
