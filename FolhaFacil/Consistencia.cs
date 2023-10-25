using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil
{
    class Consistencia
    {
        #region LimparCampos

        public static void limparcampos2(Control frmlimpar2)
        {

            foreach (Control controle in frmlimpar2.Controls)
            {
                if (controle is TextBox || controle is ComboBox)
                {
                    controle.Text = string.Empty;
                }
            }
        }
        #endregion
    }
}
