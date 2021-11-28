using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Professor
    {
       
        public int ID { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public Professor(){}
        public Professor(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }
    }
}
