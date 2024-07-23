using ExercicioListas.Entities;
using ExercicioListas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            Console.Write("how many employees will be register ? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> ListEmp = new List<Employee>();
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Employee emp = new Employee(name, salary);
                ListEmp.Add(emp);
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Listagem Atualizada de Funcionarios \n");
            foreach (Employee emp in ListEmp)
            {
                Console.WriteLine($"Number: {ListEmp.FindIndex(x => x.Name == emp.Name)}");
                Console.WriteLine($"Id: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name} ");
                Console.WriteLine($"Salary: {emp.Salary} ");
                Console.WriteLine("");
            }
            Console.WriteLine("Enter the employee number that will have salary increase: ");
            int numberF = int.Parse(Console.ReadLine());
            if(numberF >= ListEmp.Count || numberF < 0)
                {
                    throw new EmployeeException("Invalid employee number");
                }
            Console.WriteLine("Inform the Employee's percentage increase");
            double percent = double.Parse(Console.ReadLine());
            ListEmp[numberF].SalaryIncrease(percent);

            Console.WriteLine("\n Listagem Atualizada de Funcionarios \n");
            foreach (Employee emp in ListEmp)
            {
                Console.WriteLine($"Id: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name} ");
                Console.WriteLine($"Salary: {emp.Salary} ");
                Console.WriteLine("");
            }

            }catch (EmployeeException ex)
            {
                Console.WriteLine("Employeer Error: " + ex.Message);
            }
        }
    }
}
