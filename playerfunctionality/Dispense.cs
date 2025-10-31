using System.Numerics;
using Raylib_cs;

namespace ElementOras;

public static class Dispense
{
    public static ElementWorld.Elements storedElement = ElementWorld.Elements.Air;
    public static bool storedFlammability = false;

    public static void DispenseStoredElement()
    {
        Vector2 mousePos = Raylib.GetMousePosition();
        
        //got lazy so more abominations
        int mX = (int)mousePos.X / 4;
        if(mX < 0)
        {
            mX = 0;
        } else if (mX > ElementWorld.GridSizeX)
        {
            mX = ElementWorld.GridSizeX;
        }
        int mY = (int)(mousePos.Y - 128) / 4;
        if (mY > ElementWorld.GridSizeY)
        {
            mY = ElementWorld.GridSizeY;
        } else if(!(mY < 0))
        {
            int index = mX;
            index += mY * ElementWorld.GridSizeX;

            Element element = new();
            element.arrayIndex = index;
            element.element = storedElement;
            element.flammable = storedFlammability;

            ElementWorld.elementGrid[index] = element;
        }
    }
}