using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SME.SIGPAE.Gateway
{
    /// <remarks/>
    [ServiceContract(Namespace = "https://sigpae.sme.prefeitura.sp.gov.br/", Name = "SmeProxySigpaeService")]
    public interface ISmeProxySigpaeService
    {
        /// <remarks/>
        [OperationContract(Action = "https://sigpae.sme.prefeitura.sp.gov.br/Solicitacao")]
        codresMOD Solicitacao(acessMOD oWsAcessoModel, SolicitacaoMOD ArqSolicitacaoMOD);

        /// <remarks/>
        [OperationContract(Action = "https://sigpae.sme.prefeitura.sp.gov.br/Cancelamento")]
        codresMOD Cancelamento(acessMOD oWsAcessoModel, CancelamentoMOD ArqCancelamento);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot(ElementName = "oWsAcessoModel")]
    public class acessMOD
    {
        public acessMOD()
        {

        }

        [DataMember]

        /// <remarks/>
        public string StrId
        {
            get; set;
        }

        [DataMember]
        /// <remarks/>
        public string StrToken
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    public partial class EntregaMOD
    {

        private long cOD_CNPJField;

        private string cOD_GUIAField;

        private string dT_ENT_GUIAField;

        private string pLACA_VEICField;

        private long cNH_MOTOField;

        private string nOM_MOTOField;

        private string lINK_GUIAField;

        private string lOG_ATESTEField;

        private string cOD_UNIDField;

        private double lATI_UNIDField;

        private double lONG_UNIDField;

        private long cOD_ALIMField;

        private string dT_ENT_REALField;

        private double qTD_ALIMField;

        private int cOD_MOTField;

        private string iND_REPOField;

        private int iND_PROCEField;

        private string mOT_DEVField;

        /// <remarks/>
        public long COD_CNPJ
        {
            get
            {
                return this.cOD_CNPJField;
            }
            set
            {
                this.cOD_CNPJField = value;
            }
        }

        /// <remarks/>
        public string COD_GUIA
        {
            get
            {
                return this.cOD_GUIAField;
            }
            set
            {
                this.cOD_GUIAField = value;
            }
        }

        /// <remarks/>
        public string DT_ENT_GUIA
        {
            get
            {
                return this.dT_ENT_GUIAField;
            }
            set
            {
                this.dT_ENT_GUIAField = value;
            }
        }

        /// <remarks/>
        public string PLACA_VEIC
        {
            get
            {
                return this.pLACA_VEICField;
            }
            set
            {
                this.pLACA_VEICField = value;
            }
        }

        /// <remarks/>
        public long CNH_MOTO
        {
            get
            {
                return this.cNH_MOTOField;
            }
            set
            {
                this.cNH_MOTOField = value;
            }
        }

        /// <remarks/>
        public string NOM_MOTO
        {
            get
            {
                return this.nOM_MOTOField;
            }
            set
            {
                this.nOM_MOTOField = value;
            }
        }

        /// <remarks/>
        public string LINK_GUIA
        {
            get
            {
                return this.lINK_GUIAField;
            }
            set
            {
                this.lINK_GUIAField = value;
            }
        }

        /// <remarks/>
        public string LOG_ATESTE
        {
            get
            {
                return this.lOG_ATESTEField;
            }
            set
            {
                this.lOG_ATESTEField = value;
            }
        }

        /// <remarks/>
        public string COD_UNID
        {
            get
            {
                return this.cOD_UNIDField;
            }
            set
            {
                this.cOD_UNIDField = value;
            }
        }

        /// <remarks/>
        public double LATI_UNID
        {
            get
            {
                return this.lATI_UNIDField;
            }
            set
            {
                this.lATI_UNIDField = value;
            }
        }

        /// <remarks/>
        public double LONG_UNID
        {
            get
            {
                return this.lONG_UNIDField;
            }
            set
            {
                this.lONG_UNIDField = value;
            }
        }

        /// <remarks/>
        public long COD_ALIM
        {
            get
            {
                return this.cOD_ALIMField;
            }
            set
            {
                this.cOD_ALIMField = value;
            }
        }

        /// <remarks/>
        public string DT_ENT_REAL
        {
            get
            {
                return this.dT_ENT_REALField;
            }
            set
            {
                this.dT_ENT_REALField = value;
            }
        }

        /// <remarks/>
        public double QTD_ALIM
        {
            get
            {
                return this.qTD_ALIMField;
            }
            set
            {
                this.qTD_ALIMField = value;
            }
        }

        /// <remarks/>
        public int COD_MOT
        {
            get
            {
                return this.cOD_MOTField;
            }
            set
            {
                this.cOD_MOTField = value;
            }
        }

        /// <remarks/>
        public string IND_REPO
        {
            get
            {
                return this.iND_REPOField;
            }
            set
            {
                this.iND_REPOField = value;
            }
        }

        /// <remarks/>
        public int IND_PROCE
        {
            get
            {
                return this.iND_PROCEField;
            }
            set
            {
                this.iND_PROCEField = value;
            }
        }

        /// <remarks/>
        public string MOT_DEV
        {
            get
            {
                return this.mOT_DEVField;
            }
            set
            {
                this.mOT_DEVField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute(ElementName = "GuiCan")]

    public partial class GuiCan
    {

        private string strNumGuiField;


        public string StrNumGui
        {
            get
            {
                return this.strNumGuiField;
            }
            set
            {
                this.strNumGuiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot(ElementName = "CancelamentoMOD")]

    public partial class CancelamentoMOD
    {

        private string strCnpjField;

        private string strNumSolField;

        private int intSeqenvField;



        private int intQtGuiaField;


        public string StrCnpj
        {
            get
            {
                return this.strCnpjField;
            }
            set
            {
                this.strCnpjField = value;
            }
        }


        public string StrNumSol
        {
            get
            {
                return this.strNumSolField;
            }
            set
            {
                this.strNumSolField = value;
            }
        }


        public int IntSeqenv
        {
            get
            {
                return this.intSeqenvField;
            }
            set
            {
                this.intSeqenvField = value;
            }
        }

        [XmlArray(ElementName = "guias")]
        public GuiCan[] guias
        {
            get; set;
        }

        public int IntQtGuia
        {
            get
            {
                return this.intQtGuiaField;
            }
            set
            {
                this.intQtGuiaField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    [XmlRoot(ElementName = "guias")]
    public class GuiasCan
    {

        public GuiCan[] Guia { get; set; }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]



    [DataContract]
    public partial class codresMOD
    {

        private string strStatusField;

        private string strMensagemField;
        [DataMember]

        /// <remarks/>
        public string StrStatus
        {
            get
            {
                return this.strStatusField;
            }
            set
            {
                this.strStatusField = value;
            }
        }
        [DataMember]

        /// <remarks/>
        public string StrMensagem
        {
            get
            {
                return this.strMensagemField;
            }
            set
            {
                this.strMensagemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    [XmlRoot(ElementName = "Alimento")]
    public partial class Alimento
    {

        private string strCodSupField;

        private string strCodPapaField;

        private string strNomAliField;

        private string strTpEmbala;

        private string strQtEmbala;

        private string strDescEmbala;

        private string strPesoEmbala;

        private string strUnMedEmbala;

        public string StrCodSup
        {
            get
            {
                return this.strCodSupField;
            }
            set
            {
                this.strCodSupField = value;
            }
        }


        public string StrCodPapa
        {
            get
            {
                return this.strCodPapaField;
            }
            set
            {
                this.strCodPapaField = value;
            }
        }


        public string StrNomAli
        {
            get
            {
                return this.strNomAliField;
            }
            set
            {
                this.strNomAliField = value;
            }
        }


        public string StrTpEmbala
        {
            get
            {
                return this.strTpEmbala;
            }
            set
            {
                this.strTpEmbala = value;
            }
        }


        public string StrQtEmbala
        {
            get
            {
                return this.strQtEmbala;
            }
            set
            {
                this.strQtEmbala = value;
            }
        }
        public string StrDescEmbala
        {
            get
            {
                return this.strDescEmbala;
            }
            set
            {
                this.strDescEmbala = value;
            }
        }
        public string StrPesoEmbala
        {
            get
            {
                return this.strPesoEmbala;
            }
            set
            {
                this.strPesoEmbala = value;
            }
        }
        public string StrUnMedEmbala
        {
            get
            {
                return this.strUnMedEmbala;
            }
            set
            {
                this.strUnMedEmbala = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    [XmlRoot(ElementName = "alimentos")]
    public partial class Alimentos
    {

        public Alimento[] Alimento { get; set; }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    [XmlRoot(ElementName = "guias")]
    public class Guias
    {

        public Guia[] Guia { get; set; }

    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("guia")]

    public partial class Guia
    {

        private string strNumGuiField;

        private string dtEntregaField;

        private string strCodUniField;

        private string strNomUniField;

        private string strEndUniField;

        private string strNumUniField;

        private string strBaiUniField;

        private string strCepUniField;

        private string strCidUniField;

        private string strEstUniField;

        private string strConUniField;

        private string strTelUniField;

        private Alimentos alimentosField;


        public string StrNumGui
        {
            get
            {
                return this.strNumGuiField;
            }
            set
            {
                this.strNumGuiField = value;
            }
        }


        public string DtEntrega
        {
            get
            {
                return this.dtEntregaField;
            }
            set
            {
                this.dtEntregaField = value;
            }
        }


        public string StrCodUni
        {
            get
            {
                return this.strCodUniField;
            }
            set
            {
                this.strCodUniField = value;
            }
        }


        public string StrNomUni
        {
            get
            {
                return this.strNomUniField;
            }
            set
            {
                this.strNomUniField = value;
            }
        }


        public string StrEndUni
        {
            get
            {
                return this.strEndUniField;
            }
            set
            {
                this.strEndUniField = value;
            }
        }


        public string StrNumUni
        {
            get
            {
                return this.strNumUniField;
            }
            set
            {
                this.strNumUniField = value;
            }
        }


        public string StrBaiUni
        {
            get
            {
                return this.strBaiUniField;
            }
            set
            {
                this.strBaiUniField = value;
            }
        }


        public string StrCepUni
        {
            get
            {
                return this.strCepUniField;
            }
            set
            {
                this.strCepUniField = value;
            }
        }


        public string StrCidUni
        {
            get
            {
                return this.strCidUniField;
            }
            set
            {
                this.strCidUniField = value;
            }
        }


        public string StrEstUni
        {
            get
            {
                return this.strEstUniField;
            }
            set
            {
                this.strEstUniField = value;
            }
        }


        public string StrConUni
        {
            get
            {
                return this.strConUniField;
            }
            set
            {
                this.strConUniField = value;
            }
        }


        public string StrTelUni
        {
            get
            {
                return this.strTelUniField;
            }
            set
            {
                this.strTelUniField = value;
            }
        }

        [XmlArray(ElementName = "alimentos")]
        public Alimento[] alimentos
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    [XmlRoot(ElementName = "ArqSolicitacaoMOD")]
    public partial class SolicitacaoMOD
    {

        private string strCnpjField;

        private string strNumSolField;

        private int intSeqenvField;



        private int intQtGuiaField;

        private int intTotVolField;


        public string StrCnpj
        {
            get
            {
                return this.strCnpjField;
            }
            set
            {
                this.strCnpjField = value;
            }
        }


        public string StrNumSol
        {
            get
            {
                return this.strNumSolField;
            }
            set
            {
                this.strNumSolField = value;
            }
        }


        public int IntSeqenv
        {
            get
            {
                return this.intSeqenvField;
            }
            set
            {
                this.intSeqenvField = value;
            }
        }

        [XmlArray(ElementName = "guias")]
        /// <remarks/>
        public Guia[] guias
        {
            get; set;
        }


        public int IntQtGuia
        {
            get
            {
                return this.intQtGuiaField;
            }
            set
            {
                this.intQtGuiaField = value;
            }
        }


        public int IntTotVol
        {
            get
            {
                return this.intTotVolField;
            }
            set
            {
                this.intTotVolField = value;
            }
        }
    }
}
