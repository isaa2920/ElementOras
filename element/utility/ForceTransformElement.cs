namespace ElementOras;

public static class ForceTransformElement
{
    public static void ForceMoveElementUp(Element element)
    {
        if (element.arrayIndex > ElementWorld.GridSizeX)
        {
            int target = element.arrayIndex - ElementWorld.GridSizeX;
            if(target > ElementWorld.GridTotal - 1 || target < 0)
            {
                return;
            }
            ElementWorld.Elements storedSwapElement = ElementWorld.elementGrid[target].element;
                ElementWorld.elementGrid[target].element = element.element;
                ElementWorld.elementGrid[element.arrayIndex].element = storedSwapElement;
            
        }
    }

    public static void ForceMoveElementDown(Element element)
    {
        if (element.arrayIndex < ElementWorld.GridSizeY * ElementWorld.GridSizeX - ElementWorld.GridSizeX)
        {
            int target = element.arrayIndex + ElementWorld.GridSizeX;
            if(target > ElementWorld.GridTotal - 1 || target < 0)
            {
                return;
            }

            ElementWorld.Elements storedSwapElement = ElementWorld.elementGrid[target].element;
            ElementWorld.Elements storedSelfElement = ElementWorld.elementGrid[element.arrayIndex].element;

            
                ElementWorld.elementGrid[element.arrayIndex].element = storedSwapElement;
                ElementWorld.elementGrid[target].element = storedSelfElement;
            

            if (!(storedSwapElement == storedSelfElement))
            {
                ElementWorld.elementGrid[target].incapacitated = true;
            }
        }
    }

    public static void ForceMoveElementLeft(Element element)
    {
        if (element.arrayIndex > ElementWorld.GridSizeX)
        {
            int target = element.arrayIndex - 1;
            if(target > ElementWorld.GridTotal - 1 || target < 0)
            {
                return;
            }
            ElementWorld.Elements storedSwapElement = ElementWorld.elementGrid[target].element;
            
            int indexX = element.arrayIndex;
            while (indexX > ElementWorld.GridSizeX)
            {
                indexX -= ElementWorld.GridSizeX;
            }
            if (indexX > 1)
            {
                ElementWorld.elementGrid[target].element = element.element;
                ElementWorld.elementGrid[element.arrayIndex].element = storedSwapElement;
            }
        
        }
    }
    
    public static void ForceMoveElementRight(Element element)
    {
        if (element.arrayIndex > ElementWorld.GridSizeX)
        {
            int target = element.arrayIndex + 1;
            if(target > ElementWorld.GridTotal - 1 || target < 0)
            {
                return;
            }
            ElementWorld.Elements storedSwapElement = ElementWorld.elementGrid[target].element;
            ElementWorld.Elements storedSelfElement = ElementWorld.elementGrid[element.arrayIndex].element;
            
            int indexX = element.arrayIndex;
            while (indexX > ElementWorld.GridSizeX)
            {
                indexX -= ElementWorld.GridSizeX;
            }
            if (indexX < ElementWorld.GridSizeX)
            {
                ElementWorld.elementGrid[target].element = element.element;
                ElementWorld.elementGrid[element.arrayIndex].element = storedSwapElement;
            }
            if (!(storedSwapElement == storedSelfElement))
            {
                ElementWorld.elementGrid[target].incapacitated = true;
            }
            
        }
    }
}
