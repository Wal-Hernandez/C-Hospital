using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Patient
    {
        private string access;
        public string Access
        {
            get { return access; }   // get method
            set { access = value; }
        }
        public string name;
        public string surName;
        public int age;
        public string hospital;
        public string doctor;
        public string emergencyRoom;
        public Patient()
        {
          
            hospital = "Eisler Memorial Hospital";
            emergencyRoom = "The void";
        }
        public string getParientForm()
        {
            return $"Nombre: {name}" +
                $"{Environment.NewLine}Apellido: {surName}" +
                $"{Environment.NewLine}Edad: {age}" +
                $"{Environment.NewLine}Hospital: {hospital}" +
                $"{Environment.NewLine}doctor: {doctor}" +
                $"{Environment.NewLine}Token: {Access}" +
                $"{Environment.NewLine}sala: {emergencyRoom}";
        }
    }
}
