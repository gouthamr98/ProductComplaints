using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProductComplaints.BAL
{
    public class QuerryBal
    {
        DAL.QuerryDal objquerytdl = new DAL.QuerryDal();

        private int _querryid;
        private int _customerid;
        private int _productid;
        private string _querry;
        private string _reply;




        public int QuerryId
        {
            get
            {
                return _querryid;
            }
            set
            {
                _querryid = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return _customerid;
            }
            set
            {
                _customerid = value;
            }
        }
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
        public string Querry
        {
            get
            {
                return _querry;
            }
            set
            {
                _querry = value;
            }
        }
        public string Reply
        {
            get
            {
                return _reply;
            }
            set
            {
                _reply = value;
            }
        }

        public DataTable getproduct()
        {
            return objquerytdl.Getproduct(this);
        }

        public int insertQuerry()
        {
            return objquerytdl.QuerryInsert(this);
        }
        public DataTable viewquery()
        {
            return objquerytdl.queryview(this);
        }
        public int updateqry()
        {
            return objquerytdl.QuerryUpdate(this);
        }
        public DataTable viewreply()
        {
            return objquerytdl.Replyview(this);
        }
    }
}