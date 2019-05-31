using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controle_Disciplinas_Notas
{
    class AlunoOp
    {
        private string caminhoAluno = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\alunos.xml";
        private string caminhoDisc = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\disciplinas.xml";

        public AlunoOp()
        {

        }

        public AlunoOp(Aluno alu, string nome, int idade, string telefone, int ano)
        {
            // Adicionar id guid, nome, idade, telefone, ano (série)

            alu.NomeAlu = nome;
            alu.Idade = idade;
            alu.Telefone = telefone;
            alu.Ano = ano;

            this.AdicionarAluno(alu);
        }

        public void AdicionarAluno(Aluno alu)
        {
            this.SalvarXmlAluno(alu);
        }

        public List<string> ProcuraAluno(Aluno alu)
        {
            List<string> alunos = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);
            var Consulta = from p in Raiz.Elements("Aluno")
                           orderby (string)p.Element("NomeAlu")
                           select new
                           {
                               Nome = (string)p.Element("NomeAlu")
                           };

            foreach (var x in Consulta)
            {
                alunos.Add(x.Nome);
            }

            return alunos;
        }

        public void AdicionarDisciplina(Disciplina disc, Aluno alu, string NomeDisciplina, string NomeAluno)
        {
            XElement RaizAluno = XElement.Load(caminhoAluno);
            XElement RaizDisc = XElement.Load(caminhoDisc);

            var ConsultaDisc = from P in RaizDisc.Elements("Disciplina")
                               where ((string)P.Element("NomeDisc")).Equals(NomeDisciplina)
                               select P;

            var ConsultaAluno = from p in RaizAluno.Elements("Aluno")
                                where ((string)p.Element("NomeAlu")).Equals(NomeAluno)
                                select p;

            //XElement NomeDisc;
            //XElement NomeProfessor;

            foreach (var x in ConsultaAluno)
            {
                foreach (var y in ConsultaDisc)
                {
                    //NomeDisc = new XElement("NomeDisc", y.Element("NomeDisc"));
                    //NomeProfessor = new XElement("Professor", y.Element("Professor"));

                    XElement DiscAdd = new XElement("Disciplina", y.Element("NomeDisc"), y.Element("Professor"));

                    x.Add(DiscAdd);
                }
            }

            RaizAluno.Save(caminhoAluno);
        }

        public void AdicionarNota(Disciplina disc, Aluno alu, string NomeDisciplina, string NomeAluno, double Nota)
        {

        }

        public void AdicionarNota()
        {

        }

        public void ExcluirNota(Disciplina disc, Aluno alu)
        {

        }

        public void SalvarXmlAluno(Aluno alu)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            XElement NovoAluno = new XElement("Aluno",
                new XElement("NomeAlu", alu.NomeAlu),
                new XElement("Idade", alu.Idade),
                new XElement("Telefone", alu.Telefone),
                new XElement("Ano", alu.Ano));

            Raiz.Add(NovoAluno);

            Raiz.Save(caminhoAluno);
        }
    }
}
