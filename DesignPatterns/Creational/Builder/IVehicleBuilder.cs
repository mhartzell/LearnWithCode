namespace PMasta.Learning.DesignPatterns.Creational.Builder
{
    public interface IVehicleBuilder
    {
        void BuildEngine();
        void BuildExhaust();
        void BuildInterior();
        void BuildSuspension();
        IVehicle GetVehicle();
        void InitializeVehicle();
    }
}
