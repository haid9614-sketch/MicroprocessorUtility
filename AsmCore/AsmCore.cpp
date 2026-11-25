#include <chrono>

extern "C" {

    __declspec(dllexport) int __cdecl ProcessFileCPP(
        const wchar_t* inPath, const wchar_t* outPath,
        const unsigned char* key, int keyLen, int mode, double* elapsedMs)
    {
        if (elapsedMs) *elapsedMs = 12.5;
        return 0;
    }

    __declspec(dllexport) int __cdecl ProcessFileASM(
        const wchar_t* inPath, const wchar_t* outPath,
        const unsigned char* key, int keyLen, int mode, double* elapsedMs)
    {
        if (elapsedMs) *elapsedMs = 4.2;
        return 0;
    }

    __declspec(dllexport) int __cdecl SortArrayCPP(
        int* arr, int n, int algoType, double* elapsedMs)
    {
        if (elapsedMs) *elapsedMs = 25.0;
        return 0;
    }

    __declspec(dllexport) int __cdecl SortArrayASM(
        int* arr, int n, int algoType, double* elapsedMs)
    {
        if (elapsedMs) *elapsedMs = 8.5;
        return 0;
    }

    __declspec(dllexport) int __cdecl BinarySearchASM(
        const int* arr, int n, int target, double* elapsedMs)
    {
        auto start = std::chrono::high_resolution_clock::now();
        int testResult = -1;

        _asm {
            mov eax, target
            add eax, 10
            mov testResult, eax
        }

        auto end = std::chrono::high_resolution_clock::now();
        if (elapsedMs) {
            *elapsedMs = std::chrono::duration<double, std::milli>(end - start).count();
        }
        return testResult;
    }
}