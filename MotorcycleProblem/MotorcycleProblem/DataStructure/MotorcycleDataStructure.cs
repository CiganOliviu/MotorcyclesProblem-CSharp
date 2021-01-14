namespace MotorcycleProblem.DataStructure
{
    public class MotorcycleDataStructure : IMotorcycleDataStructure
    {
        private string _brand = new string("");
        private string _model = new string("");
        private int _capacity = 0;
        private string _type = new string("");
        private double _maxSpeedInStraightLine = 0.0;
        private double _maxSpeedInCurve = 0.0;
        
        public string GetBrandOfMotorcycle()
        {
            return this._brand;
        }

        public void SetBrandOfMotorcycle(string newBrand)
        {
            this._brand = newBrand;
        }

        public string GetModelOfMotorcycle()
        {
            return this._model;
        }

        public void SetModelOfMotorcycle(string newModel)
        {
            this._model = newModel;
        }

        public int GetCapacityOfMotorcycle()
        {
            return this._capacity;
        }

        public void SetCapacityOfMotorcycle(int newCapacity)
        {
            this._capacity = newCapacity;
        }

        public string GetTypeOfMotorcycle()
        {
            return this._type;
        }

        public void SetTypeOfMotorcycle(string newType)
        {
            this._type = newType;
        }

        public double GetMaxSpeedInStraightLineOfMotorcycle()
        {
            return this._maxSpeedInStraightLine;
        }

        public void SetMaxSpeedInStraightLineOfMotorcycle(double newMaxSpeedInStraightLine)
        {
            this._maxSpeedInStraightLine = newMaxSpeedInStraightLine;
        }

        public double GetMaxSpeedInCurveOfMotorcycle()
        {
            return this._maxSpeedInCurve;
        }

        public void SetMaxSpeedInCurveOfMotorcycle(double newMaxSpeedInCurve)
        {
            this._maxSpeedInCurve = newMaxSpeedInCurve;
        }
    }
}