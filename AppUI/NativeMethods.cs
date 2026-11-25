using System.Runtime.InteropServices;

namespace AppUI
{
    public static class NativeMethods
    {
        private const string DllName = "AsmCore.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int ProcessFileCPP(
            string inPath, string outPath, byte[] key, int keyLen, int mode, out double elapsedMs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int ProcessFileASM(
            string inPath, string outPath, byte[] key, int keyLen, int mode, out double elapsedMs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SortArrayCPP(int[] arr, int n, int algoType, out double elapsedMs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SortArrayASM(int[] arr, int n, int algoType, out double elapsedMs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int BinarySearchASM(int[] arr, int n, int target, out double elapsedMs);
    }
}
