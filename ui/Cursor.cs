using System.Numerics;
using Raylib_cs;

namespace ElementOras;

public static class Cursor
{
    public static Texture2D cursor = Raylib.LoadTexture("textures/cursor.png");
    public static Texture2D clickCursor = Raylib.LoadTexture("textures/cursor-dispense.png");

    public static void DrawCursor()
    {
        Vector2 pos = Raylib.GetMousePosition();
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            Raylib.DrawTexture(clickCursor, (int)pos.X + 3, (int)pos.Y + 3, Color.Gray);
        }
        else
        {
            Raylib.DrawTexture(cursor, (int)pos.X + 3, (int)pos.Y + 3, Color.Gray);
        }
    }
}