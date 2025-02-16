// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:

    //Colour variables
    Color almostBlack = new Color("030206");
    Color deepestBlue = new Color("070918");
    Color deepBlue = new Color("0f052d");
    Color navy = new Color("203671");
    Color babyBlue = new Color("36b5f5");
    Color neonBlue = new Color("3afffb");
    Color teal = new Color("36868f");
    Color green = new Color("5fc75d");
    Color neonGreen = new Color("83c16f");

    //Star variables
    int starCount = 40;
    int[] starPositionsX;
    int[] starPositionsY;

    //Dock variables

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Fishing");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;

        // Generate random star positions
        // First, initialize the array to contain a certain number of elements
        starPositionsX = new int[starCount];
        starPositionsY = new int[starCount];
        // Next, go through array and assign each index a value
        for (int i = 0; i < starCount; i++)
        {
            starPositionsX[i] = Random.Integer(0, 400); // x = 0-400
            starPositionsY[i] = Random.Integer(0, 300); // y = 0-300
        }
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        //Draw sky
        Window.ClearBackground(almostBlack);

        //Draw stars
        Draw.FillColor = neonBlue;
        for (int i = 0; i < starCount; i++)
        {
            Draw.Circle(starPositionsX[i], starPositionsY[i], 2);
        }

        // Added outlines for waves? 
        Draw.LineColor = Color.Black;   // Lines and outline of shape will be black
        Draw.LineSize = 1;              // Lines and outline will be 1 pixel thick


        //Draw dock platform
     


        //Draw dock pillars



    //Draw background waves
        Draw.FillColor = navy;
        for (int i = 0; i < 16; i++)
        {
            int x = 12 + i * 25;
            Draw.Circle(x, Window.Height - 100, 19);
        }

        //Draw midground waves
        Draw.FillColor = teal;
        for (int i = 0; i < 8; i++)
        {
            int x = 25 + i * 50;
            Draw.Circle(x, Window.Height - 65, 38);
        }

        //Draw foreground waves
        Draw.FillColor = deepBlue;
        for (int i = 0; i < 4; i++)
        {
            int x = 50 + i * 100;
            Draw.Circle(x, Window.Height, 75);
        }
    }
}
