using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resiliance_Tracker
{
    class FeedbackCalcuator
    {
        string mildImprovement = "You seem to be improving at the moment, keep it up!";
        string mildDecline = "You seem to be struggling a little lately, Let's try something different";
        string bigImprovement = "Wow, you've had a great week! What did you do differently?";
        string bigDecline = "Looks like things have suddently got really difficult. Let's see what we can do.";
        string erraticResults = "Things seem to be a bit up and down at the moment for you. What can we do to steady things?";
        string plateauHigh = "You look like you've been in a great place for a long time now. Do you feel lik you still need the app?";
        string plateauLow = "You've struggled for some time now. Perhaps it's time to seek professional help.";
        string plateauMid = "you're mid level";
    }
}
