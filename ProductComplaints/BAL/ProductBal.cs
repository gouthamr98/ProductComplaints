using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProductComplaints.BAL
{
    public class ProductBal
    {

        //create object of dataAccess Layer
        DAL.ProductDal objprdtdl = new DAL.ProductDal();
        //create two variable based on table

        private int _productid;
        private string _productname;

        public int ProductId
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
        public string ProductName
        {
            get
            {
                return _productname;
            }
            set
            {
                _productname = value;
            }
        }

        public int insertproduct()
        {
            return objprdtdl.ProductInsert(this);
        }

        public DataTable viewproduct()
        {
            return objprdtdl.ViewProduct();
        }
        public int productupdate()
       {
           return objprdtdl.ProductUpdate(this);
        }

        public int deleteproduct()
        {
            return objprdtdl.Deleteproduct(this);
        }
    }
}