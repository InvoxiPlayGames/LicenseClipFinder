using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseClipFinder
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1", IsNullable = false)]
    public partial class License
    {

        private string signedLicenseField;

        private LicenseSignature signatureField;

        private LicenseLicenseResponseMetadata licenseResponseMetadataField;

        private byte licenseProtocolVersionField;

        /// <remarks/>
        public string SignedLicense
        {
            get
            {
                return this.signedLicenseField;
            }
            set
            {
                this.signedLicenseField = value;
            }
        }

        /// <remarks/>
        public LicenseSignature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        public LicenseLicenseResponseMetadata LicenseResponseMetadata
        {
            get
            {
                return this.licenseResponseMetadataField;
            }
            set
            {
                this.licenseResponseMetadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte LicenseProtocolVersion
        {
            get
            {
                return this.licenseProtocolVersionField;
            }
            set
            {
                this.licenseProtocolVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1")]
    public partial class LicenseSignature
    {

        private string signingKeyHashField;

        private string signatureValueField;

        private string digestAlgorithmField;

        private string signaturePaddingField;

        /// <remarks/>
        public string SigningKeyHash
        {
            get
            {
                return this.signingKeyHashField;
            }
            set
            {
                this.signingKeyHashField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DigestAlgorithm
        {
            get
            {
                return this.digestAlgorithmField;
            }
            set
            {
                this.digestAlgorithmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SignaturePadding
        {
            get
            {
                return this.signaturePaddingField;
            }
            set
            {
                this.signaturePaddingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1")]
    public partial class LicenseLicenseResponseMetadata
    {

        private string licenseIdField;

        private string keyIdField;

        /// <remarks/>
        public string LicenseId
        {
            get
            {
                return this.licenseIdField;
            }
            set
            {
                this.licenseIdField = value;
            }
        }

        /// <remarks/>
        public string KeyId
        {
            get
            {
                return this.keyIdField;
            }
            set
            {
                this.keyIdField = value;
            }
        }
    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1", ElementName = "SignedLicense", IsNullable = true)]
    public partial class SignedLicense
    {

        private SignedLicenseSVLicense sVLicenseField;

        private string sPLicenseBlockField;

        private byte licenseProtocolVersionField;

        /// <remarks/>
        public SignedLicenseSVLicense SVLicense
        {
            get
            {
                return this.sVLicenseField;
            }
            set
            {
                this.sVLicenseField = value;
            }
        }

        /// <remarks/>
        public string SPLicenseBlock
        {
            get
            {
                return this.sPLicenseBlockField;
            }
            set
            {
                this.sPLicenseBlockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte LicenseProtocolVersion
        {
            get
            {
                return this.licenseProtocolVersionField;
            }
            set
            {
                this.licenseProtocolVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/xboxlive/security/clas/LicResp/v1")]
    public partial class SignedLicenseSVLicense
    {

        private string socIDField;

        private string bootModeField;

        private string keyIdField;

        private string uplinkKeyIdField;

        private string bindingToIdentityField;

        private string customPoliciesField;

        private System.DateTime absoluteIssueDateField;

        private string licenseIdField;

        private string licenseTypeField;

        private bool persistField;

        private string licenseUsageField;

        /// <remarks/>
        public string SocID
        {
            get
            {
                return this.socIDField;
            }
            set
            {
                this.socIDField = value;
            }
        }

        /// <remarks/>
        public string BootMode
        {
            get
            {
                return this.bootModeField;
            }
            set
            {
                this.bootModeField = value;
            }
        }

        /// <remarks/>
        public string KeyId
        {
            get
            {
                return this.keyIdField;
            }
            set
            {
                this.keyIdField = value;
            }
        }

        /// <remarks/>
        public string UplinkKeyId
        {
            get
            {
                return this.uplinkKeyIdField;
            }
            set
            {
                this.uplinkKeyIdField = value;
            }
        }

        /// <remarks/>
        public string BindingToIdentity
        {
            get
            {
                return this.bindingToIdentityField;
            }
            set
            {
                this.bindingToIdentityField = value;
            }
        }

        /// <remarks/>
        public string CustomPolicies
        {
            get
            {
                return this.customPoliciesField;
            }
            set
            {
                this.customPoliciesField = value;
            }
        }

        /// <remarks/>
        public System.DateTime AbsoluteIssueDate
        {
            get
            {
                return this.absoluteIssueDateField;
            }
            set
            {
                this.absoluteIssueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LicenseId
        {
            get
            {
                return this.licenseIdField;
            }
            set
            {
                this.licenseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LicenseType
        {
            get
            {
                return this.licenseTypeField;
            }
            set
            {
                this.licenseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Persist
        {
            get
            {
                return this.persistField;
            }
            set
            {
                this.persistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LicenseUsage
        {
            get
            {
                return this.licenseUsageField;
            }
            set
            {
                this.licenseUsageField = value;
            }
        }
    }


    public class CustomPolicies
    {
        public bool enforceConcurrency { get; set; }
        public string entitlementId { get; set; }
        public string entitlementSatisfaction { get; set; }
        public DateTime expiresAt { get; set; }
        public bool isOffline { get; set; }
        public string leaseEnforcement { get; set; }
        public string leaseUri { get; set; }
        public string legacyProductId { get; set; }
        public string[] keyIds { get; set; }
        public string kind { get; set; }
        public Package[] packages { get; set; }
        public DateTime pollAt { get; set; }
        public bool refreshOnStartup { get; set; }
        public string root { get; set; }
        public string subscriptionProductId { get; set; }
        public int version { get; set; }
    }

    public class Package
    {
        public string packageIdentifier { get; set; }
        public string packageType { get; set; }
        public object[] productAddOns { get; set; }
        public string productId { get; set; }
        public string skuId { get; set; }
    }



}
