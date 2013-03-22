using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                //if (i == 7)//Task 10 -> the first block that the ball hits is exploadable
                //{
                //    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                //}
                //Task 12 - bellow
                //if (i == endCol - 3) //the second block that the ball hits
                //{
                //    currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                //}
                engine.AddObject(currBlock);
            }
            // Add walls - Task 1         
            for (int row = 2; row < WorldRows; row++)
            {
                IndestructibleBlock leftWall = new IndestructibleBlock(new MatrixCoords(row, 0));
                IndestructibleBlock rightWall = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(leftWall);
                engine.AddObject(rightWall);
            }
            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock topWall = new IndestructibleBlock(new MatrixCoords(2, col));
                engine.AddObject(topWall);
            }
            // Task 9 - the UnpassableBlock, indestructible block
            //for (int i = 2; i < WorldCols / 2; i += 4)
            //{
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            //}
            //Task 7 --> Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            //Ball meteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(meteoriteBall);

            //Task 9 - > the ball destroys all, but bounces off UnpassableBlocks and the wall (so that we can keep playing :) )
            Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theUnstopableBall);

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);           
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
