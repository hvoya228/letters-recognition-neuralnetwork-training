using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersRecognitionInPercents
{
    public class Perceptron
    {
        private double[] weights;
        private double teta;
        private double learningRate = 2; // speed of learning
        private int currentTrainingLetterNumber;

        public Perceptron(int inputCount)
        {
            Random random = new Random();

            // Set random weights [-1;1]
            weights = new double[inputCount];
            for (int i = 0; i < inputCount; i++)
            {
                weights[i] = random.NextDouble() * 2 - 1;
            }

            // Set random teta [-1;1]
            teta = random.NextDouble() * 2 - 1;
        }

        public double ProcessInputs(int[] inputs)
        {
            double sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            sum += teta;

            return 1.0 / (1.0 + Math.Exp(-sum));
        }

        private void Train(int[] inputs, int targetOutput)
        {
            double prediction = ProcessInputs(inputs);

            // Updating weights
            for (int i = 0; i < inputs.Length; i++)
            {
                weights[i] += learningRate * (Convert.ToDouble(targetOutput) - prediction) * Convert.ToDouble(inputs[i]);
            }

            // Updating teta
            teta += learningRate * (Convert.ToDouble(targetOutput) - prediction);
        }

        private int CheckResult(int[][] trainingData)
        {
            double y = 0;

            for (int i = 0; i < trainingData.Length; i++)
            {
                y = ProcessInputs(trainingData[i]);

                if ((currentTrainingLetterNumber == i) && (y > 0.99d))
                {
                    return 1;
                }
            }

            return 0;
        }

        public void StartTraining(int[] labels, int[][] trainingData)
        {
            int rightResultsCount = 0;

            while (rightResultsCount != trainingData.Length)
            {
                for (int i = 0; i < trainingData.Length; i++)
                {
                    currentTrainingLetterNumber = i;

                    Train(trainingData[i], labels[i]);
                    rightResultsCount += CheckResult(trainingData);

                    GetInfo();
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Weights: ");
            for (int i = 0; i < weights.Length; i++)
            {

                Console.WriteLine(i + 1 + " weight: " + weights[i].ToString("0.0000"));
            }
            Console.WriteLine();
            Console.WriteLine("Teta: " + teta);
            Console.WriteLine();
            Console.WriteLine("---------");
        }
    }
}
