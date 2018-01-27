using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;



namespace Exercises
{

    class Course2_WorkSpace
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            Console.WriteLine("Current location on grid is ({0},{1})",point.X,point.Y);

            point.Move(new Point(40, 60));
            Console.WriteLine("New location on grid is ({0},{1})",point.X,point.Y);

            point.Move(200, 300);
            Console.WriteLine("Now we're located at ({0},{1})",point.X,point.Y);
        }


    }
    }

