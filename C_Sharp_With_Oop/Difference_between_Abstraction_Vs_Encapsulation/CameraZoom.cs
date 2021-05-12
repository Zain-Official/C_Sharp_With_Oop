using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Difference_between_Abstraction_Vs_Encapsulation
{
    class CameraZoom : Camera
    {
        public int gear = 0;
        public int lenseLocation = 0;

        public void ZoomIN()
        {
            gear = gear + 4;
            lenseLocation = lenseLocation + 2;
            _picturesize = _picturesize + gear * lenseLocation;
        }

        public void ZoomOut()
        {
            gear = gear - 4;
            lenseLocation = lenseLocation - 2;
            _picturesize = _picturesize - gear * lenseLocation;
        }

        public override int zoomresult   //override property
        {
            get
            {
                return _picturesize;
            }
        }
    }
}
