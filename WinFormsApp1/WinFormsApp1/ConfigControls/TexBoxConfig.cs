using Krypton.Toolkit;
using AppUsuario.PL.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsuario.PL.ConfigControls
{
    public class TexBoxConfig : IConfigurableControl
    {
        public virtual void ConfigureControl(object control)
        {
            if(!(control is KryptonTextBox))
            {
                return;
            }

            KryptonTextBox _text = (KryptonTextBox)control;
            _text.StateCommon.Back.Color1 = System.Drawing.Color.White;
            _text.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            _text.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            _text.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _text.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            _text.StateCommon.Border.Rounding = 20F;
            _text.StateCommon.Border.Width = 1;
            _text.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            _text.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _text.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            _text.TabIndex = 2;
        }
        

        
    }
}
