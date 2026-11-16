using System;
using System.Threading.Tasks;

class CustomEventArrgs : EventArgs
{
    public int parameter1 { get; set; }
    public string parameter2 { get; set; }
    public CustomEventArrgs(int parameter1, string parameter2)
    {
        this.parameter1 = parameter1;
        this.parameter2 = parameter2;
    }
}

class program
{
    public delegate void CallackEventHandler(object sender, CustomEventArrgs e);
    public static event CallackEventHandler callBackEvent;

    static async Task Main()
    {
        callBackEvent += OncallBackEvent;

        Task performtask = PerformAsyncOperation(callBackEvent);

        await performtask;

        Console.WriteLine($"Done...");
        Console.ReadKey();
    }

    static async Task PerformAsyncOperation(CallackEventHandler callback)
    {
        await Task.Delay(2000);

        CustomEventArrgs eventArgs = new CustomEventArrgs(42, "Hello from event");

        callback?.Invoke(null, eventArgs);
    }
    static void OncallBackEvent(object sender, CustomEventArrgs e)
    {
        Console.WriteLine($"parameter1 is {e.parameter1} and parameter2 is {e.parameter2}");
    }
}

