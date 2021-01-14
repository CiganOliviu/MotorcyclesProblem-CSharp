namespace MotorcycleProblem.IO
{
    public class InputOutputSystemFactoryObject
    {
        public static IInputOutputSystem GetInputOutputSystem()
        {
            return new InputOutputSystem();
        }
    }
}