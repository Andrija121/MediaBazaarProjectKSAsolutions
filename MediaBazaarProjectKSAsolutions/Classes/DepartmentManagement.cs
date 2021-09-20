using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class DepartmentManagement
    {
        List<Department> departments = new List<Department>();
        List<User> users = new List<User>();

        public DepartmentManagement()
        {

        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }
        public void RemoveDepartmentAtIndex(int dIndex)
        {
            departments.RemoveAt(dIndex);
        }
        public Department GetDepartment(int id)
        {
            foreach (var department in departments)
            {
                if(department.Id==id)
                {
                    return department;
                }
            }
            return null;
        }
    }
}
