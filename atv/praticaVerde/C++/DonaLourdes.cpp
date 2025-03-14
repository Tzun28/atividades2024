#include <iostream>

int main() {
    double r = 0, n = 0, s = 998;
    while (r != 999) {
        std::cin >> r;
        if (r > n && r != 999) n = r;
        if (r < s) s = r;
    }
    std::cout << n << " " << s << std::endl;
    return 0;
}
