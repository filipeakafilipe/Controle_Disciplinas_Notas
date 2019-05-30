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
        private string caminho = @"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\disciplinas.xml";
        private IEnumerable<XElement> DiscSelecionada { get; set; }

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

            XElement Raiz = XElement.Load(caminho);
            var Consulta = from p in Raiz.Elements("Disciplina")
                           orderby (string)p.Element("NomeDisc")
                           select new
                           {
                               Nome = (string)p.Element("NomeDisc")
                           };

            // foreach aqui e lá
            foreach(var x in Consulta)
            {
                discs.Add(x.Nome);
            } 

            return discs;
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

        //public void AdicionarAtividade(Disciplina disc, string NomeAtividade, double NotaMax/*, IEnumerable<XElement> Consulta*/)
        //{
        //    this.SalvaXmlAtividade(disc, NomeAtividade, NotaMax);
        //}

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
            XElement Raiz = XElement.Load(caminho);

            XElement NovaDisciplina = new XElement("Disciplina",
                new XElement("NomeDisc", disc.NomeDisc),
                new XElement("Professor", disc.Professor));

            Raiz.Add(NovaDisciplina);

            Raiz.Save(caminho);
        }

        private void ConsultaXmlDisc(Disciplina disc)
        {

        }

        //private void SalvaXmlAtividade(Disciplina disc, string NomeAtividade, double NotaMax/*, IEnumerable<XElement> Consulta*/)
        //{
        //    XElement Raiz = XElement.Load(caminho);

        //    //XElement NovaAtividade = new XElement("NomeAtividade", NomeAtividade,
        //    //    new XElement("NotaMax", NotaMax));

        //    foreach(var x in DiscSelecionada)
        //    {
        //        x.Add("NomeAtividade", NomeAtividade);
        //        x.Add("NotaMax", NotaMax);
        //    }
        //}
    }
}
