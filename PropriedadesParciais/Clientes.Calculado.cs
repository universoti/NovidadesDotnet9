using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesParciais
{
    public partial class Clientes
    {
        private decimal _valorAcrescido = 0.20m;

        public partial decimal ValorLimiteCred
        {
            get
            {
                return ValorLimiteCred * _valorAcrescido;

            }

        }
    }
}
