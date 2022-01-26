using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SME.Terceirizadas.Gateway.Dtos.ProxyResult
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Envelope)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "SolicitacaoResult", Namespace = "")]
	public class SolicitacaoResult
	{

		[XmlElement(ElementName = "StrStatus", Namespace = "")]
		public bool StrStatus;

		[XmlElement(ElementName = "StrMessagem", Namespace = "")]
		public string StrMessagem;
	}

	[XmlRoot(ElementName = "SolicitacaoResponse", Namespace = "")]
	public class SolicitacaoResponse
	{

		[XmlElement(ElementName = "SolicitacaoResult", Namespace = "")]
		public codresMOD SolicitacaoResult;
	}

	[XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public class BodySolicitacao
	{

		[XmlElement(ElementName = "SolicitacaoResponse", Namespace = "")]
		public SolicitacaoResponse SolicitacaoResponse;
	}

	[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public class EnvelopeSolicitacao
	{

		[XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
		public BodySolicitacao Body;

		[XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Soap;

		[XmlAttribute(AttributeName = "tns", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Tns;

		[XmlText]
		public string Text;
	}


}
