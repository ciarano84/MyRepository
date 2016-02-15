using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resiliance_Tracker
{
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentClient = StringToInt(clientNumberInput.Text);
            int resiliance = StringToInt(resilianceInput.Text);
            int week = StringToInt(weekInput.Text);
            if (DataValid(currentClient, week, resiliance))
            {
                Client client = CheckForExistingClient(currentClient);
                //Checks to see if the week's data exists, if it doesn't, creates a new week with data.

                //Go through each week to find the one referenced and then add the data. Fill in missing weeks with the last result.
                if (week <= client.clientData.Count)
                    client.clientData[week - 1] = resiliance;
                else
                {
                    for (int i = 1; i <= week; i++)
                    {
                        if (i == week && i <= client.clientData.Count)
                            client.clientData[i - 1] = resiliance;
                        else if (i > client.clientData.Count)
                        {
                            if (i == week || i == 1)
                                client.clientData.Add(resiliance);
                            else
                            {
                                client.clientData.Add(client.clientData.Last());
                            }
                        }
                    }
                }

                client.GenerateClientProperties();

                PrintData(client);

                feedbackOutput.Text = ("client is number " + client.clientNumber + " and resiliance is currently at " + resiliance);
            }
        }

        int StringToInt(string text)
        {
            int number;
            if (Int32.TryParse(text, out number))
            {
                return number;
            }
            else
            {
                return -1;
            }
        }

        void PrintData(Client client)
        {
            resultsOutput.Text = "";
            for (int week = 1; week < client.clientData.Count + 1; week ++)
            {
                resultsOutput.Text += "Week " + week.ToString() + ", resiliance " + 
                    client.clientData[week -1] + Environment.NewLine;
            }
        }

        Client CheckForExistingClient(int clientNumber)
        {
            foreach (Client client in clients)
            {
                if (client.clientNumber == clientNumber)
                {
                    return client;
                }
            }
            Client newClient = new Client();
            newClient.clientNumber = clientNumber;
            clients.Add(newClient);
            return newClient;
        }

        //Checks to see if the data entered is valid.
        bool DataValid(int client, int week, int resliance)
        {
            if (client > 0 || week > 0 || (resliance > -1 && resliance < 31))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please only enter numbers into the text fields :) ");
                return false;
            }
        }

        //This is just a test method to output data to message box so I can see what's going on.
        public static void RunTests(string info)
        {
            MessageBox.Show(info);
        }

        private void Client1Test_Click(object sender, EventArgs e)
        {

            List<int> recentScores = new List<int>();
            recentScores.Add(3);
            recentScores.Add(4);
            recentScores.Add(5);
            recentScores.Add(6);
            recentScores.Add(7);

            List<double> weightedScores = new List<double>();

            for (int i = 0; i < recentScores.Count - 1; i++)
            {
                double x = (2 / (recentScores.Count - 1f));

                double weighting = (i + 1) * x;

                weightedScores.Add(recentScores[i] * weighting);
            }

            foreach (int i in weightedScores)
            {
                feedbackOutput.Text += (i.ToString() + Environment.NewLine);
            }
        }
    }
}
