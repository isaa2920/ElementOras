namespace ElementOras;

public static class FindElement
{
    public static Element? FindElementUp(Element element)
    {
        int target = element.arrayIndex - ElementWorld.GridSizeX;

        if (target < 0)
        {
            return null;
        }

        return ElementWorld.elementGrid[target];
    }

    public static Element? FindElementDown(Element element)
    {
        int target = element.arrayIndex + ElementWorld.GridSizeX;

        if (target > ElementWorld.GridTotal)
        {
            return null;
        }

        return ElementWorld.elementGrid[target];
    }

    public static Element? FindElementLeft(Element element)
    {
        int target = element.arrayIndex - 1;

        int indexX = target;

        while (indexX > ElementWorld.GridSizeX)
        {
            indexX -= ElementWorld.GridSizeX;
        }

        if (indexX > 1)
        {
            return null;
        }

        return ElementWorld.elementGrid[target];
    }
    
    public static Element? FindElementRight(Element element)
    {
        int target = element.arrayIndex + 1;

        int indexX = target;
        
        while (indexX > ElementWorld.GridSizeX)
        {
            indexX -= ElementWorld.GridSizeX;
        }
        
        if (indexX > ElementWorld.GridSizeX)
        {
            return null;
        }

        return ElementWorld.elementGrid[target];
    }
}