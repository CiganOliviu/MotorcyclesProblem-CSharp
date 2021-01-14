namespace MotorcycleProblem.WinnerPlacesProcessor
{
    public class WinnerPlacesProcessorFactoryObject
    {
        public static IWinnerPlacesProcessor GetWinnerPlacesProcessor()
        {
            return new WinnerPlacesProcessor();
        }
    }
}