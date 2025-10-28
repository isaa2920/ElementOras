using Raylib_cs;

namespace ElementOras;

public static class UI
{
    //got lazy here so doing this manually
    static Button[] buttons = [
        new(ElementWorld.Elements.Air,0,0,Raylib.LoadTexture("textures/elements/air.png")),
        new(ElementWorld.Elements.Air,32,0,Raylib.LoadTexture("textures/elements/test.png")),
        new(ElementWorld.Elements.Air,64,0,Raylib.LoadTexture("textures/elements/coolertest.png"))
    ];
    
    public static void DrawUI()
    {
        Raylib.DrawRectangle(0, 0, Program.WindowSizeX, 128, Color.Black);
        foreach (Button button in buttons)
        {
            button.Draw();
            bool pressed = button.CheckPressed(Raylib.GetMousePosition(), Raylib.IsMouseButtonPressed(MouseButton.Left));
            if (pressed == true)
            {
                Console.WriteLine("pressed!!!!");
            }
        }
    }
}