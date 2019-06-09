using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Controle_Disciplinas_Notas
{
    class DisciplinaOp
    {
        private string caminhoDisc = @"dados/disciplinas.xml";
        // Caminho: Controle_Disciplinas_Notas/Controle_Disciplinas_Notas/bin/Debug/dados

        public DisciplinaOp()
        {

        }

        public DisciplinaOp(Disciplina disc)
        {

        }

        public DisciplinaOp(string NomeDisc, string Prof)
        {
            // Cadastra uma nova disciplina

            Disciplina disc = new Disciplina();

            disc.Codigo = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
            disc.NomeDisc = NomeDisc;
            disc.Professor = Prof;

            this.AdicionaDisciplina(disc);
        }

        public void AdicionaDisciplina(Disciplina disc)
        {
            this.SalvaXmlDisc(disc);
        }

        private void SalvaXmlDisc(Disciplina disc)
        {
            // Salva uma nova disciplina no arquivo XML disciplinas.xml

            XElement Raiz = XElement.Load(caminhoDisc);

            XElement NovaDisciplina = new XElement("Disciplina",
                new XElement("Codigo", disc.Codigo),
                new XElement("NomeDisc", disc.NomeDisc),
                new XElement("Professor", disc.Professor));

            Raiz.Add(NovaDisciplina);

            Raiz.Save(caminhoDisc);
        }

        public List<string> ProcuraDisciplina()
        {
            // Procura disciplinas e retorna uma List de string com elas para serem usadas em um Combobox

            List<string> discs = new List<string>();

            XElement Raiz = XElement.Load(caminhoDisc);
            var Consulta = from p in Raiz.Elements("Disciplina")
                           orderby (string)p.Element("NomeDisc")
                           select new
                           {
                               Codigo = (string)p.Element("Codigo"),
                               Nome = (string)p.Element("NomeDisc")
                           };

            foreach (var x in Consulta)
            {
                discs.Add(x.Codigo + " - " + x.Nome);
            }

            return discs;
        }

        public List<string> ProcuraAtividade(string codDisc)
        {
            // Procura atividades de uma disciplina e retorna uma List de string com elas para serem usadas em um Combobox

            List<string> atividades = new List<string>();

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from p in Raiz.Elements("Disciplina")
                           where ((string)p.Element("Codigo")).Equals(codDisc)
                           select p;

            var Consulta2 = from p in Consulta.Elements("Atividade")
                            select new
                            {
                                Nome = (string)p.Element("NomeAtividade")
                            };

            foreach (var x in Consulta2)
            {
                atividades.Add(x.Nome);
            }

            return atividades;
        }

        public void AdicionarAtividade(string codDisc, string NomeAtividade, double NotaMax)
        {
            // Adiciona uma nova atividade em uma certa disciplina

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from P in Raiz.Elements("Disciplina")
                           where ((string)P.Element("Codigo")).Equals(codDisc)
                           select P;

            XElement NovaAtividade;
            XElement NovaNota;

            foreach (var x in Consulta)
            {
                NovaAtividade = new XElement("NomeAtividade", NomeAtividade);
                NovaNota = new XElement("NotaMax", NotaMax);
                XElement AtividadeAdd = new XElement("Atividade", NovaAtividade, NovaNota);
                x.Add(AtividadeAdd);
            }

            Raiz.Save(caminhoDisc);
        }

        public void AlterarDisciplina(string codDisc, string nomeDiscNovo, string nomeProfessor)
        {
            // Altera os campos de uma disciplina, o código é inalterável

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from P in Raiz.Elements("Disciplina")
                           where ((string)P.Element("Codigo")).Equals(codDisc)
                           select P;

            foreach (var x in Consulta)
            {
                x.SetElementValue("NomeDisc", nomeDiscNovo);
                x.SetElementValue("Professor", nomeProfessor);
            }

            Raiz.Save(caminhoDisc);
        }

        public void AlterarAtividade(string codDisc, string nomeAtividade, string nomeAtividadeNovo, string nota)
        {
            // Altera os campos de uma atividade em uma certa disciplina

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta1 = from P in Raiz.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta2 = from P in Consulta1.Elements("Atividade")
                            where ((string)P.Element("NomeAtividade")).Equals(nomeAtividade)
                            select P;

            foreach (var x in Consulta2)
            {
                x.SetElementValue("NomeAtividade", nomeAtividadeNovo);
                x.SetElementValue("NotaMax", nota);
            }

            Raiz.Save(caminhoDisc);
        }

        public void ExcluirDisciplina(string codDisc)
        {
            // Exclui uma determinada disciplina e suas atividades

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from P in Raiz.Elements("Disciplina")
                           where ((string)P.Element("Codigo")).Equals(codDisc)
                           select P;

            foreach (var x in Consulta)
            {
                x.Element("Codigo").Parent.Remove();
            }

            Raiz.Save(caminhoDisc);
        }

        public void ExcluirAtividade(string codDisc, string nomeAtividade)
        {
            // Exclui uma atividade de uma certa disciplina

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta1 = from P in Raiz.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta2 = from P in Consulta1.Elements("Atividade")
                            where ((string)P.Element("NomeAtividade")).Equals(nomeAtividade)
                            select P;

            foreach (var x in Consulta2)
            {
                x.Element("NomeAtividade").Parent.Remove();
            }

            Raiz.Save(caminhoDisc);
        }

        public List<Disciplina> ListarDisciplinas()
        {
            // Retorna uma lista com cada disciplina, atividade, etc. para ser mostrado em um DataGridView

            List<Disciplina> Discs = new List<Disciplina>();

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta1 = from P in Raiz.Elements("Disciplina")
                            select new
                            {
                                Codigo = (string)P.Element("Codigo"),
                                Nome = (string)P.Element("NomeDisc"),
                                Prof = (string)P.Element("Professor"),
                                Discs = P.Elements("Atividade").ToList()
                            };

            foreach (var x in Consulta1)
            {
                int cont = x.Discs.Count();

                if (cont == 0)
                {
                    Discs.Add(new Disciplina
                    {
                        Codigo = x.Codigo,
                        NomeDisc = x.Nome,
                        Professor = x.Prof,
                        NomeAtividade = "",
                        NotaMax = ""
                    });
                }
                else
                {
                    for (int i = 0; i < cont; i++)
                    {
                        Discs.Add(new Disciplina
                        {
                            Codigo = x.Codigo,
                            NomeDisc = x.Nome,
                            Professor = x.Prof,
                            NomeAtividade = x.Discs[i].Element("NomeAtividade").Value.ToString(),
                            NotaMax = x.Discs[i].Element("NotaMax").Value.ToString()
                        });
                    }
                }
            }

            return Discs;
        }

        public List<double> NotasDisc(string codDisc)
        {
            // Retorna uma lista com as notas máximas de cada atividade de uma disciplina

            XElement Raiz = XElement.Load(caminhoDisc);

            List<double> notas = new List<double>();

            var Consulta1 = from P in Raiz.Elements("Disciplina")
                            where ((string)P.Element("Codigo")).Equals(codDisc)
                            select P;

            var Consulta2 = from P in Consulta1.Elements("Atividade")
                            select P;

            foreach(var x in Consulta2)
            {
                notas.Add((double.Parse(x.Element("NotaMax").Value)));
            }

            return notas;
        }
    }
}
