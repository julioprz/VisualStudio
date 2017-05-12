using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SqlCommands
    {
        string _ConnStr;
        SqlConnection _Connection;
        SqlCommand _Command;
        SqlDataAdapter _Adapter;
        DataTable _dt1;

        string _SqlStr;
        public string SqlStr
        {
            get
            {
                return _SqlStr;
            }

            set
            {
                _SqlStr = value;
            }
        }

        string _SqlMessage;
        public string SqlMessage
        {
            get
            {
                return _SqlMessage;
            }
        }

        public SqlCommands()
        {
            _SqlStr = "";
            _ConnStr = SetConnParam();
        }

        private string SetConnParam()
        {            
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
    }
}
