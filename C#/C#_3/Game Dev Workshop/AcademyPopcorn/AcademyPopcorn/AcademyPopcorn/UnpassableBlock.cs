using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Task 8
    //UnpassableBlock should be indestructible. Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.

    public class UnpassableBlock : Block
    {       
        public new const string CollisionGroupString = "unpassableBlock";
        public const char unPassBlock = '+';

        public UnpassableBlock(MatrixCoords upperLeft) : base(upperLeft)
        {
            this.body[0, 0] = UnpassableBlock.unPassBlock;
        }
        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData); //thus making it indestructible
        }
    }
}