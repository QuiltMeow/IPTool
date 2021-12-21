using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IPLookUp
{
    public class ChineseTranslate
    {
        private const string OPEN_CC_LIBRARY = "opencc.dll";

        [DllImport(OPEN_CC_LIBRARY, BestFitMapping = false)]
        private static extern IntPtr opencc_open(string configFile);

        [DllImport(OPEN_CC_LIBRARY)]
        private static extern IntPtr opencc_convert_utf8(IntPtr instance, IntPtr input, int length);

        [DllImport(OPEN_CC_LIBRARY)]
        private static extern void opencc_convert_utf8_free(IntPtr buffer);

        private readonly IntPtr instance;

        public ChineseTranslate(string configFile)
        {
            instance = opencc_open(configFile);
        }

        private static IntPtr toNativeUTF8String(string manageString)
        {
            int byteLength = Encoding.UTF8.GetByteCount(manageString) + 1;
            byte[] buffer = new byte[byteLength];
            Encoding.UTF8.GetBytes(manageString, 0, manageString.Length, buffer, 0);

            IntPtr ret = Marshal.AllocHGlobal(byteLength);
            Marshal.Copy(buffer, 0, ret, byteLength);
            return ret;
        }

        protected static string toManageString(IntPtr nativeUTF8String)
        {
            int length = 0;
            while (Marshal.ReadByte(nativeUTF8String, length) != 0)
            {
                ++length;
            }
            byte[] buffer = new byte[length];
            Marshal.Copy(nativeUTF8String, buffer, 0, length);
            return Encoding.UTF8.GetString(buffer);
        }

        public string convertTraditionalChinese(string text)
        {
            IntPtr input = toNativeUTF8String(text);
            IntPtr output = opencc_convert_utf8(instance, input, -1);
            Marshal.FreeHGlobal(input);

            string ret = toManageString(output);
            opencc_convert_utf8_free(output);
            return ret;
        }
    }
}