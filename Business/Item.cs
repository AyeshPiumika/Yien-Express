﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Business
{
    public class Item
    {
        public int itemid { set; get; }

        public string details { set; get; }

        public int ncid { set; get; }

        public int rcontact { set; get; }

        public string raddress { set; get; }

        public string itemstatus { set; get; }

        public int insertItems()
        {
            try
            {
                string sql = "INSERT INTO tbl_Items VALUES (" + itemid + ",'" + details + "'," + ncid + "," + rcontact + ",'" + raddress + "','" + itemstatus + "')";
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet findItem()
        {
            try
            {
                string sql = "SELECT * FROM tbl_Items WHERE itemid=" + itemid;
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int updateItem()
        {
            try
            {
                string sql = "UPDATE tbl_Items SET itemstatus='" + itemstatus + "' WHERE itemid=" + itemid;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet viewAllItem()
        {
            try
            {
                string sql = "SELECT * FROM tbl_Items";
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}
