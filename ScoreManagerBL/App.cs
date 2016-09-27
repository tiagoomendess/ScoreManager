using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerBL
{
    public static class App
    {
        public static void GeraPastas()
        {
            try
            {
                ScoreManagerDL.FicheirosIO.CriaPastas();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
