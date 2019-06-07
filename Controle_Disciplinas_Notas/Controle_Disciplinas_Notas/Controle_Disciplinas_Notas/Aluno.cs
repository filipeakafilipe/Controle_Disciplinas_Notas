using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Disciplinas_Notas
{
    class Aluno
    {
        // Adicionar GUID Id

        private string _NomeAlu;

        public string NomeAlu
        {
            get { return _NomeAlu; }
            set { _NomeAlu = value; }
        }

        private int _Idade;

        public int Idade
        {
            get { return _Idade; }
            set { _Idade = value; }
        }

        private string _Telefone;

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private int _Ano;

        public int Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }

        private ArrayList _ListaDisciplinas;

        public ArrayList ListaDisciplinas
        {
            get { return _ListaDisciplinas; }
            set { _ListaDisciplinas = value; }
        }
    }
}
