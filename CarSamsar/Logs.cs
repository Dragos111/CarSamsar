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
            string timeStamp = DateTime.Now.ToString();
            string logString = username + type + attempt+ timeStamp;//No timeStamp for UnitTests
            logs.Add(logString);
        }

        public static void addUserLog(string username, string type, string attempt, string user)
        {
            string timeStamp = DateTime.Now.ToString();
            string logString = username + type + user + attempt + timeStamp;//No timeStamp for UnitTests
            logs.Add(logString);
        }

        public static void addCarLog(string username, string type, string attempt, string vin)
        {
            string timeStamp = DateTime.Now.ToString();
            string logString = username + type + vin + attempt + timeStamp;//No timeStamp for UnitTests
            logs.Add(logString);
        }

        public static ArrayList getLogs()
        {
            return logs;
        }
    }
}
