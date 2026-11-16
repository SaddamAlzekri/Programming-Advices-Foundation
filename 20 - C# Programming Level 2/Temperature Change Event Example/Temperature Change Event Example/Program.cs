using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{
    public class TemeratureChangedEventArrgs : EventArgs
    {
        public double OldTemerature { set; get; }
        public double NewTemerature { set; get; }
        public double Defferent { set; get; }

        public TemeratureChangedEventArrgs(double OldTemerature, double NewTemerature)
        {
            this.OldTemerature = OldTemerature;
            this.NewTemerature = NewTemerature;
            this.Defferent = NewTemerature - OldTemerature;
        }
    }

    public class Thermostate
    {
        public event EventHandler<TemeratureChangedEventArrgs> TemperatureChannged;

        private double OldTemperature;
        private double CurrentTemperature;

        public void SetTemperature(double NewTemperature)
        {
            if(NewTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = NewTemperature;
                onTemperatureChannged(OldTemperature, CurrentTemperature);
            }
        }

        private void onTemperatureChannged(double OldTemperature,double CurrentTemperature)
        {
            onTemperatureChannged(new TemeratureChangedEventArrgs(OldTemperature, CurrentTemperature));
        }

        protected virtual void onTemperatureChannged(TemeratureChangedEventArrgs e)
        {
            if(TemperatureChannged != null)
            {
                TemperatureChannged.Invoke(this, e);
            }
        }
    }

    public class Display
    {

        public void Subscribe(Thermostate thermostat)
        {
            thermostat.TemperatureChannged += HandleTemperatureChange;
        }

        public void HandleTemperatureChange(object sender, TemeratureChangedEventArrgs e)
        {
            Console.WriteLine("\n\nTemperature changed:");

            Console.WriteLine("Temperature changed from { " + e.OldTemerature + "}°C");
            Console.WriteLine("Temperature changed to {" + e.NewTemerature + "}°C");
            Console.WriteLine("Temperature Differance to {" + e.Defferent + "}°C");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Thermostate thermostat = new Thermostate();
            Display display = new Display();

            display.Subscribe(thermostat);

            thermostat.SetTemperature(25);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);

            Console.ReadLine();
        }
    }
}
