# Sudoku Solver

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
