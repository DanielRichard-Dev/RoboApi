using RoboModels.RoboModels;

namespace RoboServices.RoboInterfaces
{
    public interface IRoboService
    {
        bool AcionarAcaoRobo();

        bool RemoverAcaoRobo();

        RoboApiModel CarregarRobo();

        RoboApiModel MovimentarBracoRobo(RoboApiModel robo);
    }
}
