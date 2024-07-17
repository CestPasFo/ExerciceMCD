using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DB.Classes
{
    internal class Technician
    {
        private int _id_technician;
        private String _name;
        private String _surname;
        private int _tel;

        static private int _id_count = 0;

        public int Id_technician { get => _id_technician; }
        public String Name { get => _name; set => _name = value; }
        public String Surname { get => _surname; set => _surname = value; }
        public int Telephone { get => _tel; set => _tel = value; }

        public Technician(String name, String surname, int telephone)
        {
            _id_technician = _id_count;
            Name = name;
            Surname = surname;
            Telephone = telephone;

            _id_count++;
        }
    }
}