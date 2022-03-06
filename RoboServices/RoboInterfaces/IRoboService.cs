using RoboModels.RoboModels;

namespace RoboServices.RoboInterfaces
{
    public interface IRoboService
    {
        bool AcionarAcaoRobo();


        bool RemoverAcaoRobo();


        RoboModel InicializarRobo();
    }
}
