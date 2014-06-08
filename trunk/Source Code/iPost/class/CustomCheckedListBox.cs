using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace test
{
    public class CustomCheckedListBox : CheckedListBox
    {
        public CustomCheckedListBox()
        {
            DoubleBuffered = true;
        }
        public List<int> Completionlist = new List<int>();

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            var rect = new Rectangle(e.Bounds.Height, e.Bounds.Top, e.Bounds.Width - e.Bounds.Height, e.Bounds.Height);
            Size checkSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.MixedNormal);
            int dx = (e.Bounds.Height - checkSize.Width) / 2;
            e.DrawBackground();
            bool isChecked = GetItemChecked(e.Index);
            CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(dx, e.Bounds.Top + dx), isChecked ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            Font myFont = e.Font;
            Brush myBrush;
            int i = e.Index;
            if (Completionlist.Contains(i))
            {
                myBrush = Brushes.Black;
                e.Graphics.FillRectangle(Brushes.AntiqueWhite, rect);
            }
            else
            {
                myBrush = Brushes.Black;
            }
            e.Graphics.DrawString(this.Items[i].ToString(), myFont, myBrush, rect, StringFormat.GenericDefault);
        }
    }
}
