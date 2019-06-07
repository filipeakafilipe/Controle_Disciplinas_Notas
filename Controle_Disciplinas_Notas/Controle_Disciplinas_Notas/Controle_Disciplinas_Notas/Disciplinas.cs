using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Disciplinas_Notas
{
    class Disciplinas
    {
        private ArrayList _ListaDisciplinas;

        public ArrayList ListaDisciplinas
        {
            get { return _ListaDisciplinas; }
            set { _ListaDisciplinas = value; }
        }
    }
}
