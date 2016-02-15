using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resiliance_Tracker
{
    //I've made the methods herein static. When they weren't other classes complained that an
    //object reference was required. Should be fine, but not sure of the implications of them
    //being static methods.

    class Maths
    {
        class XYPoint
        {
            public int X;
            public double Y;
        }

        //To be tested! returns the last 3 months of entries from a given clients data.
        //Should also be moved out of here and into client class
        public static List<int> GetLast3Months(List<int> data)
        {
            List<int> last3Months;
            for (int i = 0; i < data.Count - 13; i++)
                data.Remove(i);
            last3Months = data;
            return last3Months;
        }

        //Gets the standard deviation from a list of numbers
        public static double GetStdDev(List<int> values)
        {
            double ret = 0;
            if (values.Count() > 0)
            {
                //Compute the Average      
                double avg = values.Average();
                //Perform the Sum of (value-avg)_2_2      
                double sum = values.Sum(d => Math.Pow(d - avg, 2));
                //Put it all together      
                ret = Math.Sqrt((sum) / (values.Count() - 1));
            }
            return ret;
        }

        //This method should take in a ClientData list and output a similar list which shows best fit.

        public static List<int> GenerateLinearBestFit(List<int> list)
        {
            List<XYPoint> points = new List<XYPoint>();
            List<XYPoint> bestFitPoints = new List<XYPoint>();
            List<int> bestFit = new List<int>();
            double a;
            double b;

            //Converts the list of resiliance into a set of x (weeks) and y (resiliance) data.
            for (int i = 0; i < list.Count; i++)
            {
                XYPoint point = new XYPoint();
                points.Add(point);
                //weeks
                points[i].X = i;
                //resliance
                points[i].Y = list[i];
            }

            int numPoints = points.Count;
            double meanX = points.Average(point => point.X);
            double meanY = points.Average(point => point.Y);

            double sumXSquared = points.Sum(point => point.X * point.X);
            double sumXY = points.Sum(point => point.X * point.Y);

            a = (sumXY / numPoints - meanX * meanY) / (sumXSquared / numPoints - meanX * meanX);
            b = (a * meanX - meanY);

            double a1 = a;
            double b1 = b;

            bestFitPoints = points.Select(point => new XYPoint() { X = point.X, Y = a1 * point.X - b1 }).ToList();

            //put the data back into a list similar to data client week (registers are weeks, ints are resiliance)
            for (int i = 0; i < bestFitPoints.Count; i++)
            {
                int Yrounded = (int)Math.Round(bestFitPoints[i].Y);
                bestFit.Add(Yrounded);
                Console.WriteLine("week " + i + " = " + bestFit[i]);
            }

            return bestFit;
        }

        //Creates a new list of weighted scores, with the earlier results being depreciated and the
        //more recent results being emphesised (by appearing more often). This becomes an average, which the most recent result
        //is then compared against.

        public static List<double> WeightScores(Client client)
        {
            List<double> weightedScores = new List<double>();

            for (int i = 0; i < client.recentScores.Count - 1; i++)
            {
                for (int c = 0; c <= i; c++)
                {
                    weightedScores.Add(client.recentScores[i]);
                }
            }

            return weightedScores;
        }
    }
}
