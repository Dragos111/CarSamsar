using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSamsar
{
    public class Logs
    {
        private static ArrayList logs = new ArrayList();

        public static void addLog(string username, string type, string attempt)
        {
            String timeStamp = DateTime.Now.ToString();
            string logString = username + type + attempt; //+ timeStamp;
            logs.Add(logString);
        }

        public static void addUserLog(String username, String type, String attempt, String user)
        {
            String timeStamp = DateTime.Now.ToString();
            string logString = username + type + user + attempt;// + timeStamp;
            logs.Add(logString);
        }

        public static void addCarLog(String username, String type, String attempt, String vin)
        {
            String timeStamp = DateTime.Now.ToString();
            string logString = username + type + vin + attempt;// + timeStamp;
            logs.Add(logString);
        }


        public static ArrayList getLogs()
        {
            return logs;
        }
    }
}
