//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 

namespace Oddin.OddsFeedSdk.AMQP.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
    public partial class bet_settlement : FeedMessageModel
    {
        public override long GeneratedAt => timestamp;

        private betSettlementMarket[] outcomesField;

        private int productField;

        private string event_idField;

        private long timestampField;

        private long request_idField;

        private bool request_idFieldSpecified;

        private int certaintyField;

        private string event_refidField;

        [System.Xml.Serialization.XmlElement(ElementName = "event_ref_id", IsNullable = true)]
        public string event_refid
        {
            get
            {
                return this.event_refidField;
            }
            set
            {
                this.event_refidField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("market", IsNullable = false)]
        public betSettlementMarket[] outcomes
        {
            get
            {
                return this.outcomesField;
            }
            set
            {
                this.outcomesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string event_id
        {
            get
            {
                return this.event_idField;
            }
            set
            {
                this.event_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long request_id
        {
            get
            {
                return this.request_idField;
            }
            set
            {
                this.request_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool request_idSpecified
        {
            get
            {
                return this.request_idFieldSpecified;
            }
            set
            {
                this.request_idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int certainty
        {
            get
            {
                return this.certaintyField;
            }
            set
            {
                this.certaintyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class betSettlementMarket
    {

        private betSettlementMarketOutcome[] itemsField;

        private int idField;

        private string specifiersField;

        private string extended_specifiersField;

        private int void_reasonField;

        private bool void_reasonFieldSpecified;

        private int statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outcome")]
        public betSettlementMarketOutcome[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string specifiers
        {
            get
            {
                return this.specifiersField;
            }
            set
            {
                this.specifiersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extended_specifiers
        {
            get
            {
                return this.extended_specifiersField;
            }
            set
            {
                this.extended_specifiersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int void_reason
        {
            get
            {
                return this.void_reasonField;
            }
            set
            {
                this.void_reasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool void_reasonSpecified
        {
            get
            {
                return this.void_reasonFieldSpecified;
            }
            set
            {
                this.void_reasonFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class betSettlementMarketOutcome
    {

        private long idField;

        private int resultField;

        private double void_factorField;

        private bool void_factorFieldSpecified;

        private double dead_heat_factorField;

        private bool dead_heat_factorFieldSpecified;

        private long? refidField;
        
        [System.Xml.Serialization.XmlElement(ElementName = "ref_id", IsNullable = true)]
        public long? refid
        {
            get
            {
                return this.refidField;
            }
            set
            {
                this.refidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double void_factor
        {
            get
            {
                return this.void_factorField;
            }
            set
            {
                this.void_factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool void_factorSpecified
        {
            get
            {
                return this.void_factorFieldSpecified;
            }
            set
            {
                this.void_factorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double dead_heat_factor
        {
            get
            {
                return this.dead_heat_factorField;
            }
            set
            {
                this.dead_heat_factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dead_heat_factorSpecified
        {
            get
            {
                return this.dead_heat_factorFieldSpecified;
            }
            set
            {
                this.dead_heat_factorFieldSpecified = value;
            }
        }
    }
}