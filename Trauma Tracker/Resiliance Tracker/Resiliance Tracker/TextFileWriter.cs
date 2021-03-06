﻿using System;
using System.IO;

namespace Resiliance_Tracker
{
    class TextFileWriter
    {
        private string GetDataFilePath()
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"clientData.txt");
            if (!File.Exists(fileName))
            {
                var fileStream = File.Create(fileName);
                fileStream.Close();
            }
            return fileName;
        }

        public void ReadFile()
        {
            string line;
            StreamReader sr = new StreamReader(GetDataFilePath());

            try
            {
                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    Form1.clients.Add(LineToClientData(line));
                    
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        Client LineToClientData(string line)
        {
            int week = 0;
            string intAsSTring = "";
            Client client = new Client();

            //This works on the premise that the first number is the client number, and all subsequent are resilience scores.
            char[] chars = line.ToCharArray();
            foreach (char c in chars)
            {
                if (c == ',')
                {
                    if (week == 0)
                    {
                        client.clientId = int.Parse(intAsSTring.ToString());
                    }
                    else
                    {
                        client.clientData.Add(int.Parse(intAsSTring));
                    }
                    week++;
                    intAsSTring = "";
                    continue;
                }
                intAsSTring += c.ToString();
            }
            return client;
        }

        public void WriteFile()
        {
            StreamWriter sw = new StreamWriter(GetDataFilePath());

            //sw.WriteLine("");
            foreach (Client client in Form1.clients)
            {
                sw.WriteLine(DataToString(client));
            }
            sw.Close();
        }

        string DataToString(Client client)
        {
            string data = "";

            data += client.clientId.ToString() + ",";
            foreach (int score in client.clientData)
                data += score.ToString() + ",";
            return data;
        }
    }
}
