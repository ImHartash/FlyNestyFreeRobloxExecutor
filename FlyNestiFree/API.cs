using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyNestiFree
{
    internal class API
    {
        [DllImport("FlyNestyInjector.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool inject();

        [DllImport("FlyNestyInjector.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool executeLuaCode(string luaScript);


        private static String ROBLOX_APP_NAME = "RobloxPlayerBeta.exe";

        private static bool isInjected = false;
        private static bool autoInject = false;

        private static Thread autoInjectThread = null;


        private static bool isProccessRunning()
        {
            Process[] processes = Process.GetProcessesByName(ROBLOX_APP_NAME);
            return processes.Length > 0;
        }


        public static bool execInject()
        {
            try
            {
                bool result = inject();
                isInjected = result;
                return isInjected;
            }
            catch
            {
                return false;
            }
        }

        public static bool execExecuteLuaScript(string luaScript)
        {
            try
            {
                return executeLuaCode(luaScript);
            }
            catch { return false; }
        }

        public static void setAutoInject(bool value)
        {
            if (value)
            {
                if (autoInjectThread == null || !autoInjectThread.IsAlive)
                {
                    autoInjectThread = new Thread(() =>
                    {
                        while (autoInject && !isInjected)
                        {
                            if (isProccessRunning())
                            {
                                if (execInject())
                                {
                                    autoInject = false;
                                }
                            }
                            Thread.Sleep(2000);
                        }
                    });
                }
            }
            else
            {
                autoInject = false;
                if (autoInjectThread != null && autoInjectThread.IsAlive)
                {
                    autoInjectThread.Join();
                }
            }
        }
    }
}
