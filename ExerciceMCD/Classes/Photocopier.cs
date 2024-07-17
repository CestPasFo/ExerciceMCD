
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DB.Classes
{
    internal class Photocopier
    {
        private int _id_photocopier;
        private String _model;
        private bool _is_failing;

        static private int _id_count = 0;

        public int Id_photocopier { get => _id_photocopier; }
        public String Model { get => _model; set => _model = value; }
        public bool Is_failing { get => _is_failing; set => _is_failing = value; }

        public Photocopier(String model, bool is_failing)
        {
            _id_photocopier = _id_count;
            Model = model;
            Is_failing = is_failing;

            _id_count++;
        }
    }
}
