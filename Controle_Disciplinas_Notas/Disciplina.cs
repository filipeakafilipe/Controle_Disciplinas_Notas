using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Disciplinas_Notas
{
    class Disciplina
    {
        private string _NomeDisc;

        public string NomeDisc
        {
            get { return _NomeDisc; }
            set { _NomeDisc = value; }
        }

        private ArrayList _NomeNota;

        public ArrayList NomeNota
        {
            get { return _NomeNota; }
            set { _NomeNota = value; }
        }

        private ArrayList _NotaMax;

        public ArrayList NotaMax
        {
            get { return _NotaMax; }
            set { _NotaMax = value; }
        }

        private ArrayList _NotaAluno;

        public ArrayList NotaAluno
        {
            get { return _NotaAluno; }
            set { _NotaAluno = value; }
        }
    }
}
