using System;
using System.Runtime.InteropServices;

namespace IPLookUp
{
    public static class IPWry
    {
        private const int RESULT_COUNT = 2;

        public struct IPWryResult
        {
            public string mainInformation;
            public string subInformation;
        }

        public static IPWryResult queryIP(string ip)
        {
            IntPtr result = GetAddressW(ip);
            string[] data = new string[RESULT_COUNT];
            for (int i = 0; i < RESULT_COUNT; ++i)
            {
                int offset = i * Marshal.SizeOf(typeof(IntPtr));
                data[i] = Marshal.PtrToStringUni(Marshal.ReadIntPtr(result, offset));
            }

            return new IPWryResult()
            {
                mainInformation = data[0],
                subInformation = data[1]
            };
        }

        [DllImport("IPSearcher.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        private static extern IntPtr GetAddressW(string ip);
    }
}