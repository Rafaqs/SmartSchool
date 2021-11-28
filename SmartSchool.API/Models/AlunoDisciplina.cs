using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {        
        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

        public AlunoDisciplina(){}
        public AlunoDisciplina(int alunoID, int disciplinaID)
        {
            AlunoID = alunoID;
            DisciplinaID = disciplinaID;
        }
    }
}
