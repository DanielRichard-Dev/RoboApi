using RoboModels.RoboEnum;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;

namespace RoboServices.RoboServices
{
    public class RoboService : IRoboService
    {
        public bool AcionarAcaoRobo()
        {
            return true;
        }

        public bool RemoverAcaoRobo()
        {
            return false;
        }

        public RoboModel InicializarRobo()
        {
            var robo = new RoboModel();

            robo.Braco.Add(new RoboBracoModel { PosicaoBraco = RoboPosicaoBracoEnum.Esquerdo });
            robo.Braco.Add(new RoboBracoModel { PosicaoBraco = RoboPosicaoBracoEnum.Direito });

            return robo;
        }
    }
}
