
def makeitCool():
    line=input("Введите строку: ")

    line = line.replace('a','@').replace('A','@')
    line = line.replace('i','1').replace('I','1')
    line = line.replace('s','$').replace('S','$')
    line = line.replace('o','0').replace('O','0')    
    line = line.replace('t','+').replace('T','+')

    print(f'Крутая строка: {line}')

if __name__ == '__main__':
    makeitCool()