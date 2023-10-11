using LettersRecognitionInPercents;

int[][] trainingData = new int[][]
        {
            new int[] { 0, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for A

            new int[] { 1, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for B

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 1, 1, 1 }, // matrix for C

            new int[] { 1, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 0 }, // matrix for D

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1 }, // matrix for E

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for F

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for G

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for H

            new int[] { 1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for I

            new int[] { 0, 0, 0, 1,
                        0, 0, 0, 1,
                        0, 0, 0, 1,
                        0, 1, 0, 1,
                        0, 1, 1, 1 }, // matrix for J

            new int[] { 1, 0, 0, 1,
                        1, 0, 1, 0,
                        1, 1, 0, 0,
                        1, 0, 1, 0,
                        1, 0, 0, 1 }, // matrix for K

            new int[] { 1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 1, 1, 0 }, // matrix for L

            new int[] { 1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for M

            new int[] { 1, 0, 0, 1,
                        1, 1, 0, 1,
                        1, 0, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for N

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for O

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for P

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 1, 0,
                        1, 1, 0, 1 }, // matrix for Q

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 1, 0,
                        1, 0, 0, 1 }, // matrix for R

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        0, 1, 1, 0,
                        0, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for S

            new int[] { 1, 1, 1, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0 }, // matrix for T

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 0 }, // matrix for U

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0 }, // matrix for V

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        0, 1, 1, 0 }, // matrix for U

            new int[] { 1, 0, 0, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        1, 0, 0, 1 }, // matrix for X

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 1,
                        0, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for Y

            new int[] { 1, 1, 1, 1,
                        0, 0, 0, 1,
                        0, 0, 1, 0,
                        0, 1, 0, 0,
                        1, 1, 1, 1 }, // matrix for Z
        };

int[][] labels = new int[][]
        {
            new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for A perceptron
            new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for B perceptron
            new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for C perceptron
            new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for D perceptron
            new int[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for E perceptron
            new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for F perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for G perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for H perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for I perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for J perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for K perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for L perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for M perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for N perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for O perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for P perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for Q perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, // Result for R perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, // Result for S perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, // Result for T perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, // Result for U perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, // Result for V perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // Result for W perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, // Result for X perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }, // Result for Y perceptron
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, // Result for Z perceptron
        };

char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                              'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                              'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                              'Y', 'Z' };

var perceptrons = new List<Perceptron>();
for (int i = 0; i < 26; i++)
{
    perceptrons.Add(new Perceptron(20));
}

for (int i = 0; i < 26; i++)
{
    perceptrons[i].StartTraining(labels[i], trainingData);
    Console.WriteLine(letters[i] + " training result: ");
    perceptrons[i].GetInfo();
}

for (int i = 0; i < 26; i++)
{
    Console.WriteLine();
    Console.WriteLine(letters[i] + " result: ");
    Console.WriteLine("---------");

    for (int j = 0; j < 26; j++)
    {
        Console.Write(letters[j] + ":");
        Console.Write(perceptrons[i].ProcessInputs(trainingData[j]).ToString("0.0000") + " ");
    }

    Console.WriteLine();
    Console.WriteLine("---------");
}

Console.ReadLine();
