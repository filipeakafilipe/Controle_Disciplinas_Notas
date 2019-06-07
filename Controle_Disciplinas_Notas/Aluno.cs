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

        public Aluno()
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

        private string _NomeAlu;

        public string NomeAlu
        {
            get { return _NomeAlu; }
            set { _NomeAlu = value; }
        }

        private int _Idade;
        // Trocar idade para data de nascimento?
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
        // Série
        public int Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }

        private Disciplina _Disc;

        public Disciplina Disc
        {
            get { return _Disc; }
            set { _Disc = value; }
        }

        public Aluno(Disciplina disc)
        {
            _Disc = Disc;
        }

        public string NomeDisc
        {
            get { return _Disc.NomeDisc; }
        }

        public string Professor
        {
            get { return _Disc.Professor; }
        }

        public string NomeAtividade
        {
            get { return _Disc.NomeAtividade; }
        }

        public string NotaAluno
        {
            get { return _Disc.NotaAluno; }
        }
    }
}
