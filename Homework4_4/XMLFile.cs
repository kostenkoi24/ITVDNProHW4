using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4_4
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Document
    {

        private DocumentDocHeader docHeaderField;

        private DocumentRow[] tableField;

        /// <remarks/>
        public DocumentDocHeader DocHeader
        {
            get
            {
                return this.docHeaderField;
            }
            set
            {
                this.docHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Row", IsNullable = false)]
        public DocumentRow[] Table
        {
            get
            {
                return this.tableField;
            }
            set
            {
                this.tableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentDocHeader
    {

        private string dataField;

        /// <remarks/>
        public string Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentRow
    {

        private string goodsField;

        private double amountField;

        private int qtyField;

        /// <remarks/>
        public string Goods
        {
            get
            {
                return this.goodsField;
            }
            set
            {
                this.goodsField = value;
            }
        }

        /// <remarks/>
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public int Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }



}
