using RoboModels.RoboEnum;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;
using System.Collections.Generic;
using System.Linq;

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

        public RoboApiModel CarregarRobo()
        {
            var robo = new RoboApiModel();

            robo.Robo.Bracos.Add(new RoboBracoModel { PosicaoBraco = RoboPosicaoBracoEnum.Esquerdo });
            robo.Robo.Bracos.Add(new RoboBracoModel { PosicaoBraco = RoboPosicaoBracoEnum.Direito });

            return robo;
        }

        public RoboApiModel MovimentarBracoRobo(RoboApiModel robo)
        {
            var roboResponse = AtivarMovimentacaoBracoRobo(robo);

            return roboResponse;
        }

        public RoboApiModel MovimentarCabecaRobo(RoboApiModel robo)
        {
            var roboResponse = AtivarMovimentacaoCabecaRobo(robo);

            return roboResponse;
        }

        private RoboApiModel AtivarMovimentacaoBracoRobo(RoboApiModel robo)
        {
            foreach (var bracosRobo in robo.Robo.Bracos)
            {
                if (bracosRobo.PosicaoBraco == RoboPosicaoBracoEnum.Esquerdo)
                {
                    switch (robo.RoboCodigoMovimentoBraco)
                    {
                        case RoboCodigoMovimentoBracoEnum.BracoEsquerdoRepouso:
                            bracosRobo.CotoveloRepouso = true;
                            bracosRobo.CotoveloLevementeContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoEsquerdoLevementeContraido:
                            bracosRobo.CotoveloLevementeContraido = true;
                            bracosRobo.CotoveloRepouso = false;
                            bracosRobo.CotoveloContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoEsquerdoContraido:
                            bracosRobo.CotoveloContraido = true;
                            bracosRobo.CotoveloLevementeContraido = false;
                            bracosRobo.CotoveloFormenteContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoEsquerdoFormenteContraido:
                            bracosRobo.CotoveloFormenteContraido = true;
                            bracosRobo.CotoveloContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoMenosNoventa:

                            bracosRobo.PulsoRotacaoMenosNoventa = true;
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoMenosQuarentaCinco:
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = true;
                            bracosRobo.PulsoRotacaoMenosNoventa = false;
                            bracosRobo.PulsoEmRepouso = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRepouso:
                            bracosRobo.PulsoEmRepouso = true;
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = false;
                            bracosRobo.PulsoRotacaoQuarentaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoQuarentaCinco:
                            bracosRobo.PulsoRotacaoQuarentaCinco = true;
                            bracosRobo.PulsoEmRepouso = false;
                            bracosRobo.PulsoRotacaoNoventa = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoNoventa:
                                bracosRobo.PulsoRotacaoNoventa = true;
                                bracosRobo.PulsoRotacaoQuarentaCinco = false;
                                bracosRobo.PulsoRotacaoCemTrintaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoCemTrintaCinco:
                            bracosRobo.PulsoRotacaoCemTrintaCinco = true;
                            bracosRobo.PulsoRotacaoNoventa = false;
                            bracosRobo.PulsoRotacaoCemOitenta = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoCemOitenta:
                            bracosRobo.PulsoRotacaoCemOitenta = true;
                            bracosRobo.PulsoRotacaoCemTrintaCinco = false;

                            break;
                    }
                }

                if (bracosRobo.PosicaoBraco == RoboPosicaoBracoEnum.Direito)
                {
                    switch (robo.RoboCodigoMovimentoBraco)
                    {
                        case RoboCodigoMovimentoBracoEnum.BracoDireitoRepouso:
                            bracosRobo.CotoveloRepouso = true;
                            bracosRobo.CotoveloLevementeContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoDireitoLevementeContraido:
                            bracosRobo.CotoveloLevementeContraido = true;
                            bracosRobo.CotoveloRepouso = false;
                            bracosRobo.CotoveloContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoDireitoContraido:
                            bracosRobo.CotoveloContraido = true;
                            bracosRobo.CotoveloLevementeContraido = false;
                            bracosRobo.CotoveloFormenteContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.BracoDireitoFormenteContraido:
                            bracosRobo.CotoveloFormenteContraido = true;
                            bracosRobo.CotoveloContraido = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoMenosNoventa:

                            bracosRobo.PulsoRotacaoMenosNoventa = true;
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoMenosQuarentaCinco:
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = true;
                            bracosRobo.PulsoRotacaoMenosNoventa = false;
                            bracosRobo.PulsoEmRepouso = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRepouso:
                            bracosRobo.PulsoEmRepouso = true;
                            bracosRobo.PulsoRotacaoMenosQuarentaCinco = false;
                            bracosRobo.PulsoRotacaoQuarentaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoQuarentaCinco:
                            bracosRobo.PulsoRotacaoQuarentaCinco = true;
                            bracosRobo.PulsoEmRepouso = false;
                            bracosRobo.PulsoRotacaoNoventa = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoNoventa:
                            bracosRobo.PulsoRotacaoNoventa = true;
                            bracosRobo.PulsoRotacaoQuarentaCinco = false;
                            bracosRobo.PulsoRotacaoCemTrintaCinco = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoCemTrintaCinco:
                            bracosRobo.PulsoRotacaoCemTrintaCinco = true;
                            bracosRobo.PulsoRotacaoNoventa = false;
                            bracosRobo.PulsoRotacaoCemOitenta = false;

                            break;

                        case RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoCemOitenta:
                            bracosRobo.PulsoRotacaoCemOitenta = true;
                            bracosRobo.PulsoRotacaoCemTrintaCinco = false;

                            break;
                    }
                }
            }      

            return robo;
        }

        private RoboApiModel AtivarMovimentacaoCabecaRobo(RoboApiModel robo)
        {
            switch (robo.RoboCodigoMovimentoCabeca)
            {
                case RoboCodigoMovimentoCabecaEnum.CabecaRotacaoMenosNoventa:
                    robo.Robo.CabecaRotacaoMenosNoventa = true;
                    robo.Robo.CabecaRotacaoMenosQuarentaCinco = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaRotacaoMenosQuarentaCinco:
                    robo.Robo.CabecaRotacaoMenosQuarentaCinco = true;
                    robo.Robo.CabecaRotacaoMenosNoventa = false;
                    robo.Robo.CabecaRotacaoRepouso = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaRotacaoRepouso:
                    robo.Robo.CabecaRotacaoRepouso = true;
                    robo.Robo.CabecaRotacaoMenosQuarentaCinco = false;
                    robo.Robo.CabecaRotacaoQuarencaCinco = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaRotacaoQuarentaCinco:
                    robo.Robo.CabecaRotacaoQuarencaCinco = true;
                    robo.Robo.CabecaRotacaoRepouso = false;
                    robo.Robo.CabecaRotacaoNoventa = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaRotacaoNoventa:
                    robo.Robo.CabecaRotacaoNoventa = true;
                    robo.Robo.CabecaRotacaoQuarencaCinco = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoCima:
                    robo.Robo.CabecaInclinacaoCima = true;
                    robo.Robo.CabecaInclinacaoRepouso = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoRepouso:
                    robo.Robo.CabecaInclinacaoRepouso = true;
                    robo.Robo.CabecaInclinacaoCima = false;
                    robo.Robo.CabecaInclinacaoBaixo = false;

                    break;
                case RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoBaixo:
                    robo.Robo.CabecaInclinacaoBaixo = true;
                    robo.Robo.CabecaInclinacaoRepouso = false;

                    break;
            }

            return robo;
        }
    }
}
