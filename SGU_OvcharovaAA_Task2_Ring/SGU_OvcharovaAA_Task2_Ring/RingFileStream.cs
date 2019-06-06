using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SGU_OvcharovaAA_Task2_Ring
{
    class RingFileStream
    {
        public Ring Read()
        {
            Ring ring = new Ring();
            Point point = new Point();
            using (StreamReader file = new StreamReader("input.txt"))
            {

                string[] line = file.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                if (!(double.TryParse(line[0], out var tempX)
                    && double.TryParse(line[1], out var tempY)))
                {
                    throw new FormatException("Enter correct value");
                }
                point.X = tempX;
                point.Y = tempY;

                ring.Center = point;
                ring.OutRad = int.Parse(file.ReadLine());
                ring.InRad = int.Parse(file.ReadLine());

                return ring;
            }

        }
        public void Save(Ring ring)
        {
            using (StreamWriter file = new StreamWriter("output.txt"))
            {
                var sum = ring.Summ;
                var sq = ring.Square;
                file.WriteLine("Summ: {0}", sum);
                file.WriteLine("Square: {0}", sq);
            }
        }
    } }
