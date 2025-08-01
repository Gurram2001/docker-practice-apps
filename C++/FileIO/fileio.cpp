#include <iostream>
#include <fstream>
int main() {
    std::ofstream file("sample.txt");
    file << "File IO Example";
    file.close();
    std::cout << "Wrote to sample.txt" << std::endl;
    return 0;
}
