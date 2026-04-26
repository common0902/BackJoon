#include <stdio.h>

int main(void) {
    int a;
    int b;
    scanf("%d %d", &a, &b);
    printf("%d %s %d %s", a,"+",b,"= ");
    printf("%d", a + b);
    return 0;
}