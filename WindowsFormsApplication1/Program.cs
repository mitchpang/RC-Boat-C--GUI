using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication1
{
    static class Constants {
        public const int speedIncrement = 30;
        public const int speedRange = 500;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Communication.commThread = new Thread(new ThreadStart(Communication.communicate));
            Communication.commThread.IsBackground = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    static class Communication
    {
        public static float forward = 0;
        public static float angular = 0;

        public static float linearPGain = 0;
        public static float linearIGain = 0;
        public static float linearDGain = 0;
        public static float angularPGain = 0;
        public static float angularIGain = 0;
        public static float angularDGain = 0;
        public static bool reprogramPID = false;

        public static int motors_enabled = 0;
        public static int PID_enabled = 0;
        public static String selectedComm;
        public static Thread commThread;
        public static String[] commNames = SerialPort.GetPortNames();
        static SerialPort serialOut;

        static byte[] message = new byte[64];

        public static void communicate()
        {
            serialOut = new SerialPort(selectedComm, 9600);
            serialOut.Open();
            while (true)
            {
                if (reprogramPID)
                {
                    message[0] = 0x55;
                    message[1] = 0x55;
                    message[2] = 25;
                    message[3] = 0x55;
                    floatToBytes(linearPGain, message, 4);
                    floatToBytes(linearIGain, message, 8);
                    floatToBytes(linearDGain, message, 12);
                    floatToBytes(angularPGain, message, 16);
                    floatToBytes(angularIGain, message, 20);
                    floatToBytes(angularDGain, message, 24);
                    message[28] = 0xAA;
                    serialOut.Write(message, 0, 29);
                    reprogramPID = false;
                }

                // Main speed control message
                message[0] = 0x55;
                message[1] = 0x55;
                message[2] = 10;
                message[3] = 0xCC;
                floatToBytes(forward, message, 4);
                floatToBytes(angular, message, 8);
                message[12] = (byte) ((motors_enabled << 4) | PID_enabled);
                message[13] = 0xAA;
                serialOut.Write(message, 0, 14);

                Thread.Sleep(50);
            }
        }

        private static void floatToBytes(float f, byte[] arr, int index)
        {
            byte[] temp = BitConverter.GetBytes(f);

            /*
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(temp);
            }*/

            temp.CopyTo(arr, index);
        }

    }


}
