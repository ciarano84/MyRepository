using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resiliance_Tracker
{

    class TrendSpotter
    {
        //This class aims to look for trends in the data.

        static int maxResult = 24;
        static double averageResult = maxResult / 2;

        // Looks at the best fit. A straight line is rated 100, a difference of 10 between start and
        // finish is 0.
        public static int SpotPlateau(Client client)
        {
            return 100 - (int)(Math.Min(client.stdDev, averageResult) * (100 / averageResult));
        }

        // Takes the recent scores and looks to see if there is a generally high average,
        // returning a value between 0 and 100 (with 100 meaning the highest average possible).

        public static int SpotHighAverage(Client client)
        {
            return Math.Min(100,100  - ( (100 / (maxResult/2)) * 
                (maxResult - (int)client.recentScores.Average())));
        }

        //To be tested.
        //Takes the recent scores and looks to see if there is a generally low average,
        //returning a value between 0 and 100 (with 100 meaning the lowest average possible).
        public static int SpotLowAverage(Client client)
        {
            return Math.Min(100, 100 - ((100 / (maxResult / 2)) * 
                (int)client.recentScores.Average()));
        }

        //Takes the recent scores and looks to see if there is a generally low average,
        //returning a value between 0 and 100 (with 100 meaning the most average possible, and
        //0 being a variance of at least half the total range).
        public static int SpotMidAverage(Client client)
        {
            int differenceFromAverage = Math.Abs((int)averageResult - 
                (int)client.recentScores.Average());

            return Math.Min(100, 100 - ((100 / (maxResult / 2)) *
                differenceFromAverage));
        }

        //Checks for few results and sets the bools appropriately on the client file.
        public static void CheckForFewResults(Client client)
        {
            client.fewResults = (client.clientData.Count < 4) ? true : false;
            client.firstResult = (client.clientData.Count == 1) ? true : false;
        }

        //Looks for an improvement over time, which today's result adds to.
        public static int SpotImprovement(Client client)
        {
            int toBeMultipliedBy = 100 / maxResult;

            if (client.recentScores.Last() < client.recentScores[client.recentScores.Count - 2])
                return 0;

            return (client.bestFit.Last() - client.bestFit.First()) * toBeMultipliedBy;
        }

        //Looks for an decline over time, which today's result adds to.
        public static int SpotDecline(Client client)
        {
            int toBeMultipliedBy = 100 / maxResult;

            if (client.recentScores.Last() > client.recentScores[client.recentScores.Count - 2])
                    return 0;

            return (client.bestFit.First() - client.bestFit.Last()) * toBeMultipliedBy;
        }

        //Looks for a result that is considerably higher than other recent results
        public static int SpotSharpImprovement(Client client)
        {
            int toBeMultipliedBy = (int)(100 / averageResult);

            return (int)((client.recentScores.Last() - client.weightedScores.Average()) * toBeMultipliedBy);
        }

        //Looks for a result that is considerably lower than other recent results
        public static int SpotSharpDecline(Client client)
        {
            int toBeMultipliedBy = (int)(100 / averageResult);

            return (int)((client.recentScores.Last() - client.weightedScores.Average()) * -toBeMultipliedBy);
        }

        //Look for erratic results.
        public static int SpotErraticResults(Client client)
        {
            //Two factors comprise this score. Each can contribute up to 50.
            int total = 0;
            //The first is the stdDev
            total += (int)(client.stdDev * (50 / averageResult));

            //the second is how close the best fit line is to being horizontal.
            total += (int)((maxResult - (client.bestFit.Last() - client.bestFit.First())) * (50 / maxResult));

            return total;
        }
    }
}
