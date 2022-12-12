using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Business;
using System.Data;

namespace Yien_Express_Web_Page
{
    /// <summary>
    /// Summary description for YienExpressWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class YienExpressWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertNormalClients(string ncname, int nccontact, int ncnic, string ncaddress)
        {
            try
            {
                NormalClients ncclient = new NormalClients();
                //ncclient.ncid = ncid;
                ncclient.ncname = ncname;
                ncclient.nccontact = nccontact;
                ncclient.ncnic = ncnic;
                ncclient.ncaddress = ncaddress;

                return ncclient.insertNormalClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int UpdateNormalClients(int ncid, string ncname, int nccontact, int ncnic, string ncaddress)
        {
            try
            {
                NormalClients ncclient = new NormalClients();
                ncclient.ncid = ncid;
                ncclient.ncname = ncname;
                ncclient.nccontact = nccontact;
                ncclient.ncnic = ncnic;
                ncclient.ncaddress = ncaddress;

                return ncclient.updateNormalClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet findNormalClients(int ncid)
        {
            try
            {
                NormalClients ncclient = new NormalClients();
                ncclient.ncid = ncid;

                return ncclient.findNormalClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int deleteNormalClients(int ncid)
        {
            try
            {
                NormalClients ncclient = new NormalClients();
                ncclient.ncid = ncid;

                return ncclient.deleteNormalClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet searchAllNormalClients()
        {
            try
            {
                return new NormalClients().searchAllNormalClients();
            }
            catch
            {
                throw;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        [WebMethod]
        public int insertCorporateClients(string ccname, int cccontact, string ccaddress, string ccusername, string ccpassword)
        {
            try
            {
                CorporateClients ccclient = new CorporateClients();
                //ccclient.ccid = ccid;
                ccclient.ccname = ccname;
                ccclient.cccontact = cccontact;
                ccclient.ccaddress = ccaddress;
                ccclient.ccusername = ccusername;
                ccclient.ccpassword = ccpassword;

                return ccclient.insertCorporateClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int updateCorporateClients(int ccid, string ccname, int cccontact, string ccaddress, string ccusername, string ccpassword)
        {
            try
            {
                CorporateClients ccclient = new CorporateClients();
                ccclient.ccid = ccid;
                ccclient.ccname = ccname;
                ccclient.cccontact = cccontact;
                ccclient.ccaddress = ccaddress;
                ccclient.ccusername = ccusername;
                ccclient.ccpassword = ccpassword;

                return ccclient.insertCorporateClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet findCorporateClients(int ccid)
        {
            try
            {
                CorporateClients ccclient = new CorporateClients();
                ccclient.ccid = ccid;

                return ccclient.findCorporateClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int deleteCorporateClients(int ccid)
        {
            try
            {
                CorporateClients ccclient = new CorporateClients();
                ccclient.ccid = ccid;

                return ccclient.deleteCorporateClients();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet searchAllCorporateClients()
        {
            try
            {
                return new CorporateClients().searchAllCorporateClients();
            }
            catch
            {
                throw;
            }
        }

    }
}
