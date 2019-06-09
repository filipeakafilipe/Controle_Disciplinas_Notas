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
        private string caminhoAluno = @"dados/alunos.xml";
        private string caminhoDisc = @"dados/disciplinas.xml";
        // Caminho: Controle_Disciplinas_Notas/Controle_Disciplinas_Notas/bin/Debug/dados

        public AlunoOp()
        {

        }

        public AlunoOp(Aluno alu, string nome, int idade, string telefone, int ano)
        {
            // Cadastra um novo aluno

            alu.Codigo = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
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

        public void SalvarXmlAluno(Aluno alu)
        {
            // Salva o novo aluno no arquivo XML alunos.xml

            XElement Raiz = XElement.Load(caminhoAluno);

            XElement NovoAluno = new XElement("Aluno",
                new XElement("Codigo", alu.Codigo),
                new XElement("NomeAlu", alu.NomeAlu),
                new XElement("Idade", alu.Idade),
                new XElement("Telefone", alu.Telefone),
                new XElement("Ano", alu.Ano));

            Raiz.Add(NovoAluno);

            Raiz.Save(caminhoAluno);
        }

        public List<string> ProcuraAluno()
        {
            // Procura alunos e retorna uma List de string para ser usado em um Combobox

            List<string> alunos = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);
            var Consulta = from p in Raiz.Elements("Aluno")
                           orderby (string)p.Element("NomeAlu")
                           select new
                           {
                               Codigo = (string)p.Element("Codigo"),
                               Nome = (string)p.Element("NomeAlu")
                           };

            foreach (var x in Consulta)
            {
                alunos.Add(x.Codigo + " - " + x.Nome);
            }

            return alunos;
        }

        public void AdicionarDisciplina(string codDisc, string codAluno)
        {
            // Adiciona uma nova disciplina para um aluno

            XElement RaizAluno = XElement.Load(caminhoAluno);
            XElement RaizDisc = XElement.Load(caminhoDisc);

            var ConsultaDisc = from P in RaizDisc.Elements("Disciplina")
                               where ((string)P.Element("Codigo")).Equals(codDisc)
                               select P;

            var ConsultaAluno = from p in RaizAluno.Elements("Aluno")
                                where ((string)p.Element("Codigo")).Equals(codAluno)
                                select p;

            foreach (var x in ConsultaAluno)
            {
                foreach (var y in ConsultaDisc)
                {
                    XElement DiscAdd = new XElement("Disciplina", y.Element("Codigo"), y.Element("NomeDisc"), y.Element("Professor"));

                    x.Add(DiscAdd);
                }
            }

            RaizAluno.Save(caminhoAluno);
        }

        public List<string> ProcuraDiscAluno(string codAluno)
        {
            // Procura disciplinas cursadas por um aluno e retorna uma List de string para ser utilizado em um Combobox

            List<string> disciplinas = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            select new
                            {
                                Codigo = (string)P.Element("Codigo"),
                                Nome = (string)P.Element("NomeDisc")
                            };

            foreach (var x in Consulta2)
            {
                disciplinas.Add(x.Codigo + " - " + x.Nome);
            }

            return disciplinas;
        }

        public List<string> ProcuraAtvAluno(string codAluno, string codDisc)
        {
            // Procura as atividades de uma disciplina cursada por um aluno e retorna uma List de string para ser usado em um Combobox

            List<string> atividades = new List<string>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            select new
                            {
                                Codigo = (string)P.Element("Codigo"),
                                Nome = (string)P.Element("NomeAtividade")
                            };

            foreach (var x in Consulta3)
            {
                atividades.Add(x.Nome);
            }

            return atividades;
        }

        public void AdicionarNota(string codDisc, string codAluno, string NomeAtividade, double Nota)
        {
            // Adiciona a nota de uma atividade de uma disciplina cursada por um aluno

            XElement RaizAluno = XElement.Load(caminhoAluno);

            var ConsultaAluno = from P in RaizAluno.Elements("Aluno")
                                where ((string)P.Element("Codigo")).Equals(codAluno)
                                select P;

            var Consulta2 = from P in ConsultaAluno.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            foreach (var x in Consulta2)
            {
                XElement NomeAtividadeAdd = new XElement("NomeAtividade", NomeAtividade);
                XElement NotaAdd = new XElement("NotaAluno", Nota);
                XElement Atividade = new XElement("Atividade", NomeAtividadeAdd, NotaAdd);
                x.Add(Atividade);
            }

            RaizAluno.Save(caminhoAluno);
        }

        public void ExcluirAluno(string codAluno)
        {
            // Exclui um aluno e seus campos

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            foreach (var x in Consulta)
            {
                x.Element("Codigo").Parent.Remove();
            }

            Raiz.Save(caminhoAluno);
        }

        public void AlterarAluno(string codAluno, string NomeAlunoNovo, string Idade, string Telefone, string Ano)
        {
            // Altera os campos de um aluno

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
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

        public void ExcluirDiscplinaAluno(string codAluno, string codDisc)
        {
            // Exclui uma disciplina cursada por um aluno

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            foreach (var x in Consulta2)
            {
                x.Element("Codigo").Parent.Remove();
            }

            Raiz.Save(caminhoAluno);
        }

        public void ExcluirAtividadeAluno(string codAluno, string codDisc, string nomeAtividade)
        {
            // Exclui uma atividade de uma disciplina cursada por um aluno

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
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

        public void AlterarAtividadeNota(string codAluno, string codDisc, string nomeAtividade, string Nota)
        {
            // Altera a nota de uma atividade de uma disciplina cursada por um aluno

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
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

        public string[] DadosAluno(string codAluno)
        {
            // Retorna um vetor de strings com os dados básicos de um aluno para ser mostrado no Controle pessoal do Aluno

            XElement Raiz = XElement.Load(caminhoAluno);
            string[] Dados = new string[5] { "", "", "", "", "" };

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select new
                           {
                               Codigo = (string)P.Element("Codigo"),
                               Nome = (string)P.Element("NomeAlu"),
                               Idade = (string)P.Element("Idade"),
                               Telefone = (string)P.Element("Telefone"),
                               Ano = (string)P.Element("Ano")
                           };

            foreach (var x in Consulta)
            {
                Dados[0] = x.Codigo;
                Dados[1] = x.Nome;
                Dados[2] = x.Idade;
                Dados[3] = x.Telefone;
                Dados[4] = x.Ano;
            }

            return Dados;
        }

        public List<Aluno> ListarAlunos()
        {
            // Retorna uma lista com os dados de um aluno, disciplinas, atividades, notas, etc. para ser mostrado em um DataGridView

            List<Aluno> alu = new List<Aluno>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta1 = from P in Raiz.Elements("Aluno")
                            select new
                            {
                                Codigo = (string)P.Element("Codigo"),
                                Nome = (string)P.Element("NomeAlu"),
                                Idade = (int)P.Element("Idade"),
                                Telefone = (string)P.Element("Telefone"),
                                Ano = (int)P.Element("Ano"),
                                discs = P.Elements("Disciplina").ToList()
                            };

            var Consulta2 = from P in Consulta1.Select(x => x.discs)
                            select P;

            foreach (var x in Consulta1)
            {
                int cont1 = Consulta2.Count();

                if (cont1 == 0)
                {
                    alu.Add(new Aluno
                    {
                        Codigo = x.Codigo,
                        NomeAlu = x.Nome,
                        Idade = x.Idade,
                        Telefone = x.Telefone,
                        Ano = x.Ano,
                        Disc = (new Disciplina
                        {
                            NomeDisc = "",
                            NomeAtividade = "",
                            NotaAluno = ""
                        })
                    });
                }
                else
                {
                    var Consulta3 = from P in x.discs
                                    select new
                                    {
                                        NomeD = (string)P.Element("NomeDisc"),
                                        NomeP = (string)P.Element("Professor"),
                                        Atvs = P.Elements("Atividade").ToList()
                                    };

                    foreach (var y in Consulta3)
                    {
                        int cont2 = y.Atvs.Count();

                        if (cont2 == 0)
                        {
                            alu.Add(new Aluno
                            {
                                Codigo = x.Codigo,
                                NomeAlu = x.Nome,
                                Idade = x.Idade,
                                Telefone = x.Telefone,
                                Ano = x.Ano,
                                Disc = (new Disciplina
                                {
                                    NomeDisc = y.NomeD,
                                    Professor = y.NomeP,
                                    NomeAtividade = "",
                                    NotaAluno = ""
                                })
                            });
                        }
                        else
                        {
                            for (int i = 0; i < cont2; i++)
                            {
                                alu.Add(new Aluno
                                {
                                    Codigo = x.Codigo,
                                    NomeAlu = x.Nome,
                                    Idade = x.Idade,
                                    Telefone = x.Telefone,
                                    Ano = x.Ano,
                                    Disc = (new Disciplina
                                    {
                                        NomeDisc = y.NomeD,
                                        Professor = y.NomeP,
                                        NomeAtividade = y.Atvs[i].Element("NomeAtividade").Value.ToString(),
                                        NotaAluno = y.Atvs[i].Element("NotaAluno").Value.ToString()
                                    })
                                });
                            }
                        }
                    }
                }
            }

            return alu;
        }

        public List<Aluno> ListarDiscAluno(string codAluno, string codDisc)
        {
            // Retorna uma lista com as atividades e notas de uma disciplina cursada por um aluno para ser mostrado em um DataGridView

            List<Aluno> alu = new List<Aluno>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            select new
                            {
                                Nome = (string)P.Element("NomeAtividade"),
                                NotaAluno = (string)P.Element("NotaAluno")
                            };

            foreach (var x in Consulta3)
            {
                alu.Add(new Aluno
                {
                    Disc = new Disciplina
                    {
                        NomeAtividade = x.Nome,
                        NotaAluno = x.NotaAluno
                    }
                });
            }

            return alu;
        }

        public List<Aluno> NotasAluno(string codAluno, string codDisc)
        {
            // Retorna uma lista com as notas de uma disciplina de um aluno

            List<Aluno> alu = new List<Aluno>();

            XElement Raiz = XElement.Load(caminhoAluno);

            var Consulta = from P in Raiz.Elements("Aluno")
                           where ((string)P.Element("Codigo")).Equals(codAluno)
                           select P;

            var Consulta2 = from P in Consulta.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta3 = from P in Consulta2.Elements("Atividade")
                            select new
                            {
                                NotaAluno = (string)P.Element("NotaAluno")
                            };

            foreach (var x in Consulta3)
            {
                alu.Add(new Aluno
                {
                    Disc = new Disciplina
                    {
                        NotaAluno = x.NotaAluno
                    }
                });
            }

            return alu;
        }
    }
}
