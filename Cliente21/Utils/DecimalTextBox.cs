using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cliente21.Utils
{
    internal class DecimalTextBox : TextBox
    {
        public DecimalTextBox()
        {
            this.MaxLength = 20;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (this.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (this.Text.IndexOf(',') > -1)
            {
                int decimalIndex = this.Text.IndexOf(',');
                if (this.Text.Length - decimalIndex > 3)
                {
                    this.Text = this.Text.Substring(0, decimalIndex + 3);
                    this.SelectionStart = this.Text.Length;
                }
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);


            if (double.TryParse(this.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
            {

                string formattedValue = value.ToString("0,##", CultureInfo.InvariantCulture);
                if (formattedValue.IndexOf(',') == -1 || formattedValue.Length - formattedValue.IndexOf(',') - 1 < 2)
                {
                    this.Text = value.ToString("0,00", CultureInfo.InvariantCulture);
                }
                else
                {
                    this.Text = formattedValue;
                }
            }
        }

    }
}
