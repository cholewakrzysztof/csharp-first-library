# csharp-first-library
Moja pierwsza biblioteka C#

# Setup
1. Pobrać repozytorium poprzez Visual Studio->Git->Klonuj repozytorium->https://github.com/cholewakrzysztof/csharp-first-library
2. Włączyć projekt!

# Opis
Biblioteka zawiera dwie sttyczne klasy MyMath oraz MySpeaker, których metody są często wykorzystwanymi algorytmami w trakcie nauki programowania

# [MyMath]
Klasa zawiera 15 metod statycznych:
1. NWD - algorytm szukający największego wspólnego dzielnika
2. NWW - algorytm opart na NWD szukający najmniejszą wspólną wielokrotność
3. IsPrime - sprawdzenie, czy liczba jest pierwsza
4. PrimeNumbers - zwraca zadaną ilość po kolei występujących liczb pierwszych
5. IndexOfMax - zwraca index wartości maksymalnej w tablicy 
6. IndexOfMin - zwraca index wartości minimalnej w tablicy
7. Fibonacci - zwraca podaną ilość liczb z ciągu Fibonacciego
8. Fibonacci (przeładowanie) - zwraca liczby z ciągu Fibonaciego, od-do wybranych kolejnych liczb
9. Contain - sprawdza czy liczba znajduje się w tablicy
10. BubbleSort - sortowanie bąbelkowe
11. SelectSort - sortowanie przez wybór
12. ArraySum - zwraca sumę wszystkich liczb z tablicy
13. Dividers - zwraca tablicę dzielników danej liczby
14. BinarySearch - rekurencyjne wyszukiwanie wartości w posortowanej tablicy
15. Swap - zamiana miejsc dwóch wartości w tablicy

# [MySpeaker]
Klasa zawiera 6 metod statycznych do komunikacji z użytkownikiem
1. SayHello - wypisuje "Hello world!"
2. Say - wypisuje podany komunikat
3. Say (przeładowanie) - wypisuje podany komunikat wybraną ilość razy
4. Read - wczytuje dane od użytkownika
5. Read (przeładowanie) - wczytuje podaną ilość danych od użytkownika
6. ReadWhileNot - wczytuje dane od użytkownika, dopóki ten nie poda konkternej wartości
