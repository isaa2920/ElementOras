using Raylib_cs;

namespace ElementOras.element;

public static class ElementVisuals
{
    public static Color GetElementColour(ElementWorld.Elements elementType)
    {
        Color color = new();

        switch (elementType)
        {
            case ElementWorld.Elements.Air:
                color = Color.Gray;
                break;
            case ElementWorld.Elements.Test:
                color = Color.Black;
                break;
            case ElementWorld.Elements.CoolerTest:
                color = Color.Orange;
                break;
        }
        
        return color;
    }
}
