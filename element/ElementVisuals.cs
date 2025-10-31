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
            case ElementWorld.Elements.Water:
                color = Color.SkyBlue;
                break;
            case ElementWorld.Elements.Fire:
                color = Color.Orange;
                break;
            case ElementWorld.Elements.Plant:
                color = Color.DarkGreen;
                break;
            case ElementWorld.Elements.Flower:
                color = Color.Pink;
                break;
            case ElementWorld.Elements.Acid:
                color = Color.Green;
                break;
            case ElementWorld.Elements.Sand:
                color = Color.Beige;
                break;
            case ElementWorld.Elements.Wall:
                color = Color.Black;
                break;
            case ElementWorld.Elements.Metal:
                color = Color.Gray;
                break;
            case ElementWorld.Elements.Plastic:
                color = Color.LightGray;
                break;
            case ElementWorld.Elements.Infection:
                color = Color.Magenta;
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
