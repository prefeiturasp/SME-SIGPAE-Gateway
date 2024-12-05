using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SME.SIGPAE.Gateway.Dtos
{
    [XmlRoot(ElementName = "oWsAcessoModel", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class OWsAcessoModelCancelamento
    {

        [XmlElement(ElementName = "StrId", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrId;

        [XmlElement(ElementName = "StrToken", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrToken;
    }
    [XmlRoot(ElementName = "GuiCan", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class GuiaCancelamento
    {
        [XmlElement(ElementName = "StrNumGui", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrNumGui;
    }

    [XmlRoot(ElementName = "guias", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class GuiasCancelamento
    {

        [XmlElement(ElementName = "GuiCan", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public List<GuiaCancelamento> Guia;
    }

    [XmlRoot(ElementName = "ArqCancelamento", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class ArqCancelamento
    {

        [XmlElement(ElementName = "StrCnpj", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public double StrCnpj;

        [XmlElement(ElementName = "StrNumSol", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrNumSol;

        [XmlElement(ElementName = "IntSeqenv", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntSeqenv;

        [XmlElement(ElementName = "guias", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public GuiasCancelamento Guias;

        [XmlElement(ElementName = "IntQtGuia", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntQtGuia;

    }

    [XmlRoot(ElementName = "Solicitacao", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class CancelamentoToProxy
    {

        [XmlElement(ElementName = "oWsAcessoModel", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public acessMOD OWsAcessoModel;

        [XmlElement(ElementName = "ArqCancelamento", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public CancelamentoMOD ArqSolicitacaoMOD;

        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public string Xmlns;

        [XmlText]
        public string Text;
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class BodyCancelamento
    {

        [XmlElement(ElementName = "Cancelamento", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public CancelamentoToProxy Cancelamento;
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeCancelamento
    {

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public BodyCancelamento Body;

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi;

        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd;

        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap;

        [XmlText]
        public string Text;
    }


}