namespace RoboModels.RoboModels
{
    public class RoboCotoveloModel : RoboPulsoModel
    {
        public bool CotoveloRepouso { get; set; } = true;
        public bool CotoveloLevementeContraido { get; set; }
        public bool CotoveloContraido { get; set; }
        public bool CotoveloFormenteContraido { get; set; }
    }
}
