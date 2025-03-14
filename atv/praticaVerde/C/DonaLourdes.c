#include <stdio.h>

int main() {
    double r = 0, n = 0, s = 998;
    while (r != 999) {
        scanf("%lf", &r);
        if (r > n && r != 999) n = r;
        if (r < s) s = r;
    }
    printf("%.2lf %.2lf\n", n, s);
    return 0;
}
