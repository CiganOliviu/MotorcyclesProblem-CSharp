namespace MotorcycleProblem.DataStructure
{
    public class MotorcycleDataStructureFactoryObject
    {
        public static IMotorcycleDataStructure GetMotorcycleDataStructure()
        {
            return new MotorcycleDataStructure();
        }
    }
}