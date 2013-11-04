// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Xml;
    using System.IO;


    [Serializable]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_DefaultShapeDefinition
    {

        private CT_ShapeProperties spPrField;

        private CT_TextBodyProperties bodyPrField;

        private CT_TextListStyle lstStyleField;

        private CT_ShapeStyle styleField;

        private CT_OfficeArtExtensionList extLstField;
        public static CT_DefaultShapeDefinition Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DefaultShapeDefinition ctObj = new CT_DefaultShapeDefinition();
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.LocalName == "spPr")
                    ctObj.spPr = CT_ShapeProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "bodyPr")
                    ctObj.bodyPr = CT_TextBodyProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "lstStyle")
                    ctObj.lstStyle = CT_TextListStyle.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "style")
                    ctObj.style = CT_ShapeStyle.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "extLst")
                    ctObj.extLst = CT_OfficeArtExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            sw.Write(">");
            if (this.spPr != null)
                this.spPr.Write(sw, "spPr");
            if (this.bodyPr != null)
                this.bodyPr.Write(sw, "bodyPr");
            if (this.lstStyle != null)
                this.lstStyle.Write(sw, "lstStyle");
            if (this.style != null)
                this.style.Write(sw, "style");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_DefaultShapeDefinition()
        {
            //this.extLstField = new CT_OfficeArtExtensionList();
            //this.styleField = new CT_ShapeStyle();
            //this.lstStyleField = new CT_TextListStyle();
            //this.bodyPrField = new CT_TextBodyProperties();
            //this.spPrField = new CT_ShapeProperties();
        }

        [XmlElement(Order = 0)]
        public CT_ShapeProperties spPr
        {
            get
            {
                return this.spPrField;
            }
            set
            {
                this.spPrField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_TextBodyProperties bodyPr
        {
            get
            {
                return this.bodyPrField;
            }
            set
            {
                this.bodyPrField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_TextListStyle lstStyle
        {
            get
            {
                return this.lstStyleField;
            }
            set
            {
                this.lstStyleField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_ShapeStyle style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
    }


    [Serializable]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_ObjectStyleDefaults
    {

        private CT_DefaultShapeDefinition spDefField;

        private CT_DefaultShapeDefinition lnDefField;

        private CT_DefaultShapeDefinition txDefField;

        private CT_OfficeArtExtensionList extLstField;

        public CT_ObjectStyleDefaults()
        {
            //this.extLstField = new CT_OfficeArtExtensionList();
            //this.txDefField = new CT_DefaultShapeDefinition();
            //this.lnDefField = new CT_DefaultShapeDefinition();
            //this.spDefField = new CT_DefaultShapeDefinition();
        }
        public static CT_ObjectStyleDefaults Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ObjectStyleDefaults ctObj = new CT_ObjectStyleDefaults();
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.LocalName == "spDef")
                    ctObj.spDef = CT_DefaultShapeDefinition.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "lnDef")
                    ctObj.lnDef = CT_DefaultShapeDefinition.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "txDef")
                    ctObj.txDef = CT_DefaultShapeDefinition.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "extLst")
                    ctObj.extLst = CT_OfficeArtExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            sw.Write(">");
            if (this.spDef != null)
                this.spDef.Write(sw, "spDef");
            if (this.lnDef != null)
                this.lnDef.Write(sw, "lnDef");
            if (this.txDef != null)
                this.txDef.Write(sw, "txDef");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        [XmlElement(Order = 0)]
        public CT_DefaultShapeDefinition spDef
        {
            get
            {
                return this.spDefField;
            }
            set
            {
                this.spDefField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_DefaultShapeDefinition lnDef
        {
            get
            {
                return this.lnDefField;
            }
            set
            {
                this.lnDefField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_DefaultShapeDefinition txDef
        {
            get
            {
                return this.txDefField;
            }
            set
            {
                this.txDefField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
    }
}
