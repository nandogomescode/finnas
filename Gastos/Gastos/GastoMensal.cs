using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalBaseConnections;

namespace Gastos.GastosMensais
{
    public class GastoMensal : Connection
    {

        public GastoMensal() { }

        public void GastoMensalService()
        {

            ExcecuteQuery("SELECT * FROM GastosMensais");

        }

    }
}
