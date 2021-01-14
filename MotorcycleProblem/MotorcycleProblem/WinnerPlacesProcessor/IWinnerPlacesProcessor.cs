using MotorcycleProblem.DataStructure;

namespace MotorcycleProblem.WinnerPlacesProcessor
{
    public interface IWinnerPlacesProcessor
    {
        public void GetMotorcyclesPositionInTable(int numberOfMotorcycles, IMotorcycleDataStructure[] motorcycle);
    }
}