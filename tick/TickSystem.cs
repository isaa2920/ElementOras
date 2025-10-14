namespace ElementOras.tick;

public static class TickSystem
{
    public static bool doTickLoop = true;
    
    public static void TickLoop()
    {
        while (true)
        {
            Thread.Sleep(100);
            //Console.WriteLine("tick");

            if(doTickLoop == false)
            {
                break;
            }
        }
    }
}