﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        //Task 6 ---> Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. 
        //Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way as the normal ball. 
        //You must NOT edit any existing .cs file.

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            produceObjects.Add(new TrailObject(base.topLeft, new char[,] { { '@' } }, 3));
            return produceObjects;
        }
    }
}