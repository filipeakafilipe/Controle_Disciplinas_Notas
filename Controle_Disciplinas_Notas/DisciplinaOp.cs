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
        private string caminhoAluno = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\alunos.xml";
        private string caminhoDisc = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\disciplinas.xml";
        //private IEnumerable<XElement> DiscSelecionada { get; set; }

        public DisciplinaOp()
        {

        }

        public DisciplinaOp(Disciplina disc)
        {

        }

        public DisciplinaOp(Disciplina disc, string NomeDisc, string Prof)
        {
            // Adicionar o nome, professor

            // Seria bom dar um aviso quando o Xml for salvo, para falar que foi um sucesso

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
                               Nome = (string)p.Element("NomeDisc")
                           };

            foreach (var x in Consulta)
            {
                discs.Add(x.Nome);
            }

            return discs;
        }

        public List<string> ProcuraAtividade(Disciplina disc, string nomeDisc)
        {
            List<string> atividades = new List<string>();

            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from p in Raiz.Elements("Disciplina")
                           where ((string)p.Element("NomeDisc")).Equals(nomeDisc)
                           select p;

            return Consulta.Elements("NomeAtividade").Select(x => x.Value.ToString()).ToList();

            //var Consulta = from p in Raiz.Elements("Disciplina")
            //               where ((string)p.Element("NomeDisc").Value).Equals(nomeDisc)
            //               select p.Elements("NomeAtividade");

            //foreach (var x in Consulta)
            //{
            //    foreach(var y in x)
            //    {
            //        atividades.Add((string)y.Element("NomeAtividade").Value);
            //    }
            //}

            //return atividades;
            //return Consulta.Select(item => item.ToString()).ToList();

            //foreach(var x in Consulta)
            //{
            //    atividades.Add();
            //}

            //var Consulta = from p in Raiz.Elements("Disciplina")
            //               orderby (string)p.Element("NomeAtividade")
            //               where ((string)p.Element("NomeDisc")).Equals(nomeDisc)
            //               //select new
            //               //{
            //               //    NomeAtividade = p.Elements("NomeAtividade")
            //               //};
            //               //select p.Elements("NomeAtividade");
            //               select p;
            //               //select new
            //               //{
            //               //    NomeAtividade = p.Elements("NomeAtividade")
            //               //    //NomeAtividade = p.Elements("NomeAtividade")
            //               //};

            //var Consulta2 = from x in Consulta.Elements("Disciplina")
            //                select new
            //                {
            //                    NomeAtividade = (string)x.Element("NomeAtividade")
            //                };

            //foreach(var x in Consulta2)
            //{
            //    atividades.Add(x.NomeAtividade);
            //}

            //foreach (var x in Consulta)
            //{
            //    //atividades.Add(x.NomeAtividade.ToString());
            //    atividades.Add(x.NomeAtividade);
            //}

            //{
            //    NomeAtividade = p.Element("NomeAtividade")
            //};

            //for (int i = 0; i < Consulta.Count(); i++)
            //{
            //    atividades.Add(Consulta.ElementAt(i).ToString());
            //}

            //foreach(var x in Consulta)
            //{
            //    atividades.Add(x.NomeAtividade);
            //}

            //atividades.ToList().ForEach(i => atividades.Add(i.ToString()));

            //return atividades;
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

        public void AdicionarAtividade(Disciplina disc, string NomeDisciplina, string NomeAtividade, double NotaMax/*, IEnumerable<XElement> Consulta*/)
        {
            XElement Raiz = XElement.Load(caminhoDisc);

            var Consulta = from P in Raiz.Elements("Disciplina")
                           where ((string)P.Element("NomeDisc")).Equals(NomeDisciplina)
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
                x.Add(NovaAtividade);
                //x.Add("NomeAtividade", NomeAtividade);
                NovaNota = new XElement("NotaMax", NotaMax);
                x.Add(NovaNota);
                //x.Add("NotaMax", NotaMax);

                //Raiz.AppendChild(NovaAtividade);
            }

            Raiz.Save(caminhoDisc);

            //this.SalvaXmlAtividade(disc, NomeAtividade, NotaMax);
        }

        public void AlterarDisciplina(Disciplina disc)
        {

        }

        public void AlterarAtividade(Disciplina disc)
        {

        }

        public void ExcluirDisciplina(Disciplina disc)
        {

        }

        public void ExcluirAtividade(Disciplina disc)
        {

        }

        public void ListarDisciplina(Disciplina disc)
        {

        }

        private void SalvaXmlDisc(Disciplina disc)
        {
            XElement Raiz = XElement.Load(caminhoDisc);

            XElement NovaDisciplina = new XElement("Disciplina",
                new XElement("NomeDisc", disc.NomeDisc),
                new XElement("Professor", disc.Professor));

            Raiz.Add(NovaDisciplina);

            Raiz.Save(caminhoDisc);
        }

        private void ConsultaXmlDisc(Disciplina disc)
        {

        }

        //private void SalvaXmlAtividade(Disciplina disc, string NomeAtividade, double NotaMax/*, IEnumerable<XElement> Consulta*/)
        //{
        //    XElement Raiz = XElement.Load(caminho);

        //    //XElement NovaAtividade = new XElement("NomeAtividade", NomeAtividade,
        //    //    new XElement("NotaMax", NotaMax));

        //    foreach (var x in DiscSelecionada)
        //    {
        //        x.Add("NomeAtividade", NomeAtividade);
        //        x.Add("NotaMax", NotaMax);
        //    }
        //}
    }
}
