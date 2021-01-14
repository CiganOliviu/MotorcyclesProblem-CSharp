using System;
using MotorcycleProblem.DataStructure;
using MotorcycleProblem.IO;
using NUnit.Framework;
using System.Linq;

namespace MotorcyclesProblemTests
{
    public class Tests
    {
        private string _pathToFile;
        private IInputOutputSystem _inputOutputSystem;

        [SetUp]
        public void Setup()
        {
            _pathToFile = new string("/media/cigan/Personal/GithubProjects/MotorcyclesProblem-CSharp/" +
                                     "MotorcycleProblem/MotorcycleProblem/Data/motorcycles.txt");
            
            _inputOutputSystem = InputOutputSystemFactoryObject.GetInputOutputSystem();
        }

        [Test]
        public void Test_GetNumberOfMotorcycles_()
        {
            Assert.True(_inputOutputSystem.GetNumberOfMotorcycles(_pathToFile) == 7);
        }
    }
}