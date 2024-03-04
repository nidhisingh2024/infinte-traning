using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee
    {

        int EmpId;
        string EmpName;
        double EmpSalary;

        Employee()
        {
            EmpId = 100;
            EmpName = "Nidhi";
            EmpSalary = 45000;
        }
        Employee(int eid, string ename, double esal)
        {
            EmpId = eid;
            EmpName = ename;

        }
        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;

        }
        public void {
}
    
}
