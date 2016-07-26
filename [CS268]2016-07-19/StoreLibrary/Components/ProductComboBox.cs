using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreLibrary.Components
{
    public class ProductComboBox : ComboBox
    {
        public ProductComboBox()
            : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0)
            {
                return;
            }
            e.DrawBackground();
            if (this.Items[e.Index] is Product)
            {
                Product product = this.Items[e.Index] as Product;
                Font font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                Brush brush = new SolidBrush(product.Color);
                e.Graphics.DrawString(product.ToString(), font, brush, e.Bounds.X, e.Bounds.Y);
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            e.ItemHeight = 30;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (this.SelectedItem is Product)
            {
                Product product = this.SelectedItem as Product;
                this.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                this.ForeColor = product.Color;
            }
        }
    }
}