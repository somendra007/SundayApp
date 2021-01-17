using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public interface IData
    {
        string ConnectionString();
        DataSet GetDetail();
    }
}
