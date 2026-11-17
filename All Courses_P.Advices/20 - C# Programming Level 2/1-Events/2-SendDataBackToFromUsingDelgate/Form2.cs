using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Sending data back to a form using a delegate in C# is a common practice for ensuring loose coupling between
//    components in a WinForms application. Here’s a step-by-step explanation and example:

//### **What is a Delegate?**
//A delegate is a type that represents references to methods with a specific parameter list and return type.
//    In this case, we use a delegate to send data from one form to another.
//### **Scenario**
//You have:
//1. A** main form** (`Form1`) that opens another form.
//2. A **child form** (`Form2`) that needs to send data back to `Form1`.

//---

//### **Steps**

//#### 1. Define a Delegate
//Create a delegate in the** child form** to send data.

//```csharp
//public partial class Form2 : Form
//{
//    // Define a delegate
//    public delegate void SendDataDelegate(string data);

//    // Create an event based on the delegate
//    public event SendDataDelegate OnDataSent;

//    public Form2()
//    {
//        InitializeComponent();
//    }

//    private void btnSendData_Click(object sender, EventArgs e)
//    {
//        // Send data back using the delegate
//        string data = txtData.Text; // Assume txtData is a TextBox on Form2
//        OnDataSent?.Invoke(data);

//        // Close Form2
//        this.Close();
//    }
//}
//#### 2. Subscribe to the Delegate in Form1
//In the** main form**, subscribe to the event defined in `Form2`.

//```csharp
//public partial class Form1 : Form
//{
//    public Form1()
//    {
//        InitializeComponent();
//    }

//    private void btnOpenForm2_Click(object sender, EventArgs e)
//    {
//        // Open Form2
//        Form2 form2 = new Form2();

//        // Subscribe to the delegate
//        form2.OnDataSent += ReceiveData;

//        // Show Form2
//        form2.ShowDialog();
//    }

//    private void ReceiveData(string data)
//    {
//        // Handle the received data
//        lblReceivedData.Text = data; // Assume lblReceivedData is a Label on Form1
//    }
//}

//### **How It Works**
//1.When you click the `btnOpenForm2` button in `Form1`, it opens `Form2`.
//2. In `Form1`, you subscribe to the `OnDataSent` event with the `ReceiveData` method.
//3. In `Form2`, when the user clicks the `btnSendData` button, it triggers the `OnDataSent` event and passes the `data` (from the `TextBox`).
//4. The `ReceiveData` method in `Form1` handles the passed data and updates the UI (e.g., the `Label`).


namespace SendDataBackToFromUsingDelgate
{
    public partial class Form2 : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID); // like you subcribe to a service // خدمة

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

  
        public Form2()
        {
            InitializeComponent();
        }

        private void SendDataBack_Click(object sender, EventArgs e)
        {
            int  PersonID  = int.Parse(txtPersonID.Text);

            // Trigger the event to send data back to Form1

            DataBack?.Invoke(this, PersonID);


            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    frm.textBox1.Text = txtPersonID.Text;
        //}
    }
}
