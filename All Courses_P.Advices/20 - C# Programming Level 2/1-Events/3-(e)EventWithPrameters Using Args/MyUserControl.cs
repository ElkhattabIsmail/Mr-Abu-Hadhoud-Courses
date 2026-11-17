using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithPrameters
{
    public partial class MyUserControl : UserControl
    {

        //this is the old code....commented.

        //// Define a custom event handler delegate with parameters
        //public event Action<int> OnCalculationComplete;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void CalculationComplete(int PersonID)
        //{
        //    Action<int> handler = OnCalculationComplete;
        //    if (handler != null)
        //    {
        //        handler(PersonID); // Raise the event with the parameter
        //    }
        //}



        // Backbag CalculationCompleteEventArgs as a class , and you can name it 
        // any name you want it .
        // it stores any arguments you wanna pass it.

        public class CalculationCompleteEventArgs : EventArgs  // inherits EventArgs
        {
            // Read Only Properties
            public int Results { get; }
            public int Val1 { get; }
            public int Val2 { get; }

            // Parameterized constructor
            public CalculationCompleteEventArgs(int Results, int Val1, int Val2)
            {
                this.Results = Results;
                this.Val1 = Val1;
                this.Val2 = Val2;
            }
        }

        // Define an event handler from CalculationCompleteEventArgs Type ( The Class );
        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete; // OnCalculationComplete اسم الإيفنت  

        public void RaiseOnCalulationComplete(int Results, int Val1, int Val2) // for fulling the Object
        {
            RaiseOnCalulationComplete(new CalculationCompleteEventArgs(Results, Val1, Val2));
        }

        // Virtual Function with e as a parameter
        protected virtual void RaiseOnCalulationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e); // Invoke event With Parameter 1.This Form 2.e -> CalculationCompleteEventArgs class
        }




        public MyUserControl()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            int Val1,Val2;
            Val1 = Convert.ToInt32(txtNumber1.Text);
            Val2 = Convert.ToInt32(txtNumber2.Text);

            int Result = Val1  + Val2;
            lblResult.Text = Result.ToString();

            if (OnCalculationComplete != null)
                // Raise the event with a parameter
                RaiseOnCalulationComplete(Result, Val1, Val2);  // Call the RaiseOnCalulationComplete(int Results, int Val1, int Val2) first
        }
    }
}
