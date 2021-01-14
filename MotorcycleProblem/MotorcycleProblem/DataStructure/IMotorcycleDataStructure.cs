namespace MotorcycleProblem.DataStructure
{
    public interface IMotorcycleDataStructure
    {
        public string GetBrandOfMotorcycle();
        public void SetBrandOfMotorcycle(string newBrand);

        public string GetModelOfMotorcycle();
        public void SetModelOfMotorcycle(string newModel);

        public int GetCapacityOfMotorcycle();
        public void SetCapacityOfMotorcycle(int newCapacity);

        public string GetTypeOfMotorcycle();
        public void SetTypeOfMotorcycle(string newType);

        public double GetMaxSpeedInStraightLineOfMotorcycle();
        public void SetMaxSpeedInStraightLineOfMotorcycle(double newMaxSpeedInStraightLine);

        public double GetMaxSpeedInCurveOfMotorcycle();
        public void SetMaxSpeedInCurveOfMotorcycle(double newMaxSpeedInCurve);
    }
}