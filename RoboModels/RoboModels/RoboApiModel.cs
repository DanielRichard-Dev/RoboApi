using RoboModels.RoboEnum;

namespace RoboModels.RoboModels
{
    public class RoboApiModel
    {
        public RoboApiModel()
        {
            Robo = new RoboModel();
        }

        public RoboModel Robo { get; set; }
        public RoboCodigoMovimentoBracoEnum RoboCodigoMovimentoBraco { get; set; }
        public RoboCodigoMovimentoCabecaEnum RoboCodigoMovimentoCabeca { get; set; }
    }
}
