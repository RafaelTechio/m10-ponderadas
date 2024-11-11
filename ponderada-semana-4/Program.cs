using System;
using System.Diagnostics.Metrics;
using System.Threading;

class Program
{
    static Meter s_meter = new Meter("HatCo.Store");
    static Counter<int> s_hatsSold = s_meter.CreateCounter<int>("hatco.store.hats_sold");

    static void Main(string[] args)
    {
        Console.WriteLine("Press any key to exit");

        var metrics = new HatCoMetrics();

        while(!Console.KeyAvailable)
        {
            // Simulação de venda de 4 chapéus por segundo
            Thread.Sleep(1000);
            s_hatsSold.Add(4);
        }
    }
}

public class HatCoMetrics
{
    private readonly Counter<int> _hatsSold;

    public HatCoMetrics()
    {
        var meter = new Meter("HatCo.Store");
        _hatsSold = meter.CreateCounter<int>("hatco.store.hats_sold");
    }

    public void HatsSold(int quantity)
    {
        _hatsSold.Add(quantity);
    }
}
