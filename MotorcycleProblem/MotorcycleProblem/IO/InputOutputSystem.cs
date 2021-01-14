using System;
using MotorcycleProblem.DataStructure;

namespace MotorcycleProblem.IO
{
    public class InputOutputSystem : IInputOutputSystem
    {
        private TYpe[] InitializeArray<TYpe>(int length) where TYpe : new()
        {
            TYpe[] array = new TYpe[length];
            
            for (int i = 0; i < length; ++i)
                array[i] = new TYpe();

            return array;
        }
        public int GetNumberOfMotorcycles(string nameOfFile)
        {
            string[] lines = System.IO.File.ReadAllLines(nameOfFile);

            int index = 0;
            
            foreach (var line in lines)
                index += 1;

            return index;
        }

        public IMotorcycleDataStructure[] GetMotorcyclesFromFile(string nameOfFile, int numberOfMotorcycles)
        {
            IMotorcycleDataStructure[] motorcycles = InitializeArray<MotorcycleDataStructure>(numberOfMotorcycles);
            
            string[] lines = System.IO.File.ReadAllLines(nameOfFile);
            
            int it = 0;

            foreach (var line in lines)
            {
                string[] wordsFromLine = line.Split(", ");

                SaveDataInMotorcycleDataStructure(motorcycles, it, wordsFromLine);
                
                it += 1;
            }

            return motorcycles;
        }

        private static void SaveDataInMotorcycleDataStructure(IMotorcycleDataStructure[] motorcycles, int it,
            string[] wordsFromLine)
        {
            motorcycles[it].SetBrandOfMotorcycle(wordsFromLine[0]);

            motorcycles[it].SetModelOfMotorcycle(wordsFromLine[1]);

            motorcycles[it].SetCapacityOfMotorcycle(Int32.Parse(wordsFromLine[2]));

            motorcycles[it].SetTypeOfMotorcycle(wordsFromLine[3]);

            motorcycles[it].SetMaxSpeedInStraightLineOfMotorcycle(float.Parse(wordsFromLine[4]));

            motorcycles[it].SetMaxSpeedInCurveOfMotorcycle(float.Parse(wordsFromLine[5]));
        }

        public void PutsMotorcyclesInConsole(IMotorcycleDataStructure[] motorcycles)
        {

            foreach (var motorcycle in motorcycles)
            {
                Console.Write(motorcycle.GetBrandOfMotorcycle() + " ");
                Console.Write(motorcycle.GetModelOfMotorcycle() + " ");
                Console.Write(motorcycle.GetCapacityOfMotorcycle() + " ");
                Console.Write(motorcycle.GetTypeOfMotorcycle() + " ");
                Console.Write(motorcycle.GetMaxSpeedInStraightLineOfMotorcycle() + " ");
                Console.WriteLine(motorcycle.GetMaxSpeedInCurveOfMotorcycle());
            }
        }
    }
}