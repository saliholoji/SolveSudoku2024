# [TR] Sudoku Solver

🎯 Bu proje, Leet Code üzerinde karşılaştığım en zor seviyedeki "Sudoku Solver" problemini çözmek için geliştirilmiştir. Sudoku bulmacalarını çözmeyi ve ileri seviye algoritmaları yeniden öğrenmek için YouTube'da bolca pratik yaptım.

🔗 Leetcode.com üzerinden problemi incelemek isterseniz: [https://leetcode.com/problems/sudoku-solver/](https://leetcode.com/problems/sudoku-solver/).

📈 Sunmuş olduğum çözüme ait, detaylı istatistikler: [https://leetcode.com/submissions/detail/1335745164/](https://leetcode.com/submissions/detail/1335745164/) 

## Özellikler

🔢 Peter Norvig'in hesaplarına göre, toplam geçerli Sudoku çözüm sayısı yaklaşık 6.67 x 10^21'dir. Bu sayı, 19 sıfırlı 667 sayısı yani 6,670,000,000,000,000,000,000 olarak ifade edilebilir. Bu kadar büyük bir çözüm alanı, çeşitli tekniklerin ve algoritmaların kullanımını gerektirir.

Sudoku çözümleme tekniklerinden bazıları şunlardır:
- Hidden Single
- Naked Single
- Locked Candidate
- Hidden Pair
- Naked Pair
- Hidden Triple
- Naked Triple
- Hidden Quad
- Naked Quad
- X-wing
- XY-wing
- XYZ-wing
- Swordfish
- Jellyfish
- Color Wrap
- Color Trap
- Color Wing
- XY-chain
- Empty Rectangle
- Finned X-wing
- Finned Swordfish
- Finned Jellyfish
- Aligned Pair Exclusion
- Almost Locked Set
- Unique Rectangle Type

Ancak, bu projede onlarca fonksiyon yerine sadece iki temel fonksiyon kullanarak Sudoku bulmacalarını etkili bir şekilde çözmeyi başardım.

## Kullanılan Algoritmalar

### 1. SolveSudoku
- Sudoku bulmacasını çözmek için tasarlandı.
- 9x9'luk ızgaradaki her hücreyi kontrol eder, boşsa ('.') 1-9 arası sayıları dener.
- Geçerli sayıyı bulursa, Sudoku'nun geri kalanını çözmek için fonksiyonu tekrar çağırır.
- Tüm hücreler dolunca `true` döner; aksi takdirde `false` döner ve önceki adımlara geri dönülür.

### 2. IsValid
- Bir sayının belirli bir hücreye koyulmasının geçerli olup olmadığını kontrol eder.
- Aynı satırda, sütunda veya 3x3'lük kutucukta sayı varsa geçerli değildir.
- Tüm kontroller geçerliyse, sayı o hücreye koyulabilir.

## Görseller

![Sudoku-by-L2G-20050714 svg](https://github.com/user-attachments/assets/2e382a29-c960-4c64-9d75-8c7df7a1de8a)
![Sudoku-by-L2G-20050714_solution svg](https://github.com/user-attachments/assets/f0c42b5e-c934-4a40-bd81-625212df5b48)

![Çözüm](https://github.com/user-attachments/assets/e93958de-dc3d-4cbc-9f03-36b9e5c0cecd)
![Çözüm 2](https://github.com/user-attachments/assets/2beb4195-c947-475f-8aea-3628471ab2ee)


## Kurulum

1. Bu projeyi klonlayın:
    ```sh
    git clone https://github.com/saliholoji/SolveSudoku2024.git
    ```
2. Proje dizinine gidin:
    ```sh
    cd sudoku-solver
    ```
3. Gerekli bağımlılıkları yükleyin ve projeyi çalıştırın (Visual Studio veya .NET Core SDK gerektirir):

### Visual Studio ile:
- Proje dosyasını (`.csproj`) Visual Studio ile açın.
- Çözümü derleyin (Build Solution).
- Programı çalıştırın (Run).

### .NET Core CLI ile:
    ```sh
    dotnet build
    dotnet run
    ```

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın. Her türlü katkıdan memnuniyet duyarız!

# [EN] Sudoku Solver

🎯 This project was developed to solve the most difficult level “Sudoku Solver” problem I encountered on Leet Code. I practiced a lot on YouTube to relearn how to solve Sudoku puzzles and advanced algorithms.

🔗 If you want to review the problem on Leetcode.com: [https://leetcode.com/problems/sudoku-solver/](https://leetcode.com/problems/sudoku-solver/).

📈 Detailed statistics of the solution I presented: [https://leetcode.com/submissions/detail/1335745164/](https://leetcode.com/submissions/detail/1335745164/) 

## Features

🔢 According to Peter Norvig's calculations, the total number of valid Sudoku solutions is approximately 6.67 x 10^21. This number can be expressed as the number 667 with 19 zeros, i.e. 6,670,670,000,000,000,000,000,000,000. Such a large solution space requires the use of various techniques and algorithms.

Here are some of the Sudoku solving techniques:
- Hidden Single
- Naked Single
- Locked Candidate
- Hidden Pair
- Naked Pair
- Hidden Triple
- Naked Triple
- Hidden Quad
- Naked Quad
- X-wing
- XY-wing
- XYZ-wing
- Swordfish
- Jellyfish
- Color Wrap
- Color Trap
- Color Wing
- XY-chain
- Empty Rectangle
- Finned X-wing
- Finned Swordfish
- Finned Jellyfish
- Aligned Pair Exclusion
- Almost Locked Set
- Unique Rectangle Type

However, in this project I was able to effectively solve Sudoku puzzles using only two basic functions instead of dozens of functions.

## Algorithms Used

### 1. SolveSudoku
- Designed to solve the Sudoku puzzle.
- It checks each cell in a 9x9 grid, if empty ('.') it tries numbers 1-9.
- If it finds a valid number, it calls the function again to solve the rest of the Sudoku.
- It returns `true` when all cells are filled; otherwise it returns `false` and returns to the previous steps.

### 2. IsValid
- Checks if it is valid to put a number in a specific cell.
- It is not valid if the number is in the same row, column or 3x3 tile.
- If all checks pass, the number can be placed in that cell.

## Images

![Sudoku-by-L2G-20050714 svg](https://github.com/user-attachments/assets/2e382a29-c960-4c64-9d75-8c7df7a1de8a)
![Sudoku-by-L2G-20050714_solution svg](https://github.com/user-attachments/assets/f0c42b5e-c934-4a40-bd81-625212df5b48)

![Solution](https://github.com/user-attachments/assets/e93958de-dc3d-4cbc-9f03-36b9e5c0cecd)
![Çözüm 2](https://github.com/user-attachments/assets/2beb4195-c947-475f-8aea-3628471ab2ee)


## Installation

1. Clone this project:
    ```sh
    git clone https://github.com/saliholoji/SolveSudoku2024.git
    ```
2. Go to the project directory:
    ```sh
    cd sudoku-solver
    ```
3. Install the required dependencies and run the project (requires Visual Studio or .NET Core SDK):

### With Visual Studio:
- Open the project file (`.csproj`) with Visual Studio.
- Compile the solution (Build Solution).
- Run the program (Run).

#### With .NET Core CLI:
    ```sh
    dotnet build
    dotnet run
    ```

## License

This project is licensed under the MIT License. See the `LICENSE` file for more information.

## Contributing

If you would like to contribute, please send a pull request or open an issue. Any contribution is welcome!
