using Raylib_cs;

namespace ElementOras;

public static class ElementVisuals
{
    public static Color GetElementColour(ElementWorld.Elements elementType)
    {
        Color color = new();

        switch (elementType)
        {
            case ElementWorld.Elements.Air:
                color = Color.White;
                break;
            case ElementWorld.Elements.Test:
                color = Color.Magenta;
                break;
            case ElementWorld.Elements.CoolerTest:
                color = Color.Red;
                break;
        }
        
        return color;
    }
}
