using Application_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Test.Services
{
    public class DataServices
    {
        public static List<Employee> GetAllEmployess() =>
           new List<Employee>
           {
                new Employee { Name="Hao Zi Zhang", LastName="Turner", Age=35, Gender="Male"},
                new Employee { Name="Yu Chen", LastName="Markus", Age=22, Gender="Female"},
                new Employee { Name="Jian Zhi Chu", LastName="Martins", Age=40, Gender="Male"},
                new Employee { Name="ElderJames", LastName="Packner", Age=30, Gender="Female"},
                new Employee { Name="BlaZui", LastName="Doe", Age=45, Gender="Male"}
           };
    }
}
