using Raylib_cs;

namespace ElementOras;

public static class UI
{
    //got lazy here so doing this manually
    static Button[] buttons = [
        new(ElementWorld.Elements.Air,false,0,0,Raylib.LoadTexture("textures/elements/air.png")),
        new(ElementWorld.Elements.Water,false,32,0,Raylib.LoadTexture("textures/elements/water.png")),
        new(ElementWorld.Elements.Fire,false,64,0,Raylib.LoadTexture("textures/elements/fire.png")),
        new(ElementWorld.Elements.Plant,true,96,0,Raylib.LoadTexture("textures/elements/plant.png")),
        new(ElementWorld.Elements.Acid,false,160,0,Raylib.LoadTexture("textures/elements/acid.png")),
        new(ElementWorld.Elements.Sand,false,192,0,Raylib.LoadTexture("textures/elements/sand.png")),
        new(ElementWorld.Elements.Wall,false,224,0,Raylib.LoadTexture("textures/elements/wall.png")),
        new(ElementWorld.Elements.Metal,false,256,0,Raylib.LoadTexture("textures/elements/metal.png")),
        new(ElementWorld.Elements.Plastic,true,288,0,Raylib.LoadTexture("textures/elements/plastic.png")),
        //new(ElementWorld.Elements.Infection,false,320,0,Raylib.LoadTexture("textures/elements/infection.png")),
        
        new(ElementWorld.Elements.Test,true,0,32,Raylib.LoadTexture("textures/elements/test.png")),
        new(ElementWorld.Elements.CoolerTest,true,32,32,Raylib.LoadTexture("textures/elements/coolertest.png"))
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
                Dispense.storedElement = button.element;
                Dispense.storedFlammability = button.flammable;
            }
        }
    }
}