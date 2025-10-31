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
            foreach (Element element in ElementWorld.elementGrid)
            {
                element.incapacitated = false;
            }

            //Console.WriteLine("tick");

            if(doTickLoop == false)
            {
                break;
            }
        }
    }
}