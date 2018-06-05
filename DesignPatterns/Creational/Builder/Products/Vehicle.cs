namespace PMasta.LearnWithCode.DesignPatterns.Creational.Builder.Products
{
    /// <summary>
    /// A concrete implementation of the Product (vehicle).
    /// </summary>
    internal class Vehicle : IVehicle
    {
        private string _engine;
        private string _exhaust;
        private string _interior;
        private string _suspension;

        public void AddEngine(string engineType)
        {
            this._engine = engineType;
        }

        public void AddExhaust(string exhaustType)
        {
            this._exhaust = exhaustType;
        }

        public void AddInterior(string interiorType)
        {
            this._interior = interiorType;
        }

        public void AddSuspension(string suspensionType)
        {
            this._suspension = suspensionType;
        }

        public string GetEngine()
        {
            return this._engine;
        }

        public string GetExhaust()
        {
            return this._exhaust;
        }

        public string GetInterior()
        {
            return this._interior;
        }

        public string GetSuspension()
        {
            return this._suspension;
        }
    }
}
