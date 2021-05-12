using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Difference_between_Abstraction_Vs_Encapsulation
{
    //Abstraction
    abstract class Camera
    {
        protected int _picturesize = 100;
        public abstract int zoomresult { get; }
    }
}
