namespace ElementOras.element;

public static class ElementFunctions
{
    public static void TickElement(Element element)
    {
        switch (element.element)
        {
            case ElementWorld.Elements.Air:
                break;

            case ElementWorld.Elements.Test:
                TestElementTick();
                break;

            case ElementWorld.Elements.CoolerTest:
                TestElementTick();
                break;
        }
    }

    private static void TestElementTick()
    {
        Console.WriteLine("TestElement");
    }
    
    private static void CoolerTestElementTick()
    {
        Console.WriteLine("CoolerTestElement");
    }
}