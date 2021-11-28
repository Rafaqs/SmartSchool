using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Disciplina(){}
        public Disciplina(int iD, string nome, int professorId)
        {
            ID = iD;
            Nome = nome;
            ProfessorId = professorId;
        }
    }
}
