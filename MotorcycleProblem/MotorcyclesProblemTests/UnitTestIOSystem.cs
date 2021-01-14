using System;
using MotorcycleProblem.DataStructure;
using MotorcycleProblem.IO;
using NUnit.Framework;
using System.Linq;

namespace MotorcyclesProblemTests
{
    public class Tests
    {
        private string _pathToMotorcyclesFile;
        private string _pathToCircuitFile;
        private IInputOutputSystem _inputOutputSystem;

        [SetUp]
        public void Setup()
        {
            _pathToMotorcyclesFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                     "MotorcycleProblem/MotorcycleProblem/Data/motorcycles.txt");
            
            _pathToCircuitFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                            "MotorcycleProblem/MotorcycleProblem/Data/circuit.txt");
            
            _inputOutputSystem = InputOutputSystemFactoryObject.GetInputOutputSystem();
        }

        [Test]
        public void Test_GetNumberOfCurvesInCircuit_()
        {
            Assert.True(_inputOutputSystem.GetNumberOfCurvesInCircuit(_pathToCircuitFile) == 10);
        }
        
        [Test]
        public void Test_GetNumberOfStraightLinesInCircuit_()
        {
            Assert.True(_inputOutputSystem.GetNumberOfStraightLinesInCircuit(_pathToCircuitFile) == 8);
        }
    }
}