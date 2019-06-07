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
        public Disciplina()
        {
            //_Codigo = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
            // SALVAR NO XML
        }

        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

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

        private string _NomeAtividade;

        public string NomeAtividade
        {
            get { return _NomeAtividade; }
            set { _NomeAtividade = value; }
        }

        private string _NotaMax;

        public string NotaMax
        {
            get { return _NotaMax; }
            set { _NotaMax = value; }
        }

        private string _NotaAluno;

        public string NotaAluno
        {
            get { return _NotaAluno; }
            set { _NotaAluno = value; }
        }

        //private ArrayList _Data;

        //public ArrayList Data
        //{
        //    get { return _Data; }
        //    set { _Data = value; }
        //}

        //private ArrayList _Horario;

        //public ArrayList Horario
        //{
        //    get { return _Horario; }
        //    set { _Horario = value; }
        //}

        //private ArrayList _NotaAluno;

        //public ArrayList NotaAluno
        //{
        //    get { return _NotaAluno; }
        //    set { _NotaAluno = value; }
        //}
    }
}
