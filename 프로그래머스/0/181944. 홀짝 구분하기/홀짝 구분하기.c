#include <stdio.h>

int main(void) {
    int a;
    scanf("%d", &a);
    char *b = (a % 2 == 0) ? "is even" : "is odd";
    printf("%d %s\n",a,b);
    return 0;
}