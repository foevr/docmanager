
namespace DocumentManager.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // MetadataTypeAttribute 将 RL_USER_FIELDMetadata 标识为类
    //，以携带 RL_USER_FIELD 类的其他元数据。
    [MetadataTypeAttribute(typeof(RL_USER_FIELD.RL_USER_FIELDMetadata))]
    public partial class RL_USER_FIELD
    {

        // 通过此类可将自定义特性附加到
        //RL_USER_FIELD 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RL_USER_FIELDMetadata
        {

            // 元数据类不会实例化。
            private RL_USER_FIELDMetadata()
            {
            }

            public Nullable<int> AUTHTYPE { get; set; }

            public int FIELDID { get; set; }

            public TBFIELD TBFIELD { get; set; }

            public TBUSER TBUSER { get; set; }

            public int USERID { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBCONTRACTMetadata 标识为类
    //，以携带 TBCONTRACT 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBCONTRACT.TBCONTRACTMetadata))]
    public partial class TBCONTRACT
    {

        // 通过此类可将自定义特性附加到
        //TBCONTRACT 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBCONTRACTMetadata
        {

            // 元数据类不会实例化。
            private TBCONTRACTMetadata()
            {
            }

            public int ID { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBFIELDMetadata 标识为类
    //，以携带 TBFIELD 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBFIELD.TBFIELDMetadata))]
    public partial class TBFIELD
    {

        // 通过此类可将自定义特性附加到
        //TBFIELD 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBFIELDMetadata
        {

            // 元数据类不会实例化。
            private TBFIELDMetadata()
            {
            }

            public string FIELDNAME { get; set; }

            public int ID { get; set; }

            public EntityCollection<RL_USER_FIELD> RL_USER_FIELD { get; set; }

            public string TABLENAME { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBMODULEMetadata 标识为类
    //，以携带 TBMODULE 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBMODULE.TBMODULEMetadata))]
    public partial class TBMODULE
    {

        // 通过此类可将自定义特性附加到
        //TBMODULE 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBMODULEMetadata
        {

            // 元数据类不会实例化。
            private TBMODULEMetadata()
            {
            }

            public int ID { get; set; }

            public string MODULEPATH { get; set; }

            public string NAME { get; set; }

            public int ORDERINDEX { get; set; }

            public EntityCollection<TBUSER> TBUSER { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBSYSCODEMetadata 标识为类
    //，以携带 TBSYSCODE 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBSYSCODE.TBSYSCODEMetadata))]
    public partial class TBSYSCODE
    {

        // 通过此类可将自定义特性附加到
        //TBSYSCODE 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBSYSCODEMetadata
        {

            // 元数据类不会实例化。
            private TBSYSCODEMetadata()
            {
            }

            public int ID { get; set; }

            public string NAME { get; set; }

            public int PARENTID { get; set; }

            public TBSYSCODETYPE TBSYSCODETYPE { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBSYSCODETYPEMetadata 标识为类
    //，以携带 TBSYSCODETYPE 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBSYSCODETYPE.TBSYSCODETYPEMetadata))]
    public partial class TBSYSCODETYPE
    {

        // 通过此类可将自定义特性附加到
        //TBSYSCODETYPE 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBSYSCODETYPEMetadata
        {

            // 元数据类不会实例化。
            private TBSYSCODETYPEMetadata()
            {
            }

            public int ID { get; set; }

            public string NAME { get; set; }

            public EntityCollection<TBSYSCODE> TBSYSCODE { get; set; }
        }
    }

    // MetadataTypeAttribute 将 TBUSERMetadata 标识为类
    //，以携带 TBUSER 类的其他元数据。
    [MetadataTypeAttribute(typeof(TBUSER.TBUSERMetadata))]
    public partial class TBUSER
    {

        // 通过此类可将自定义特性附加到
        //TBUSER 类的属性。
        //
        // 例如，下面的代码将 Xyz 属性标记为
        //必需属性并指定有效值的格式:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TBUSERMetadata
        {

            // 元数据类不会实例化。
            private TBUSERMetadata()
            {
            }

            public int ID { get; set; }

            public EntityCollection<RL_USER_FIELD> RL_USER_FIELD { get; set; }

            public EntityCollection<TBMODULE> TBMODULE { get; set; }

            public string USERID { get; set; }

            public string USERNAME { get; set; }

            public string USERPWD { get; set; }
        }
    }
}
