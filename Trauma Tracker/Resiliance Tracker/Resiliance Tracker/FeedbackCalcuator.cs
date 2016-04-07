using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resiliance_Tracker
{
    static class FeedbackCalcuator
    {
        static int threshold = 14; //The cut off point. Any lower and it is considered low resiliance.

        static string[] mildImprovementMessages = new string[3] 
            {"Mild Improvement Message 1", "Mild Improvement Message 2", "Mild Improvement Message 3"};
        static string[] mildDeclineMessages = new string[3]
            {"Mild Decline Message 1", "Mild Decline Message 2", "Mild Decline Message 3"};
        static string[] sharpImprovementMessages = new string[3]
            {"Sharp Improvement Message 1", "Sharp Improvement Message 2", "Sharp Improvement Message 3"};
        static string[] sharpDeclineMessages = new string[3]
            {"Sharp Decline Message 1", "Sharp Decline Message 2", "Sharp Decline Message 3"};
        static string[] erraticResultsMessages = new string[3]
            {"Erratic Results Message 1", "Erratic Results Message 2", "Erratic Results Message 3"};
        static string[] plateauHighMessages = new string[3]
            {"High Plateau Message 1", "High Plateau Message 2", "High Plateau Message 3"};
        static string[] plateauLowMessages = new string[3]
            {"Low Plateau Message 1", "Low Plateau Message 2", "Low Plateau Message 3"};
        static string[] plateauMidMessages = new string[3]
            {"Mid Plateau Message 1", "Mid Plateau Message 2", "Mid Plateau Message 3"};
        static string[] noObviousTrendMessage = new string[3]
            {"No Trend Message 1", "No Trend Message 2", "No Trend Message 3"};
        static string day1HighMessage = "day 1 High Message";
        static string day1LowMessage = "day 1 Low Message";
        static string day2HighMessage = "day 2 High Message";
        static string day2LowMessage = "day 2 Low Message";
        static string day3HighMessage = "day 3 High Message";
        static string day3LowMessage = "day 3 Low Message";

        //This is the function called from form 1. 
        public static string Feedback(Client client)
        {
            string message;

            if (client.firstResult)
                message = (client.resiliance >= threshold) ? day1HighMessage : day1LowMessage;
            else if (client.clientData.Count == 2)
                message = (client.resiliance >= threshold) ? day2HighMessage : day2LowMessage;
            else if (client.clientData.Count == 3)
                message = (client.resiliance >= threshold) ? day3HighMessage : day3LowMessage;
            else 
            message = RandomMessagePicker(PickMessageArray(client));

            return message;
        }

        //Takes in one of the above message arrays and randomly picks a message to feedback.
        public static string RandomMessagePicker(string[] messageArray)
        {
            Random r = new Random();
            string message = messageArray[r.Next(0,2)];
            return message;
        }

        static string[] PickMessageArray(Client client)
        {
            string[] messageArray;
            switch (client.highestTrend)
            {
                case 0: messageArray = plateauHighMessages;
                    break;
                case 1: messageArray = plateauMidMessages;
                    break;
                case 2: messageArray = plateauLowMessages;
                    break;
                case 3: messageArray = mildImprovementMessages;
                    break;
                case 4: messageArray = mildDeclineMessages;
                    break;
                case 5: messageArray = sharpImprovementMessages;
                    break;
                case 6: messageArray = sharpDeclineMessages;
                    break;
                case 7: messageArray = erraticResultsMessages;
                    break;
                default: messageArray = noObviousTrendMessage;
                    break;            
            }
            return messageArray;
        }
    }
}
