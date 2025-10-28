namespace ElementOras;

public static class ElementFunctions
{
    public static void TickElement(Element element)
    {
        switch (element.element)
        {
            case ElementWorld.Elements.Air:
                break;

            case ElementWorld.Elements.Test:
                TestElementTick(element);
                break;

            case ElementWorld.Elements.CoolerTest:
                CoolerTestElementTick(element);
                break;
        }
    }

    private static void TestElementTick(Element element)
    {
        TransformElement.MoveElementVertical(element, 1);
    }
    
    private static void CoolerTestElementTick(Element element)
    {
        TransformElement.MoveElementVertical(element, -1);
    }
}