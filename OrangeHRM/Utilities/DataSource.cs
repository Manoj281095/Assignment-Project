using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginData()
        {
            Object[] dataSet1 = new object[3];
            dataSet1[0] = "Admin";
            dataSet1[1] = "admin123";
            dataSet1[2] = "OrangeHRM";


            object[] allData = new object[1];
            allData[0] = dataSet1;
           

            return allData;
        }

        public static object[] InvalidloginData()
        {

            Object[] dataSet1 = new object[3];
            dataSet1[0] = "john";
            dataSet1[1] = "admin123";
            dataSet1[2] = "Invalid credentials";


            Object[] dataSet2 = new object[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "admin123";
            dataSet2[2] = "Invalid credentials";


            object[] allData = new object[2];
            allData[0] = dataSet1;
            allData[1] = dataSet2;


            return allData;

        }
    }
}
