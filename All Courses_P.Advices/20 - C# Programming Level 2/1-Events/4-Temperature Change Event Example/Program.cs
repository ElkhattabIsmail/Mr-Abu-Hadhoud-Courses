using System;

public class TemperatureChangedEventArgs : EventArgs  // My BackBag
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }
    public double Diffrence { get; }


    public TemperatureChangedEventArgs(double OldTemperature ,double NewTemperature)
    {
        this.OldTemperature = OldTemperature;
        this.NewTemperature = NewTemperature;
        this.Diffrence = NewTemperature - OldTemperature;

    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    private double OldTemperature;
    private double currentTemperature;

    public void SetTemperature(double newTemperature)
    {

        if (newTemperature != currentTemperature)
        {
            OldTemperature = currentTemperature;
            currentTemperature = newTemperature;
            OnTemperatureChanged(OldTemperature, currentTemperature);
        }
    }

    private void OnTemperatureChanged(double OldTemperature, double currentTemperature)
    {
        OnTemperatureChanged (new TemperatureChangedEventArgs (OldTemperature, currentTemperature));

    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e); // the Invoke Save the Address of Subscribe Method
    }

}


public class Display
{
    // subscribe the event with this method
    public void Subscribe(Thermostat thermostat) // the subscribe means take the ref of this method with delegate and call it when
        // you raise the event in Thermostat class
    {
        thermostat.TemperatureChanged += HandleTemperatureChange;  // سجلي هذه الميتود عندك لما تتغير درجة الحرارة ناديها
        // This is a Delegation
    }

    // باختصار انه صار حدث وتم تبليغك عنه
    public void HandleTemperatureChange(object sender, TemperatureChangedEventArgs e) // Normal Method 
        // but the arguments must be Match the event in Thermostat class  
        // Signiture Match event Signiture
    {
        Console.WriteLine("\n\nTemperature changed:");
        Console.WriteLine($"Temperature changed from {e.OldTemperature}°C");
        Console.WriteLine($"Temperature changed to {e.NewTemperature}°C");
        Console.WriteLine($"Temperature Differance to {e.Diffrence}°C");

        if (e.NewTemperature > 90)
        {
            Console.WriteLine("Warning 🔥🔥🔥!");
        }
        // You free to do anything you want here with this parameters inside 
    }

}


public class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat(); // new object 
        Display display = new Display(); // new object 

        display.Subscribe(thermostat); // Subscribe the two objects / group them

        thermostat.SetTemperature(25);

        thermostat.SetTemperature(95);

        thermostat.SetTemperature(10);

        thermostat.SetTemperature(30);
        thermostat.SetTemperature(91);

        Console.ReadLine();

    }
}
