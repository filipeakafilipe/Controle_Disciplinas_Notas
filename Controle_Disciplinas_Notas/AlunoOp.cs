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

        public List<string> ProcuraAluno(Aluno alu/*posso apagar isso, nem usei*/)
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

        //public List<string> ProcuraAtividade(string nomeDisc)
        //{
        //    List<string> atividades = new List<string>();

        //    XElement Raiz = XElement.Load(caminhoDisc);

        //    var Consulta = from p in Raiz.Elements("Disciplina")
        //                   where ((string)p.Element("NomeDisc")).Equals(nomeDisc)
        //                   select p;

        //    var Consulta2 = from p in Consulta.Elements("Atividade")
        //                    select new
        //                    {
        //                        Nome = (string)p.Element("NomeAtividade")
        //                    };

        //    foreach (var x in Consulta2)
        //    {
        //        atividades.Add(x.Nome);
        //    }

        //    return atividades;
        //}

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

        public List<string> ProcuraDiscAluno(string nomeAluno)
        {
            List<string> disciplinas = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(nomeAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            select new
                            {
                                Nome = (string)P.Element("NomeDisc")
                            };

            foreach (var x in Consulta2)
            {
                disciplinas.Add(x.Nome);
            }

            return disciplinas;
        }

        public List<string> ProcuraAtvAluno(/*string nomeDisc, */string NomeAluno, string nomeDisc)
        {
            List<string> atividades = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(NomeAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("NomeDisc")).Equals(nomeDisc)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            select new
                            {
                                Nome = (string)P.Element("NomeAtividade")
                            };

            foreach (var x in Consulta3)
            {
                atividades.Add(x.Nome);
            }

            return atividades;
        }

        public void AdicionarNota(string NomeDisciplina, string NomeAluno, string NomeAtividade, double Nota)
        {
            XElement RaizAluno = XElement.Load(caminhoAluno);

            var ConsultaAluno = from P in RaizAluno.Elements("Aluno")
                                where ((string)P.Element("NomeAlu")).Equals(NomeAluno)
                                select P;

            var Consulta2 = from P in ConsultaAluno.Elements("Disciplina")
                            where ((string)P.Element("NomeDisc")).Equals(NomeDisciplina)
                            //where ((string)P.Element("NomeAtividade")).Equals(NomeAtividade)
                            select P;

            foreach (var x in Consulta2)
            {
                XElement NomeAtividadeAdd = new XElement("NomeAtividade", NomeAtividade);
                //x.Add(Atividade);
                XElement NotaAdd = new XElement("NotaAluno", Nota);
                XElement Atividade = new XElement("Atividade", NomeAtividadeAdd, NotaAdd);
                //x.Add(NotaAdd);
                x.Add(Atividade);
            }

            RaizAluno.Save(caminhoAluno);
        }

        public void ExcluirAluno(string NomeAluno)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(NomeAluno)
                           select P;

            foreach (var x in Consulta)
            {
                x.Element("NomeAlu").Parent.Remove();
            }

            Raiz.Save(caminhoAluno);
        }

        public void AlterarAluno(string NomeAluno, string NomeAlunoNovo, string Idade, string Telefone, string Ano)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(NomeAluno)
                           select P;

            foreach (var x in Consulta)
            {
                x.SetElementValue("NomeAlu", NomeAlunoNovo);
                x.SetElementValue("Idade", Idade);
                x.SetElementValue("Telefone", Telefone);
                x.SetElementValue("Ano", Ano);
            }

            Raiz.Save(caminhoAluno);
        }

        public void ExcluirDiscplinaAluno(string NomeAluno, string nomeDisciplina)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(NomeAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("NomeDisc")).Equals(nomeDisciplina)
                            select P;

            foreach (var x in Consulta2)
            {
                x.Element("NomeDisc").Parent.Remove();
            }

            Raiz.Save(caminhoAluno);
        }

        public void ExcluirAtividadeAluno(string nomeAluno, string nomeDisciplina, string nomeAtividade)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(nomeAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("NomeDisc")).Equals(nomeDisciplina)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            where ((string)P.Element("NomeAtividade")).Equals(nomeAtividade)
                            select P;

            foreach (var x in Consulta3)
            {
                x.Element("NomeAtividade").Parent.Remove();
            }
            Raiz.Save(caminhoAluno);
        }

        public void AlterarAtividadeNota(string nomeAluno, string nomeDisciplina, string nomeAtividade, string Nota)
        {
            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("NomeAlu")).Equals(nomeAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("NomeDisc")).Equals(nomeDisciplina)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            where ((string)P.Element("NomeAtividade")).Equals(nomeAtividade)
                            select P;

            foreach (var x in Consulta3)
            {
                x.SetElementValue("NotaAluno", Nota);
            }

            Raiz.Save(caminhoAluno);
        }

        public void ListarAlunos()
        {
            // ControleListarAluno
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
