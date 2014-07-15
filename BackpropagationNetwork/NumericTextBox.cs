using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BackpropagationNetwork
{
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();

            this.KeyPress += NumericTextBox_KeyPress;
            this.Enter += NumericTextBox_Enter;
        }

        void NumericTextBox_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => SelectAll()));
        }

        void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo numberFormatInfo =
                System.Globalization.NumberFormatInfo.CurrentInfo;

            var decimalSeperator = numberFormatInfo.CurrencyDecimalSeparator;
            var groupSeperator = numberFormatInfo.CurrencyGroupSeparator;
            var negativeSign = numberFormatInfo.NegativeSign;

            var keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
            }
            else if (keyInput.Equals(decimalSeperator)
                || keyInput.Equals(groupSeperator)
                || keyInput.Equals(negativeSign))
            {
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        public int IntValue
        {
            get
            {
                return Int32.Parse(this.Text);
            }
        }

        public double DoubleValue
        {
            get
            {
                return Double.Parse(this.Text);
            }
        }

        public decimal DecimalValue
        {
            get
            {
                return Decimal.Parse(this.Text);
            }
        }
    }
}
