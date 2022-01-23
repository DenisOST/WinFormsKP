using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsKP
{
    public class Doctor : Person
    {
        private string Specialization = "";
        public Doctor() : base("", "", "")
        {
            Specialization = "";
        }
        public Doctor(string surname, string name, string patronymic, string specialization) : base(surname, name, patronymic)
        {
            Specialization = specialization;
        }
        public string GetSpecialization()
        {
            return Specialization;
        }
        public void SetSpecialization(string specialization)
        {
            Specialization = specialization;
        }

        public override string Info()
        {
            return "ФИО и специализация доктора: " + Surname + " " + Name + " " + Patronymic + ", " + Specialization;
        }
    }
}
