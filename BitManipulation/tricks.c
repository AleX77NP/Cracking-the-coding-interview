#include <stdio.h>

int countSetBits(int x);
int logb2(int x);

int main() {
    printf("set bits: %d\n", countSetBits(3));
    printf("log 2: %d\n", logb2(32));

    printf("%d", 3 & 2);
}

// Count set bits in integer 
int countSetBits(int x) {
    int count = 0;
    while(x) {
        printf("x: %d\n", x);
        x &= (x-1);
        count ++;
    }
    return count;
}

int logb2(int x) {
    int res = 0;
    while(x >>=1) {
        printf("x: %d\n", x);
        res++;
    }
    return res;
}

// Find log base 2 of 32 bit integer
