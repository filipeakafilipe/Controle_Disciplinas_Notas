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
        //private string caminhoAluno = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\alunos.xml";
        private string caminhoDisc = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\disciplinas.xml";
        //private IEnumerable<XElement> DiscSelecionada { get; set; }

        public DisciplinaOp()
        {

        }

        public DisciplinaOp(Disciplina disc)
        {

        }

        public DisciplinaOp(/*Disciplina disc, */string NomeDisc, string Prof)
        {
            // Adicionar o nome, professor

            // Seria bom dar um aviso quando o Xml for salvo, para falar que foi um sucesso

            Disciplina disc = new Disciplina();

            disc.Codigo = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
            disc.NomeDisc = NomeDisc;
            disc.Professor = Prof;

            // Adicionar data e horário

            this.AdicionaDisciplina(disc);
        }

        public void AdicionaDisciplina(Disciplina disc)
        {
            this.SalvaXmlDisc(disc);
        }

        public List<string> ProcuraDisciplina(Disciplina disc)
        {
            // Retorna um ArrayList com as disciplinas

            //ArrayList discs = new ArrayList();
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

        public List<string> ProcuraAtividade(Disciplina disc, string codDisc)
        {
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

            //return Consulta.Elements("NomeAtividade").Select(x => x.Value.ToString()).ToList();
        }

        //public /*IEnumerable<XElement>*/ void SelecionaDisciplina(string NomeDisciplina)
        //{
        //    XElement Raiz = XElement.Load(caminho);

        //    var Consulta = from P in Raiz.Elements("Disciplina")
        //                   where ((string)P.Element("NomeDisc")).Equals(NomeDisciplina)
        //                   select P;

        //    DiscSelecionada = Consulta;
        //    //return Consulta;
        //}

        //public IEnumerable<XElement> RetornaConsulta(IEnumerable<XElement> Consulta)
        //{
        //    return Consulta;
        //}

        public void AdicionarAtividade(Disciplina disc, string codDisc, string NomeAtividade, double NotaMax/*, IEnumerable<XElement> Consulta*/)
        {
            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from P in Raiz.Elements("Disciplina")
                           where ((string)P.Element("Codigo")).Equals(codDisc)
                           select P;

            XElement NovaAtividade;
            XElement NovaNota;

            //XElement NovaAtividade = new XElement("NomeAtividade", NomeAtividade,
            //    new XElement("NotaMax", NotaMax));

            foreach (var x in Consulta)
            {
                //x.Element("NomeAtividade").Add(NomeAtividade);
                //x.Element("NotaMax").Add(NotaMax);

                NovaAtividade = new XElement("NomeAtividade", NomeAtividade);
                //x.Add(NovaAtividade);
                //x.Add("NomeAtividade", NomeAtividade);
                NovaNota = new XElement("NotaMax", NotaMax);
                XElement AtividadeAdd = new XElement("Atividade", NovaAtividade, NovaNota);
                x.Add(AtividadeAdd);
                //x.Add(NovaNota);
                //x.Add("NotaMax", NotaMax);

                //Raiz.AppendChild(NovaAtividade);
            }

            Raiz.Save(caminhoDisc);

            //this.SalvaXmlAtividade(disc, NomeAtividade, NotaMax);
        }

        public void AlterarDisciplina(string codDisc, string nomeDiscNovo, string nomeProfessor)
        // Fazer um overload 1: nomeDisc, 2: nomeProfessor, 3: nomeDisc, nomeProfessor
        {
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
            // ControleListarDisciplina

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

        private void SalvaXmlDisc(Disciplina disc)
        {
            XElement Raiz = XElement.Load(caminhoDisc);

            XElement NovaDisciplina = new XElement("Disciplina",
                new XElement("Codigo", disc.Codigo),
                new XElement("NomeDisc", disc.NomeDisc),
                new XElement("Professor", disc.Professor));

            Raiz.Add(NovaDisciplina);

            Raiz.Save(caminhoDisc);
        }
    }
}
