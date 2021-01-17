using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccessLayer;

namespace BusinessLayer
{ 
    public class Layer: ILayer
    {
       public static IData Data;
       public Layer(
          IData _Data
           )
        {
            Data = _Data;
        }
        public DataSet getString()
        {
            //Data data = new Data("",1,"");

            var Reulst = Data.GetDetail();
            return Reulst;
        }
    }
}
