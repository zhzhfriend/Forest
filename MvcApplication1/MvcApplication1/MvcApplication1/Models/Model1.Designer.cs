﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MvcApplication1.Models
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class forecastflowEntities1 : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“forecastflowEntities1”部分中的连接字符串初始化新 forecastflowEntities1 对象。
        /// </summary>
        public forecastflowEntities1() : base("name=forecastflowEntities1", "forecastflowEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 forecastflowEntities1 对象。
        /// </summary>
        public forecastflowEntities1(string connectionString) : base(connectionString, "forecastflowEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 forecastflowEntities1 对象。
        /// </summary>
        public forecastflowEntities1(EntityConnection connection) : base(connection, "forecastflowEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<ave> ave
        {
            get
            {
                if ((_ave == null))
                {
                    _ave = base.CreateObjectSet<ave>("ave");
                }
                return _ave;
            }
        }
        private ObjectSet<ave> _ave;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<data> data
        {
            get
            {
                if ((_data == null))
                {
                    _data = base.CreateObjectSet<data>("data");
                }
                return _data;
            }
        }
        private ObjectSet<data> _data;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<dic> dic
        {
            get
            {
                if ((_dic == null))
                {
                    _dic = base.CreateObjectSet<dic>("dic");
                }
                return _dic;
            }
        }
        private ObjectSet<dic> _dic;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<cloth> cloth
        {
            get
            {
                if ((_cloth == null))
                {
                    _cloth = base.CreateObjectSet<cloth>("cloth");
                }
                return _cloth;
            }
        }
        private ObjectSet<cloth> _cloth;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 ave EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToave(ave ave)
        {
            base.AddObject("ave", ave);
        }
    
        /// <summary>
        /// 用于向 data EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTodata(data data)
        {
            base.AddObject("data", data);
        }
    
        /// <summary>
        /// 用于向 dic EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTodic(dic dic)
        {
            base.AddObject("dic", dic);
        }
    
        /// <summary>
        /// 用于向 cloth EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTocloth(cloth cloth)
        {
            base.AddObject("cloth", cloth);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="forecastflowModel", Name="ave")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ave : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 ave 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        public static ave Createave(global::System.Int32 id)
        {
            ave ave = new ave();
            ave.id = id;
            return ave;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> flag
        {
            get
            {
                return _flag;
            }
            set
            {
                OnflagChanging(value);
                ReportPropertyChanging("flag");
                _flag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("flag");
                OnflagChanged();
            }
        }
        private Nullable<global::System.Int32> _flag;
        partial void OnflagChanging(Nullable<global::System.Int32> value);
        partial void OnflagChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> cout
        {
            get
            {
                return _cout;
            }
            set
            {
                OncoutChanging(value);
                ReportPropertyChanging("cout");
                _cout = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cout");
                OncoutChanged();
            }
        }
        private Nullable<global::System.Decimal> _cout;
        partial void OncoutChanging(Nullable<global::System.Decimal> value);
        partial void OncoutChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> cin
        {
            get
            {
                return _cin;
            }
            set
            {
                OncinChanging(value);
                ReportPropertyChanging("cin");
                _cin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cin");
                OncinChanged();
            }
        }
        private Nullable<global::System.Decimal> _cin;
        partial void OncinChanging(Nullable<global::System.Decimal> value);
        partial void OncinChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> cflow
        {
            get
            {
                return _cflow;
            }
            set
            {
                OncflowChanging(value);
                ReportPropertyChanging("cflow");
                _cflow = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cflow");
                OncflowChanged();
            }
        }
        private Nullable<global::System.Decimal> _cflow;
        partial void OncflowChanging(Nullable<global::System.Decimal> value);
        partial void OncflowChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> tongfeng
        {
            get
            {
                return _tongfeng;
            }
            set
            {
                OntongfengChanging(value);
                ReportPropertyChanging("tongfeng");
                _tongfeng = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tongfeng");
                OntongfengChanged();
            }
        }
        private Nullable<global::System.Decimal> _tongfeng;
        partial void OntongfengChanging(Nullable<global::System.Decimal> value);
        partial void OntongfengChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> clothId
        {
            get
            {
                return _clothId;
            }
            set
            {
                OnclothIdChanging(value);
                ReportPropertyChanging("clothId");
                _clothId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("clothId");
                OnclothIdChanged();
            }
        }
        private Nullable<global::System.Int32> _clothId;
        partial void OnclothIdChanging(Nullable<global::System.Int32> value);
        partial void OnclothIdChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="forecastflowModel", Name="cloth")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class cloth : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 cloth 对象。
        /// </summary>
        /// <param name="clothid">clothid 属性的初始值。</param>
        public static cloth Createcloth(global::System.Int32 clothid)
        {
            cloth cloth = new cloth();
            cloth.clothid = clothid;
            return cloth;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 clothid
        {
            get
            {
                return _clothid;
            }
            set
            {
                if (_clothid != value)
                {
                    OnclothidChanging(value);
                    ReportPropertyChanging("clothid");
                    _clothid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("clothid");
                    OnclothidChanged();
                }
            }
        }
        private global::System.Int32 _clothid;
        partial void OnclothidChanging(global::System.Int32 value);
        partial void OnclothidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String chengfen
        {
            get
            {
                return _chengfen;
            }
            set
            {
                OnchengfenChanging(value);
                ReportPropertyChanging("chengfen");
                _chengfen = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("chengfen");
                OnchengfenChanged();
            }
        }
        private global::System.String _chengfen;
        partial void OnchengfenChanging(global::System.String value);
        partial void OnchengfenChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String houdu
        {
            get
            {
                return _houdu;
            }
            set
            {
                OnhouduChanging(value);
                ReportPropertyChanging("houdu");
                _houdu = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("houdu");
                OnhouduChanged();
            }
        }
        private global::System.String _houdu;
        partial void OnhouduChanging(global::System.String value);
        partial void OnhouduChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String touqixing
        {
            get
            {
                return _touqixing;
            }
            set
            {
                OntouqixingChanging(value);
                ReportPropertyChanging("touqixing");
                _touqixing = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("touqixing");
                OntouqixingChanged();
            }
        }
        private global::System.String _touqixing;
        partial void OntouqixingChanging(global::System.String value);
        partial void OntouqixingChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String yiling
        {
            get
            {
                return _yiling;
            }
            set
            {
                OnyilingChanging(value);
                ReportPropertyChanging("yiling");
                _yiling = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("yiling");
                OnyilingChanged();
            }
        }
        private global::System.String _yiling;
        partial void OnyilingChanging(global::System.String value);
        partial void OnyilingChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String xiukou
        {
            get
            {
                return _xiukou;
            }
            set
            {
                OnxiukouChanging(value);
                ReportPropertyChanging("xiukou");
                _xiukou = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("xiukou");
                OnxiukouChanged();
            }
        }
        private global::System.String _xiukou;
        partial void OnxiukouChanging(global::System.String value);
        partial void OnxiukouChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dibai
        {
            get
            {
                return _dibai;
            }
            set
            {
                OndibaiChanging(value);
                ReportPropertyChanging("dibai");
                _dibai = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dibai");
                OndibaiChanged();
            }
        }
        private global::System.String _dibai;
        partial void OndibaiChanging(global::System.String value);
        partial void OndibaiChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String qitakaikou
        {
            get
            {
                return _qitakaikou;
            }
            set
            {
                OnqitakaikouChanging(value);
                ReportPropertyChanging("qitakaikou");
                _qitakaikou = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("qitakaikou");
                OnqitakaikouChanged();
            }
        }
        private global::System.String _qitakaikou;
        partial void OnqitakaikouChanging(global::System.String value);
        partial void OnqitakaikouChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String haoxing
        {
            get
            {
                return _haoxing;
            }
            set
            {
                OnhaoxingChanging(value);
                ReportPropertyChanging("haoxing");
                _haoxing = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("haoxing");
                OnhaoxingChanged();
            }
        }
        private global::System.String _haoxing;
        partial void OnhaoxingChanging(global::System.String value);
        partial void OnhaoxingChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String lingwei
        {
            get
            {
                return _lingwei;
            }
            set
            {
                OnlingweiChanging(value);
                ReportPropertyChanging("lingwei");
                _lingwei = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("lingwei");
                OnlingweiChanged();
            }
        }
        private global::System.String _lingwei;
        partial void OnlingweiChanging(global::System.String value);
        partial void OnlingweiChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String xiukouwei
        {
            get
            {
                return _xiukouwei;
            }
            set
            {
                OnxiukouweiChanging(value);
                ReportPropertyChanging("xiukouwei");
                _xiukouwei = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("xiukouwei");
                OnxiukouweiChanged();
            }
        }
        private global::System.String _xiukouwei;
        partial void OnxiukouweiChanging(global::System.String value);
        partial void OnxiukouweiChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String xiabaiwei
        {
            get
            {
                return _xiabaiwei;
            }
            set
            {
                OnxiabaiweiChanging(value);
                ReportPropertyChanging("xiabaiwei");
                _xiabaiwei = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("xiabaiwei");
                OnxiabaiweiChanged();
            }
        }
        private global::System.String _xiabaiwei;
        partial void OnxiabaiweiChanging(global::System.String value);
        partial void OnxiabaiweiChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String qita
        {
            get
            {
                return _qita;
            }
            set
            {
                OnqitaChanging(value);
                ReportPropertyChanging("qita");
                _qita = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("qita");
                OnqitaChanged();
            }
        }
        private global::System.String _qita;
        partial void OnqitaChanging(global::System.String value);
        partial void OnqitaChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String xuanchuixing
        {
            get
            {
                return _xuanchuixing;
            }
            set
            {
                OnxuanchuixingChanging(value);
                ReportPropertyChanging("xuanchuixing");
                _xuanchuixing = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("xuanchuixing");
                OnxuanchuixingChanged();
            }
        }
        private global::System.String _xuanchuixing;
        partial void OnxuanchuixingChanging(global::System.String value);
        partial void OnxuanchuixingChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="forecastflowModel", Name="data")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class data : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 data 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        /// <param name="flow">flow 属性的初始值。</param>
        public static data Createdata(global::System.Int32 id, global::System.Decimal flow)
        {
            data data = new data();
            data.id = id;
            data.flow = flow;
            return data;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> fin
        {
            get
            {
                return _fin;
            }
            set
            {
                OnfinChanging(value);
                ReportPropertyChanging("fin");
                _fin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fin");
                OnfinChanged();
            }
        }
        private Nullable<global::System.Decimal> _fin;
        partial void OnfinChanging(Nullable<global::System.Decimal> value);
        partial void OnfinChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> fout
        {
            get
            {
                return _fout;
            }
            set
            {
                OnfoutChanging(value);
                ReportPropertyChanging("fout");
                _fout = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fout");
                OnfoutChanged();
            }
        }
        private Nullable<global::System.Decimal> _fout;
        partial void OnfoutChanging(Nullable<global::System.Decimal> value);
        partial void OnfoutChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal flow
        {
            get
            {
                return _flow;
            }
            set
            {
                OnflowChanging(value);
                ReportPropertyChanging("flow");
                _flow = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("flow");
                OnflowChanged();
            }
        }
        private global::System.Decimal _flow;
        partial void OnflowChanging(global::System.Decimal value);
        partial void OnflowChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> flag
        {
            get
            {
                return _flag;
            }
            set
            {
                OnflagChanging(value);
                ReportPropertyChanging("flag");
                _flag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("flag");
                OnflagChanged();
            }
        }
        private Nullable<global::System.Int32> _flag;
        partial void OnflagChanging(Nullable<global::System.Int32> value);
        partial void OnflagChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="forecastflowModel", Name="dic")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class dic : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 dic 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        public static dic Createdic(global::System.Int32 id)
        {
            dic dic = new dic();
            dic.id = id;
            return dic;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> flag
        {
            get
            {
                return _flag;
            }
            set
            {
                OnflagChanging(value);
                ReportPropertyChanging("flag");
                _flag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("flag");
                OnflagChanged();
            }
        }
        private Nullable<global::System.Int32> _flag;
        partial void OnflagChanging(Nullable<global::System.Int32> value);
        partial void OnflagChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
    }

    #endregion
    
}