using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Difference_between_Abstraction_Vs_Encapsulation
{
    class DifferenceBetAbstractionVsEncapsulation
    {
        static void Main(string[] args)
        {
            CameraZoom cz = new CameraZoom();
            cz.ZoomIN();

            Console.WriteLine("\nPicture Zoom In Result Is = {0}",cz.zoomresult);
            Console.WriteLine("More Picture Zoom");

            cz.ZoomIN();
            Console.WriteLine("Picture Zoom In Result Is = {0}", cz.zoomresult);
           

            Console.WriteLine("\n*************************************\n");

            cz.ZoomOut();
            Console.WriteLine("Reduce Picture Zoom");
            Console.WriteLine("\nPicture Zoom Out Result Is {0}", cz.zoomresult);

            Console.ReadKey();

        }
    }
}
