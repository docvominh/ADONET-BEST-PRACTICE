using System;
using System.Collections.Generic;
using System.Data;

namespace ADONET
{
    internal class Program
    {
        private static int GetListEmployee()
        {
            ICollection<UserDTO> list = null;
            using (DatabaseAccess dba = new DatabaseAccess())
            {
                DataTable dataTable = dba.GetData("TEST_GetEmployeeList");
                list = EntityHelper<UserDTO>.GetListObject(dataTable);
                foreach (UserDTO obj in list)
                {
                    Console.WriteLine(obj.USER_ID);
                }
            }

            return list.Count;
        }

        
        private static void Main(string[] args)
        {

            GetListEmployee();


            Console.Read();
        }
    }
}