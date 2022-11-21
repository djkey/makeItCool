#include <iostream>
#include <string>
#include <regex>

std::string makeitCool(std::string &line)
{
    line = regex_replace(line, std::regex("[Aa]"), "@");
    line = regex_replace(line, std::regex("[Ii]"), "1");
    line = regex_replace(line, std::regex("[Ss]"), "$");
    line = regex_replace(line, std::regex("[Oo]"), "0");
    line = regex_replace(line, std::regex("[Tt]"), "+");

    return line;
}

int main()
{
    setlocale(LC_ALL, "rus");

    std::string line;
    char coolline[255];

    std::cout << "Введите строку: ";
    std::getline(std::cin, line);

    makeitCool(line);

    std::cout << "Твоя крутая строка: " << line;

    return 0;
}