namespace ElementOras;

public static class TickSystem
{
    public static bool doTickLoop = true;
    
    public static void TickLoop()
    {
        while (true)
        {
            Thread.Sleep(20);
            foreach (Element element in ElementWorld.elementGrid)
            {
                ElementFunctions.TickElement(element);
            }

            //Console.WriteLine("tick");

            if(doTickLoop == false)
            {
                break;
            }
        }
    }
}