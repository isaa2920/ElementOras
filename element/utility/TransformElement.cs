namespace ElementOras;

public static class TransformElement
{
    public static void MoveElementVertical(Element element, int dir)
    {
        if (element.arrayIndex > ElementWorld.GridSizeX)
        {
            //Console.WriteLine($"moving {element.element} up");
            int target = element.arrayIndex - ElementWorld.GridSizeX;
            ElementWorld.Elements storedSwapElement = ElementWorld.elementGrid[target].element;
            if (storedSwapElement == ElementWorld.Elements.Air)
            {
                ElementWorld.elementGrid[target].element = element.element;
                ElementWorld.elementGrid[element.arrayIndex].element = storedSwapElement;
            }
        }
    }
}