using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resiliance_Tracker
{
    class Client
    {
        public int clientNumber;
        //2 dimensional array which contains firstly the days since starting, secondly the resiliance scores
        public List<int> clientData = new List<int>();

        //This is their last 3 months, which is all we are ever working from.
        public List<int> recentScores = new List<int>();

        //This is their last 3 months, but weighted so that more recent results are more important.
        public List<double> weightedScores = new List<double>();

        //The following gives more information about their recent history.
        public double mean;
        public double stdDev;
        public int highest;
        public int lowest;
        public List<int> bestFit;

        //The following are all trends, each experessed as an interger to show how strong the trend is
        // 0 being nothing at all, 100 being that the trend is very strong for that data set.

        public int plateau;
        public int highAverage;
        public int lowAverage;
        public int midAverage;
        public bool fewResults;
        public bool firstResult;
        public int improvement;
        public int decline;
        public int sharpImprovement;
        public int sharpDecline;
        public int erraticResults;

        public void GenerateClientProperties()
        {
            recentScores = Maths.GetLast3Months(clientData);
            weightedScores = Maths.WeightScores(this);

            // all the below use the recent scores.
            mean = recentScores.Average();
            stdDev = Maths.GetStdDev(recentScores);
            highest = recentScores.Max();
            lowest = recentScores.Min();
            bestFit = Maths.GenerateLinearBestFit(clientData);

            //Generate Trends
            TrendSpotter.CheckForFewResults(this);
            if (!firstResult)
            {
                plateau = TrendSpotter.SpotPlateau(this);
                highAverage = TrendSpotter.SpotHighAverage(this);
                lowAverage = TrendSpotter.SpotLowAverage(this);
                midAverage = TrendSpotter.SpotMidAverage(this);
                improvement = TrendSpotter.SpotImprovement(this);
                decline = TrendSpotter.SpotDecline(this);
                
            }
            if (!fewResults)
            {
                sharpImprovement = TrendSpotter.SpotSharpImprovement(this);
                sharpDecline = TrendSpotter.SpotSharpDecline(this);
                erraticResults = TrendSpotter.SpotErraticResults(this);
            }
        }
    }
}
