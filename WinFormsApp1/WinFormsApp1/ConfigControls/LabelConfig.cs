using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;
using AppUsuario.PL.BaseTypes;


namespace AppUsuario.PL.ConfigControls
{
    internal class LabelConfig : IConfigurableControl
    {
        public virtual void ConfigureControl(object control)
        {
            if(!(control is KryptonLabel))
            {
                return;
            }

            KryptonLabel _lbl = (KryptonLabel)control;
            _lbl.Size = new System.Drawing.Size(407, 21);
            _lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            _lbl.StateCommon.ShortText.Color2 = System.Drawing.Color.Gray;
            _lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _lbl.TabIndex = 1;
        }

        public virtual void lblTitulo(object control)
        {
            if(!(control is KryptonLabel))
            {
                return; 
            }

            KryptonLabel _lblTitulo = (KryptonLabel)control;
            _lblTitulo.Size = new System.Drawing.Size(173, 31);
            _lblTitulo.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            _lblTitulo.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            _lblTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            _lblTitulo.TabIndex = 0;
        }

        public virtual void lblRegistro(object control)
        {
            if(!(control is KryptonLabel))
            {
                return;
            }
            KryptonLabel _lbl = (KryptonLabel)control;
            _lbl.Size = new System.Drawing.Size(40, 21);
            _lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            _lbl.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            _lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _lbl.TabIndex = 1;
        }

        public virtual void lblBusqueDni(object control)
        {
            if (!(control is KryptonLabel))
            {
                return;
            }

            KryptonLabel _txt = (KryptonLabel)control;
            _txt.Size = new System.Drawing.Size(127, 25);
            _txt.StateCommon.ShortText.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            _txt.TabIndex = 8;
        }
    }
}
