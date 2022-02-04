using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SME.Terceirizadas.Gateway.Dtos
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Envelope)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "oWsAcessoModel", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class OWsAcessoModel
    {
        public OWsAcessoModel()
        {

        }

        [XmlElement(ElementName = "StrId", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrId;

        [XmlElement(ElementName = "StrToken", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrToken;
    }

    [XmlRoot(ElementName = "Alimento", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class Alimento
    {

        [XmlElement(ElementName = "StrCodSup", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public double StrCodSup;

        [XmlElement(ElementName = "StrCodPapa", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrCodPapa;

        [XmlElement(ElementName = "StrNomAli", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrNomAli;

        [XmlElement(ElementName = "StrEmbala", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrEmbala;

        [XmlElement(ElementName = "IntQtdVol", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntQtdVol;
    }

    [XmlRoot(ElementName = "alimentos", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class Alimentos
    {

        [XmlElement(ElementName = "Alimento", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public List<Alimento> Alimento;
    }

    [XmlRoot(ElementName = "Guia", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class Guia
    {

        [XmlElement(ElementName = "StrNumGui", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrNumGui;

        [XmlElement(ElementName = "DtEntrega", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string DtEntrega;

        [XmlElement(ElementName = "StrCodUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrCodUni;

        [XmlElement(ElementName = "StrNomUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrNomUni;

        [XmlElement(ElementName = "StrEndUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrEndUni;

        [XmlElement(ElementName = "StrNumUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrNumUni;

        [XmlElement(ElementName = "StrBaiUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrBaiUni;

        [XmlElement(ElementName = "StrCepUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrCepUni;

        [XmlElement(ElementName = "StrCidUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrCidUni;

        [XmlElement(ElementName = "StrEstUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrEstUni;

        [XmlElement(ElementName = "StrConUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public string StrConUni;

        [XmlElement(ElementName = "StrTelUni", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrTelUni;

        [XmlElement(ElementName = "alimentos", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public Alimentos Alimentos;
    }

    [XmlRoot(ElementName = "guias", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class Guias
    {

        [XmlElement(ElementName = "Guia", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public List<Guia> Guia;
    }

    [XmlRoot(ElementName = "ArqSolicitacaoMOD", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class ArqSolicitacaoMOD
    {

        [XmlElement(ElementName = "StrCnpj", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public double StrCnpj;

        [XmlElement(ElementName = "StrNumSol", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int StrNumSol;

        [XmlElement(ElementName = "IntSeqenv", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntSeqenv;

        [XmlElement(ElementName = "guias", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public Guias Guias;

        [XmlElement(ElementName = "IntQtGuia", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntQtGuia;

        [XmlElement(ElementName = "IntTotVol", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public int IntTotVol;
    }

    [XmlRoot(ElementName = "Solicitacao", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
    public class SolicitacaoToProxy
    {
        public SolicitacaoToProxy()
        {

        }
        [XmlElement(ElementName = "oWsAcessoModel", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public acessMOD OWsAcessoModel;

        [XmlElement(ElementName = "ArqSolicitacaoMOD", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public SolicitacaoMOD ArqSolicitacaoMOD;

        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public string Xmlns;

        [XmlText]
        public string Text;
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class BodySolicitacao
    {

        [XmlElement(ElementName = "Solicitacao", Namespace = "https://sigpae.sme.prefeitura.sp.gov.br")]
        public SolicitacaoToProxy Solicitacao;
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeSolicitacao
    {

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public BodySolicitacao Body;

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
