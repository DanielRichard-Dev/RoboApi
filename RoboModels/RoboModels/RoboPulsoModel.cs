namespace RoboModels.RoboModels
{
    public class RoboPulsoModel
    {
        public bool PulsoRotacaoMenosNoventa { get; set; }
        public bool PulsoRotacaoMenosQuarentaCinco { get; set; }
        public bool PulsoEmRepouso { get; set; } = true;
        public bool PulsoRotacaoQuarentaCinco { get; set; }
        public bool PulsoRotacaoNoventa { get; set; }
        public bool PulsoRotacaoCemTrintaCinco { get; set; }
        public bool PulsoRotacaoCemOitenta { get; set; }
    }
}
