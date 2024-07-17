using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DB.Classes
{
    internal class Client
    {
        private int _id_client;
        private String _name;
        private String _surname;
        private String _email;
        private int _tel;
        private String _address;

        static private int _id_count = 0;


        public int Id_client { get => _id_client; }
        public String Name { get => _name; set => _name = value; }
        public String Surname { get => _surname; set => _surname = value; }
        public String Email { get => _email; set => _email = value; }
        public int Telephone { get => _tel; set => _tel = value; }
        public string Address { get => _address; set => _address = value; }

        public Client(String name, String surname, String email, int telephone, String address)
        {
            _id_client = _id_count;
            Name = name;
            Surname = surname;
            Email = email;
            Telephone = telephone;
            Address = address;

            _id_count++;
        }
    }
}