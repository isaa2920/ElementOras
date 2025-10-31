using System.Numerics;
using Raylib_cs;

namespace ElementOras;

public class Button
{
    public ElementWorld.Elements element;
    public bool flammable;
    
    public int posX;
    public int posY;

    public Texture2D tex;

    public void Draw()
    {
        Raylib.DrawTexture(tex, posX, posY, Color.White);
    }

    public Button(ElementWorld.Elements elem, bool flame, int x, int y, Texture2D texture)
    {
        element = elem;
        flammable = flame;
        
        posX = x;
        posY = y;
        tex = texture;
    }

    public bool CheckPressed(Vector2 mousePos, bool mousePressed)
    {
        Rectangle collider = new(posX, posY, tex.Width, tex.Height);
        if (Raylib.CheckCollisionPointRec(mousePos, collider) && mousePressed == true)
        {
            return true;
        }
        return false;
    }
}