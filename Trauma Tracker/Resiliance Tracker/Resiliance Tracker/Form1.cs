using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Resiliance_Tracker
{
    public partial class Form1 : Form
    {
        public static List<Client> clients = new List<Client>();
        public static Client currentClient;
        TextFileWriter writer = new TextFileWriter();

        public Form1()
        {
            InitializeComponent();
            writer.ReadFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int clientNumber = StringToInt(clientNumberInput.Text);
            int traumaScore = StringToInt(InventoryInput.Text);
            int week = StringToInt(weekInput.Text);
            if (DataValid(clientNumber, week, traumaScore))
            {
                currentClient = CheckForExistingClient(clientNumber);
                //Checks to see if the week's data exists, if it doesn't, creates a new week with data.

                //set the client's resiliance for the week
                currentClient.resiliance = 30 - traumaScore;

                //Go through each week to find the one referenced and then add the data. Fill in missing weeks with the last result.
                if (week <= currentClient.clientData.Count)
                    currentClient.clientData[week - 1] = currentClient.resiliance;
                else
                {
                    for (int i = 1; i <= week; i++)
                    {
                        if (i == week && i <= currentClient.clientData.Count)
                            currentClient.clientData[i - 1] = currentClient.resiliance;
                        else if (i > currentClient.clientData.Count)
                        {
                            if (i == week || i == 1)
                                currentClient.clientData.Add(currentClient.resiliance);
                            else
                            {
                                currentClient.clientData.Add(currentClient.clientData.Last());
                            }
                        }
                    }
                }

                currentClient.GenerateClientProperties();
                //SendToDatabase();
                PrintData(currentClient);
                writer.WriteFile();

                feedbackOutput.Text = (FeedbackCalcuator.Feedback(currentClient));
            }
        }

        //This uploads all the data from the program and puts in back in the database. (in progress)
        //private void SendToDatabase()
        //{
        //    using (ResilienceDataContext context = new ResilienceDataContext())
        //    {
        //        foreach (Client client in clients)
        //        {
        //            //code here
        //        }
        //    }
        //}

        /// <summary>
        /// This method pulls the list of clients from the datacontext
        /// </summary>
        /// <returns></returns>
        //private List<Client> PopulateClientListFromDB()
        //{
        //    List<Client> clients = new List<Client>();
        //    using (ResilienceDataContext context = new ResilienceDataContext())
        //    {
        //        //Concenr as to how it will handle nulls (say, week_3 was null in the database what would it put in the table
        //        //or would it through an exception?
        //        foreach (var c in context.MasterClientTables)
        //        {
        //            Client client = new Client();
        //            client.clientData[0] = (int)c.Week_1;
        //            client.clientData[1] = (int)c.Week_2;
        //            client.clientData[2] = (int)c.Week_3;
        //            client.clientData[3] = (int)c.Week_4;
        //            client.clientData[4] = (int)c.Week_5;
        //            client.clientData[5] = (int)c.Week_6;
        //            client.clientData[6] = (int)c.Week_7;
        //            client.clientData[7] = (int)c.Week_8;
        //            client.clientData[8] = (int)c.Week_9;
        //            client.clientData[9] = (int)c.Week_10;
        //            client.clientData[10] = (int)c.Week_11;
        //            client.clientData[11] = (int)c.Week_12;
        //            client.clientData[12] = (int)c.Week_13;
        //            client.clientData[13] = (int)c.Week_14;
        //            client.clientData[14] = (int)c.Week_15;
        //            client.clientData[15] = (int)c.Week_16;
        //            client.clientData[16] = (int)c.Week_17;
        //            client.clientData[17] = (int)c.Week_18;
        //            client.clientData[18] = (int)c.Week_19;
        //            client.clientData[19] = (int)c.Week_20;
        //            client.clientData[20] = (int)c.Week_21;
        //            client.clientData[21] = (int)c.Week_22;
        //            client.clientData[22] = (int)c.Week_23;
        //            client.clientData[23] = (int)c.Week_24;
        //        }
        //        return clients;
        //var r = context.MasterClientTables.Select(s => new { s.ClientId, s.Resliance }).ToList();
        //foreach (Client c in context.Clients)
        //{
        //    Client a = new Client();
        //    a.clientId = c.ClientId;
        //    a.clientData = (
        //        from res in r
        //        where c.ClientId == res.ClientId
        //        select res.Resliance).ToList();
        //    clients.Add(a);
        //}
        //return clients;
        //    }
        //}

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
            for (int week = 1; week < client.clientData.Count + 1; week++)
            {
                resultsOutput.Text += "Week " + week.ToString() + ", resiliance " +
                    client.clientData[week - 1] + Environment.NewLine;
            }
        }

        Client CheckForExistingClient(int clientNumber)
        {
            foreach (Client client in clients)
            {
                if (client.clientId == clientNumber)
                {
                    return client;
                }
            }
            Client newClient = new Client();
            newClient.clientId = clientNumber;
            clients.Add(newClient);
            return newClient;

            //using (ResilienceDataContext context = new ResilienceDataContext())
            //{
            //     dbclient = new Client
            //    {
            //        Client_Number = 3
            //    };

            //context.MasterClientTables.InsertOnSubmit(newClient);
            //    context.MasterClientTables.Add();
            //    try
            //    {
            //        context.SubmitChanges();
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(string.Concat("Error: ", e));
            //    }

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
            writer.ReadFile();
        }

        //potential code for translating column data from database.
        //int GetColumnInfo(int number)
        //{
        //    if (number == null)
        //        return null;
        //}
    }
}
