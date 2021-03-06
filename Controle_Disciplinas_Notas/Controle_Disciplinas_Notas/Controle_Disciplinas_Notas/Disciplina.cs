﻿using System;
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

        private string _Professor;

        public string Professor
        {
            get { return _Professor; }
            set { _Professor = value; }
        }

        private ArrayList _NomeAtividade;

        public ArrayList NomeAtividade
        {
            get { return _NomeAtividade; }
            set { _NomeAtividade = value; }
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
