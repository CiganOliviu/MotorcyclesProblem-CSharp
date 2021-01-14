using System;
using MotorcycleProblem.DataStructure;
using MotorcycleProblem.IO;
using MotorcycleProblem.WinnerPlacesProcessor;

namespace MotorcycleProblem
{
    class Program
    {
        private static IMotorcycleDataStructure[] _motorcycleDataStructure;
        private static IInputOutputSystem _inputOutputSystem;
        private static IWinnerPlacesProcessor _winnerPlacesProcessor;
        private static string _pathToFile;
        private static int _numberOfMotorcycles;
        
        static void Main(string[] args)
        {
            _pathToFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                     "MotorcycleProblem/MotorcycleProblem/Data/motorcycles.txt");

            _inputOutputSystem = InputOutputSystemFactoryObject.GetInputOutputSystem();
            
            _numberOfMotorcycles = _inputOutputSystem.GetNumberOfMotorcycles(_pathToFile);
            _motorcycleDataStructure = _inputOutputSystem.GetMotorcyclesFromFile(_pathToFile, _numberOfMotorcycles);

            _winnerPlacesProcessor =
                WinnerPlacesProcessorFactoryObject.GetWinnerPlacesProcessor();
            
            _winnerPlacesProcessor.GetMotorcyclesPositionInTable(_numberOfMotorcycles, _motorcycleDataStructure);
            
            _inputOutputSystem.PutsMotorcyclesInConsole(_motorcycleDataStructure);
        }
    }
}