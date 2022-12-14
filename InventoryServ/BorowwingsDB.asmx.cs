﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using WpfApp1;
using System.Data;

namespace InventoryServ
{
    /// <summary>
    /// Summary description for BorowwingsDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BorowwingsDB : System.Web.Services.WebService
    {
        public static String constr = "Server = '" + Dns.GetHostName() + "\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public float CalcAmountOut(int itemId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select Quantity from BorrowedItems where ItemId=" + itemId.ToString() + ";");
            float amount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                amount += float.Parse(dr[0].ToString());
            }
            return amount;
        }
        [WebMethod]
        public bool UpdateAmountOut(int itemId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select Quantity from BorrowedItems where ItemId=" + itemId.ToString() + ";");
            float amount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                amount += float.Parse(dr[0].ToString());
            }
            con.openCon();
            var s = "Update Inventory Set AmountOut = " + amount.ToString() + " where ID = " + itemId.ToString() + ";";
            bool a = con.ExequteNoneQury(s);
            con.CloseCon();
            return a;
        }
        [WebMethod]
        public bool UpdateUserAmountOut(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("Items", "select ID from Inventory where OwnerUserId=" + UserId.ToString() + ";");
            bool isOk = true;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                isOk = isOk && UpdateAmountOut(int.Parse(dr["ID"].ToString()));
            }
            return isOk;
        }
        [WebMethod]
        public int AddLending(int itemId, string lentForWho, DateTime whenBorowwed, float amountBorowwed, int userId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where 0>1");
            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemId"] = itemId;
            dr["BorrowedBy"] = lentForWho;
            dr["When"] = whenBorowwed;
            dr["Quantity"] = amountBorowwed;
            dr["UserId"] = userId;
            con.InsertDataRow(dr);

            ds = con.GetDataSet("lands1", "select Top 1 * from BorrowedItems where ItemId =" + itemId.ToString() + "And BorrowedBy = N'"+ lentForWho.ToString() + "' And Quantity =" + amountBorowwed.ToString() + "  ORDER BY BorrowingId DESC");
            
            int id = int.Parse( ds.Tables[0].Rows[0]["BorrowingId"].ToString());
            return id;
        }
        [WebMethod]
        public DataTable GetLandings(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where UserId=" + UserId.ToString() + ";");
            return ds.Tables["lands"];

        }
        [WebMethod]
        public string getName(int itemId) {
            var con = new Connection(BorowwingsDB.constr);
            con.openCon();
            var ds = con.GetDataSet("item name", "select Name from Inventory where ID = " + itemId + ";");
            con.CloseCon();
            return ds.Tables["item name"].Rows[0]["Name"].ToString();
        }
    }
}
