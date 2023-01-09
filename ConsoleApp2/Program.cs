using ConsoleApp2;
using System;

namespace HelloWorld
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Console.WriteLine("Ingrese su codigo de acceso");
            string code = Console.ReadLine();
            patient.Access = code;
            Console.WriteLine("Ingrese su nombre");
            string name = Console.ReadLine();
            patient.name = name;
            Console.WriteLine("Ingrese su apellido");
            string surName = Console.ReadLine();
            patient.surName = surName;
            Console.WriteLine("Ingrese su edad");
            string age = Console.ReadLine();
            patient.age = Int32.Parse(age);
            List<string> doctorList = new List<string>();
            doctorList.Add("Tenma");
            doctorList.Add("Emiliano");
            doctorList.Add("Wite");
            Console.WriteLine("Seleccione el numero de su doctor:");
            for (int i = 0; i < doctorList.Count; i++)
            {
                Console.WriteLine($"{i} {doctorList[i]}");
            }
            string doctorIndex = Console.ReadLine();
            patient.doctor = doctorList[Int32.Parse(doctorIndex)];
            Console.WriteLine("Planilla del paciente: ");
            Console.WriteLine(patient.getParientForm());
        }
    }
 
}