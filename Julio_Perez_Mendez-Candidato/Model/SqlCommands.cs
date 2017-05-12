using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            return System.Configuration.ConfigurationManager.ConnectionStrings["InterviewProjectConnectionString"].ConnectionString;
        }

        public DataTable SqlSelect()
        {
            _dt1 = new DataTable();
            if (_SqlStr.Trim() != "")
            {
                _Connection = new SqlConnection(_ConnStr);
                _Connection.Open();
                _Command = new SqlCommand(_SqlStr, _Connection);
                _Adapter = new SqlDataAdapter(_Command);

                _Adapter.Fill(_dt1);
                _dt1.TableName = "t1";

                _Connection.Close();
                _Adapter.Dispose();
                _Command.Dispose();
                _Connection.Dispose();
            }
            return _dt1;
        }

        public DataSet SqlSelectDataSet()
        {
            DataSet ds = new DataSet();
            if (_SqlStr.Trim() != "")
            {
                _Connection = new SqlConnection(_ConnStr);
                _Connection.Open();
                _Command = new SqlCommand(_SqlStr, _Connection);
                _Adapter = new SqlDataAdapter(_Command);

                _Command.CommandTimeout = 600;

                _Adapter.Fill(ds);

                _Connection.Close();
                _Adapter.Dispose();
                _Command.Dispose();
                _Connection.Dispose();
            }
            return ds;
        }

        public string SqlSelectValue()
        {
            string val = "";
            SqlSelect();
            if (_dt1.Rows.Count > 0)
                val = _dt1.Rows[0][0].ToString().Trim();

            return val;
        }

        public int SqlInsertGetId()
        {
            int id = 0;
            SqlSelect();
            if (_dt1.Rows.Count > 0)
                int.TryParse(_dt1.Rows[0]["Id"].ToString(), out id);

            return id;
        }
    }
}
