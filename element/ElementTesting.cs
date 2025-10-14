namespace ElementOras.element;

public static class ElementTesting
{
    public static void AddRandomElements()
    {
        Random rnd = new();
        //test element
        for (int i = 0; i < 200; i++)
        {
            int index = rnd.Next(0, ElementWorld.GridTotal);
            ElementWorld.elementGrid[index].element = ElementWorld.Elements.Test;
        }

        //cooler test element
        for (int i = 0; i < 200; i++)
        {
            int index = rnd.Next(0, ElementWorld.GridTotal);
            ElementWorld.elementGrid[index].element = ElementWorld.Elements.CoolerTest;
        }
    }
}