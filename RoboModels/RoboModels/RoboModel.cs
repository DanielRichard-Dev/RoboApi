using System.Collections.Generic;

namespace RoboModels.RoboModels
{
    public class RoboModel
    {
        public RoboModel()
        {
            Bracos = new List<RoboBracoModel>();
        }

        public bool CabecaRotacaoMenosNoventa { get; set; }
        public bool CabecaRotacaoMenosQuarentaCinco { get; set; }
        public bool CabecaRotacaoRepouso { get; set; } = true;
        public bool CabecaRotacaoQuarencaCinco { get; set; }
        public bool CabecaRotacaoNoventa { get; set; }
        public bool CabecaInclinacaoCima { get; set; }
        public bool CabecaInclinacaoRepouso { get; set; } = true;
        public bool CabecaInclinacaoBaixo { get; set; }
        public List<RoboBracoModel> Bracos { get; set; }
    }
}
