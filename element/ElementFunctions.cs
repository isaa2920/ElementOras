namespace ElementOras;

public static class ElementFunctions
{
    public static void TickElement(Element element)
    {
        if (element.incapacitated == true)
        {
            return;
        }
        switch (element.element)
        {
            case ElementWorld.Elements.Air:
                break;
            case ElementWorld.Elements.Water:
                WaterTick(element);
                break;
            case ElementWorld.Elements.Fire:
                FireTick(element);
                break;
            case ElementWorld.Elements.Smoke:
                FireTick(element);
                break;
            case ElementWorld.Elements.Plant:
                PlantTick(element);
                break;
            case ElementWorld.Elements.Flower:
                break;
            case ElementWorld.Elements.Acid:
                AcidTick(element);
                break;
            case ElementWorld.Elements.Sand:
                SandTick(element);
                break;
            case ElementWorld.Elements.Wall:
                break;
            case ElementWorld.Elements.Metal:
                break;
            case ElementWorld.Elements.Plastic:
                break;
            case ElementWorld.Elements.Infection:
                break;
            case ElementWorld.Elements.Test:
                TestElementTick(element);
                break;

            case ElementWorld.Elements.CoolerTest:
                CoolerTestElementTick(element);
                break;
        }
    }

    private static void WaterTick(Element element)
    {
        TransformElement.MoveElementDown(element);
        TransformElement.MoveElementLeft(element);
        TransformElement.MoveElementRight(element);
    }

    private static void FireTick(Element element)
    {
        Random rnd = new();

        Element? targetElement = null;

        int dir = rnd.Next(0, 3);

        switch (dir)
        {
            case 0:
                TransformElement.MoveElementLeft(element);
                break;
            case 1:
                TransformElement.MoveElementUp(element);
                break;
            case 2:
                targetElement = FindElement.FindElementRight(element);
                TransformElement.MoveElementRight(element);
                break;
        }

        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0:
                    targetElement = FindElement.FindElementLeft(element);
                    break;
                case 1:
                    targetElement = FindElement.FindElementUp(element);
                    break;
                case 2:
                    targetElement = FindElement.FindElementRight(element);
                    break;
                case 3:
                    targetElement = FindElement.FindElementDown(element);
                    break;
            }

            if (targetElement != null && targetElement.flammable == true)
            {
                ElementWorld.elementGrid[targetElement.arrayIndex].element = ElementWorld.Elements.Fire;
            }

            if (targetElement != null && targetElement.element == ElementWorld.Elements.Water)
            {
                ElementWorld.elementGrid[element.arrayIndex].element = ElementWorld.Elements.Air;
            }
        }
    }

    private static void PlantTick(Element element)
    {
        Random rnd = new();

        Element? up = FindElement.FindElementUp(element);
        if (up != null)
        {
            if (up.element == ElementWorld.Elements.Plant)
            {
                return;
            }

            if (up.element == ElementWorld.Elements.Flower)
            {
                return;
            }
        }

        int dir = rnd.Next(0, 201);

        if (dir < 198)
        {
            int chance = rnd.Next(0, 100);
            if (chance == 5)
            {
                Element? el = FindElement.FindElementUp(element);
                if (el != null)
                {
                    int flowerChance = rnd.Next(0, 11);
                    if (flowerChance == 10)
                    {
                        ElementWorld.elementGrid[el.arrayIndex].element = ElementWorld.Elements.Flower;
                        return;
                    }
                    ElementWorld.elementGrid[el.arrayIndex].element = ElementWorld.Elements.Plant;
                    return;
                }
            }
        }

        if (dir == 199)
        {
            {
                Element? el = FindElement.FindElementRight(element);
                if (el != null)
                {
                    ElementWorld.elementGrid[el.arrayIndex].element = ElementWorld.Elements.Plant;
                    return;
                }
            }
        }

        if (dir == 198)
        {
            {
                Element? el = FindElement.FindElementLeft(element);
                if (el != null)
                {
                    ElementWorld.elementGrid[el.arrayIndex].element = ElementWorld.Elements.Plant;
                    return;
                }
            }
        }
    }
    
    private static void AcidTick(Element element)
    {
        Element? targetElement = null;

        TransformElement.MoveElementDown(element);
        targetElement = FindElement.FindElementDown(element);
        if (targetElement != null)
        {
            targetElement.element = ElementWorld.Elements.Acid;
        }
        TransformElement.MoveElementLeft(element);
        targetElement = FindElement.FindElementLeft(element);
        if (targetElement != null)
        {
            targetElement.element = ElementWorld.Elements.Air;
        }
        TransformElement.MoveElementRight(element);
        targetElement = FindElement.FindElementRight(element);
        if (targetElement != null)
        {
            targetElement.element = ElementWorld.Elements.Air;
        }
    }

    private static void SandTick(Element element)
    {
        TransformElement.MoveElementDown(element);
    }
    
    private static void TestElementTick(Element element)
    {
        TransformElement.MoveElementUp(element);
    }
    
    private static void CoolerTestElementTick(Element element)
    {
        TransformElement.MoveElementUp(element);
    }
}