using System.Xml.Serialization;

namespace SME.SIGPAE.Gateway.Dtos.ProxyResult
{
    [XmlRoot(ElementName = "CancelamentoResult", Namespace = "")]
    public class CancelamentoResult
    {

        [XmlElement(ElementName = "StrStatus", Namespace = "")]
        public bool StrStatus;

        [XmlElement(ElementName = "StrMessagem", Namespace = "")]
        public string StrMessagem;
    }

    [XmlRoot(ElementName = "CancelamentoResponse", Namespace = "")]
    public class CancelamentoResponse
    {

        [XmlElement(ElementName = "CancelamentoResult", Namespace = "")]
        public codresMOD CancelamentoResult;
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class BodyCancelamento
    {

        [XmlElement(ElementName = "CancelamentoResponse", Namespace = "")]
        public CancelamentoResponse CancelamentoResponse;
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeCancelamento
    {

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public BodyCancelamento Body;

        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap;

        [XmlAttribute(AttributeName = "tns", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Tns;

        [XmlText]
        public string Text;
    }


}