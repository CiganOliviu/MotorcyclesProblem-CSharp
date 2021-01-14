using System;
using MotorcycleProblem.DataStructure;
using MotorcycleProblem.IO;

namespace MotorcycleProblem
{
    class Program
    {
        private static IMotorcycleDataStructure[] _motorcycleDataStructure;
        private static IInputOutputSystem _inputOutputSystem;
        private static string _pathToFile;
        private static int _numberOfMotorcycles;
        
        static void Main(string[] args)
        {
            _pathToFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                     "MotorcycleProblem/MotorcycleProblem/Data/motorcycles.txt");

            _inputOutputSystem = InputOutputSystemFactoryObject.GetInputOutputSystem();
            
            _numberOfMotorcycles = _inputOutputSystem.GetNumberOfMotorcycles(_pathToFile);
            _motorcycleDataStructure = _inputOutputSystem.GetMotorcyclesFromFile(_pathToFile, _numberOfMotorcycles);
            
            _inputOutputSystem.PutsMotorcyclesInConsole(_motorcycleDataStructure);

        }
    }
}