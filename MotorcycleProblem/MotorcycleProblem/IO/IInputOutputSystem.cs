using MotorcycleProblem.DataStructure;

namespace MotorcycleProblem.IO
{
    public interface IInputOutputSystem
    {
        int GetNumberOfMotorcycles(string nameOfFile);
        
        int GetNumberOfCurvesInCircuit(string nameOfFile);
        int GetNumberOfStraightLinesInCircuit(string nameOfFile);
        
        IMotorcycleDataStructure[] GetMotorcyclesFromFile(string nameOfFile, int numberOfMotorcycles);
        void PutsMotorcyclesInConsole(IMotorcycleDataStructure[] motorcycles);
    }
}