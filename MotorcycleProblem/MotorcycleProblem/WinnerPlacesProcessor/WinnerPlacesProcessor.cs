using System;
using MotorcycleProblem.DataStructure;
using MotorcycleProblem.IO;

namespace MotorcycleProblem.WinnerPlacesProcessor
{
    public class WinnerPlacesProcessor : IWinnerPlacesProcessor
    {
        private readonly IInputOutputSystem _inputOutputSystem = InputOutputSystemFactoryObject.GetInputOutputSystem();
        
        private readonly string _pathToCircuitFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                                                "MotorcycleProblem/MotorcycleProblem/Data/circuit.txt");

        public void GetMotorcyclesPositionInTable(int numberOfMotorcycles, IMotorcycleDataStructure[] motorcycle)
        {
            for (int it = 0; it < numberOfMotorcycles; it++)
                for (int jit = it; jit < numberOfMotorcycles; jit++)
                    if (GetAverageSpeedOfMotorcycle(motorcycle[it]) < GetAverageSpeedOfMotorcycle(motorcycle[jit]))
                        SwapPlacesOfMotorcycles(motorcycle, it, jit);
                    
        }
        
        private static void SwapPlacesOfMotorcycles(IMotorcycleDataStructure[] motorcycle, int it, int jit)
        {
            IMotorcycleDataStructure motorcycleAuxPlace = motorcycle[it];
            motorcycle[it] = motorcycle[jit];
            motorcycle[jit] = motorcycleAuxPlace;
        }
        
        private double GetAverageSpeedOfMotorcycle(IMotorcycleDataStructure motorcycle)
        {
            int numberOfStraightLineParts = _inputOutputSystem.GetNumberOfStraightLinesInCircuit(_pathToCircuitFile);
            int numberOfCurveLineParts = _inputOutputSystem.GetNumberOfCurvesInCircuit(_pathToCircuitFile);

            double result = numberOfStraightLineParts * motorcycle.GetMaxSpeedInStraightLineOfMotorcycle() +
                            numberOfCurveLineParts * motorcycle.GetMaxSpeedInCurveOfMotorcycle();

            return result;
        }
    }
}