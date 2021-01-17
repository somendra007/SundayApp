using System.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace DataAccessLayer
{
    public class Data: IData
    {
      
        public Data()
        {
            
        }
        public string ConnectionString()
        {
            string owners = System.IO.File.ReadAllLines(@".\AppSetting\DbString.txt").ToString();
            return owners;
        }


        public DataSet GetDetail()
        {
            return null;
        }

    }
}
