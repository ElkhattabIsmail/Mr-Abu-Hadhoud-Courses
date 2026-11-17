using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyCustomTextBox : TextBox
    {
        public MyCustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        // cmnt
        bool _Isrequired;
        [Category("IsRequired"), Description("Check if Data Is Required")]

        public bool
            Isrequired
        {
            get
            {
                return _Isrequired;
            }
            set
            {
                _Isrequired = value;
                if (_Isrequired)
                {
                    Validating += ValidatingTexbox;
                }
                else
                {
                    Validating -= ValidatingTexbox;
                }
            }
        }


        public enum enData { Number = 0, Text = 1 }
        enData _DataRequired;

        [Category("DataType"), Description("IT Check if datatype is Required")]
        public enData DataRequired
        {
            get
            {
                return _DataRequired;
            }

            set
            {
                _DataRequired = value;
                switch (_DataRequired)
                {
                    case enData.Number:
                        this.KeyPress += NumberKeyIsPressed;
                        this.KeyPress -= TextKeyIsPressed;
                        break;
                    case enData.Text:
                        this.KeyPress -= NumberKeyIsPressed;
                        this.KeyPress += TextKeyIsPressed;
                        break;
                }
            }

        }

        public void NumberKeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public void TextKeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public void ValidatingTexbox(object sender, CancelEventArgs e)
        {
            if (Text.Trim() == "")
            {
                MessageBox.Show("Please enter data");
                e.Cancel = true;
            }
        }

        // PA
        //public bool IsRequired
        //{ get; set; }

        //public enum InputTypeEnum { TextInput, NumberInput }

        //public InputTypeEnum InputType
        //{ get; set; } = InputTypeEnum.TextInput;


        //private bool IsNumeric()
        //{
        //    string s = this.Text.Trim();
        //    foreach (char c in s)
        //    {
        //        if (!char.IsDigit(c) && c != '.')
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //public Boolean IsValid()
        //{
        //    if (IsRequired)
        //    {
        //        if (this.Text.Trim().Length == 0)
        //            return false;
        //    }

        //    if (InputType == InputTypeEnum.NumberInput)
        //    {

        //        return IsNumeric();
        //    }

        //    return true;
        //}



    }
}
