using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProductComplaints.BAL
{
    public class RegBal
    {
        //create object of dataAccess Layer
        DAL.RegDal objregdl = new DAL.RegDal();
        //create two variable based on table
       
        private int _custid;
        private string _custname;
        private string _custgender;
        private string _custplace;
        private string _custpin;
        private string _custdistrict;
        private string _custemail;
        private string _custphone;
        private int _loginid;
        private string _custuname;
        private string _custpswd;


        public int CustId
        {
            get
            {
                return _custid;
            }
            set
            {
                _custid = value;
            }
        }
        public string CustName
        {
            get
            {
                return _custname;
            }
            set
            {
                _custname = value;
            }
        }
        public string CustGender
        {
            get
            {
                return _custgender;
            }
            set
            {
                _custgender = value;
            }
        }
        public string CustPlace
        {
            get
            {
                return _custplace;
            }
            set
            {
                _custplace = value;
            }
        }

        public string CustPin
        {
            get
            {
                return _custpin;
            }
            set
            {
                _custpin = value;
            }
        }
        public string CustDistrict
        {
            get
            {
                return _custdistrict;
            }
            set
            {
                _custdistrict = value;
            }
        }
        public string CustEmail
        {
            get
            {
                return _custemail;
            }
            set
            {
                _custemail = value;
            }
        }
        public string CustPhone
        {
            get
            {
                return _custphone;
            }
            set
            {
                _custphone = value;
            }
        }

        public int LoginId
        {
            get
            {
                return _loginid;
            }
            set
            {
                _loginid = value;
            }
        }
        public string CustUname
        {
            get
            {
                return _custuname;
            }
            set
            {
                _custuname = value;
            }
        }

        public string CustPswd
        {
            get
            {
                return _custpswd;
            }
            set
            {
                _custpswd = value;
            }
        }


        public object insertlogin()
        {
            return objregdl.loginInsert(this);
        }
        public int insertcustomer()
        {
            return objregdl.userInsert(this);
        }

        public DataTable loginfun()
        {
            return objregdl.Loginfun(this);
        }

        public DataTable viewcustomer()
        {
            return objregdl.ViewCustomer();
        }
        public int Updateconfirm()
        {
            return objregdl.Confirmupdate(this);
        }


    }
}