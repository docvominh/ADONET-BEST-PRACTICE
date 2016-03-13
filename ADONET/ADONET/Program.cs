using System;
using System.Collections.Generic;
using System.Data;

namespace ADONET
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (DatabaseAccess dba = new DatabaseAccess())
            {
                DataTable dataTable = dba.GetData("TEST_GetEmployeeList");
                IEnumerable<UserDTO> list = EntityHelper<UserDTO>.GetListObject(dataTable);
                foreach (UserDTO obj in list)
                {
                    Console.WriteLine(obj.USER_ID);
                }
            }
            Console.Read();
        }
    }
}