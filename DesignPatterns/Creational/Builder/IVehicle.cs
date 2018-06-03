namespace PMasta.Learning.DesignPatterns.Creational.Builder
{
    public interface IVehicle
    {
        void AddEngine(string engineType);
        void AddExhaust(string exhaustType);
        void AddInterior(string interiorType);
        void AddSuspension(string suspensionType);
        string GetEngine();
        string GetExhaust();
        string GetInterior();
        string GetSuspension();
    }
}
