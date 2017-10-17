#include <stdio.h>
#include <cpuid.h>   // for __get_cpuid intrinsic
#include <assert.h>
void InvokeCPUID(unsigned int  function,
                 unsigned int  subfunction,
                 unsigned int* pEAX,
                 unsigned int* pEBX,
                 unsigned int* pECX,
                 unsigned int* pEDX)
{
    assert(pEAX != NULL);
    assert(pEBX != NULL);
    assert(pECX != NULL);
    assert(pEDX != NULL);

    __asm__ __volatile__("cpuid"
                        : "=a" (*pEAX),
                          "=b" (*pEBX),
                          "=c" (*pECX),
                          "=d" (*pEDX)
                        :  "a" (function),
                           "c" (subfunction)
                        );
}

_Bool SupportsRDRAND()
{
    const unsigned int flag_RDRAND = (1 << 30);

    unsigned int eax, ebx, ecx, edx;
    InvokeCPUID(1, 0, &eax, &ebx, &ecx, &edx);

    return ((ecx & flag_RDRAND) == flag_RDRAND);
}
int main(void)
{

        printf("huuu: %d\n",SupportsRDRAND() );
        return 0;
}
