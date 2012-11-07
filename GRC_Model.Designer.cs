﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("GRC.Model", "FK_CLIENTE_ENDERECO", "ENDERECO", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GRC.ENDERECO), "CLIENTE", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GRC.CLIENTE), true)]
[assembly: EdmRelationshipAttribute("GRC.Model", "FK_PEDIDO_CLIENTE", "CLIENTE", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GRC.CLIENTE), "PEDIDO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GRC.PEDIDO), true)]
[assembly: EdmRelationshipAttribute("GRC.Model", "PEDIDO_ITEM", "PEDIDO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GRC.PEDIDO), "PRODUTO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GRC.PRODUTO))]

#endregion

namespace GRC
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class GRCEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new GRCEntities object using the connection string found in the 'GRCEntities' section of the application configuration file.
        /// </summary>
        public GRCEntities() : base("name=GRCEntities", "GRCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new GRCEntities object.
        /// </summary>
        public GRCEntities(string connectionString) : base(connectionString, "GRCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new GRCEntities object.
        /// </summary>
        public GRCEntities(EntityConnection connection) : base(connection, "GRCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CLIENTE> CLIENTEs
        {
            get
            {
                if ((_CLIENTEs == null))
                {
                    _CLIENTEs = base.CreateObjectSet<CLIENTE>("CLIENTEs");
                }
                return _CLIENTEs;
            }
        }
        private ObjectSet<CLIENTE> _CLIENTEs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ENDERECO> ENDERECOes
        {
            get
            {
                if ((_ENDERECOes == null))
                {
                    _ENDERECOes = base.CreateObjectSet<ENDERECO>("ENDERECOes");
                }
                return _ENDERECOes;
            }
        }
        private ObjectSet<ENDERECO> _ENDERECOes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PEDIDO> PEDIDOes
        {
            get
            {
                if ((_PEDIDOes == null))
                {
                    _PEDIDOes = base.CreateObjectSet<PEDIDO>("PEDIDOes");
                }
                return _PEDIDOes;
            }
        }
        private ObjectSet<PEDIDO> _PEDIDOes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PRODUTO> PRODUTOes
        {
            get
            {
                if ((_PRODUTOes == null))
                {
                    _PRODUTOes = base.CreateObjectSet<PRODUTO>("PRODUTOes");
                }
                return _PRODUTOes;
            }
        }
        private ObjectSet<PRODUTO> _PRODUTOes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CLIENTEs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCLIENTEs(CLIENTE cLIENTE)
        {
            base.AddObject("CLIENTEs", cLIENTE);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ENDERECOes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToENDERECOes(ENDERECO eNDERECO)
        {
            base.AddObject("ENDERECOes", eNDERECO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PEDIDOes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPEDIDOes(PEDIDO pEDIDO)
        {
            base.AddObject("PEDIDOes", pEDIDO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PRODUTOes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPRODUTOes(PRODUTO pRODUTO)
        {
            base.AddObject("PRODUTOes", pRODUTO);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GRC.Model", Name="CLIENTE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CLIENTE : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CLIENTE object.
        /// </summary>
        /// <param name="cODIGO">Initial value of the CODIGO property.</param>
        /// <param name="nOME">Initial value of the NOME property.</param>
        /// <param name="cPF">Initial value of the CPF property.</param>
        /// <param name="tELEFONE">Initial value of the TELEFONE property.</param>
        /// <param name="cODIGO_ENDERECO">Initial value of the CODIGO_ENDERECO property.</param>
        public static CLIENTE CreateCLIENTE(global::System.Int32 cODIGO, global::System.String nOME, global::System.Int64 cPF, global::System.String tELEFONE, global::System.Int32 cODIGO_ENDERECO)
        {
            CLIENTE cLIENTE = new CLIENTE();
            cLIENTE.CODIGO = cODIGO;
            cLIENTE.NOME = nOME;
            cLIENTE.CPF = cPF;
            cLIENTE.TELEFONE = tELEFONE;
            cLIENTE.CODIGO_ENDERECO = cODIGO_ENDERECO;
            return cLIENTE;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO
        {
            get
            {
                return _CODIGO;
            }
            set
            {
                if (_CODIGO != value)
                {
                    OnCODIGOChanging(value);
                    ReportPropertyChanging("CODIGO");
                    _CODIGO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CODIGO");
                    OnCODIGOChanged();
                }
            }
        }
        private global::System.Int32 _CODIGO;
        partial void OnCODIGOChanging(global::System.Int32 value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NOME
        {
            get
            {
                return _NOME;
            }
            set
            {
                OnNOMEChanging(value);
                ReportPropertyChanging("NOME");
                _NOME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NOME");
                OnNOMEChanged();
            }
        }
        private global::System.String _NOME;
        partial void OnNOMEChanging(global::System.String value);
        partial void OnNOMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                OnCPFChanging(value);
                ReportPropertyChanging("CPF");
                _CPF = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CPF");
                OnCPFChanged();
            }
        }
        private global::System.Int64 _CPF;
        partial void OnCPFChanging(global::System.Int64 value);
        partial void OnCPFChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TELEFONE
        {
            get
            {
                return _TELEFONE;
            }
            set
            {
                OnTELEFONEChanging(value);
                ReportPropertyChanging("TELEFONE");
                _TELEFONE = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TELEFONE");
                OnTELEFONEChanged();
            }
        }
        private global::System.String _TELEFONE;
        partial void OnTELEFONEChanging(global::System.String value);
        partial void OnTELEFONEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO_ENDERECO
        {
            get
            {
                return _CODIGO_ENDERECO;
            }
            set
            {
                OnCODIGO_ENDERECOChanging(value);
                ReportPropertyChanging("CODIGO_ENDERECO");
                _CODIGO_ENDERECO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CODIGO_ENDERECO");
                OnCODIGO_ENDERECOChanged();
            }
        }
        private global::System.Int32 _CODIGO_ENDERECO;
        partial void OnCODIGO_ENDERECOChanging(global::System.Int32 value);
        partial void OnCODIGO_ENDERECOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EMAIL
        {
            get
            {
                return _EMAIL;
            }
            set
            {
                OnEMAILChanging(value);
                ReportPropertyChanging("EMAIL");
                _EMAIL = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EMAIL");
                OnEMAILChanged();
            }
        }
        private global::System.String _EMAIL;
        partial void OnEMAILChanging(global::System.String value);
        partial void OnEMAILChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "FK_CLIENTE_ENDERECO", "ENDERECO")]
        public ENDERECO ENDERECO
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ENDERECO>("GRC.Model.FK_CLIENTE_ENDERECO", "ENDERECO").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ENDERECO>("GRC.Model.FK_CLIENTE_ENDERECO", "ENDERECO").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ENDERECO> ENDERECOReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ENDERECO>("GRC.Model.FK_CLIENTE_ENDERECO", "ENDERECO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ENDERECO>("GRC.Model.FK_CLIENTE_ENDERECO", "ENDERECO", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "FK_PEDIDO_CLIENTE", "PEDIDO")]
        public EntityCollection<PEDIDO> PEDIDOes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PEDIDO>("GRC.Model.FK_PEDIDO_CLIENTE", "PEDIDO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PEDIDO>("GRC.Model.FK_PEDIDO_CLIENTE", "PEDIDO", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GRC.Model", Name="ENDERECO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ENDERECO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ENDERECO object.
        /// </summary>
        /// <param name="cODIGO">Initial value of the CODIGO property.</param>
        public static ENDERECO CreateENDERECO(global::System.Int32 cODIGO)
        {
            ENDERECO eNDERECO = new ENDERECO();
            eNDERECO.CODIGO = cODIGO;
            return eNDERECO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO
        {
            get
            {
                return _CODIGO;
            }
            set
            {
                if (_CODIGO != value)
                {
                    OnCODIGOChanging(value);
                    ReportPropertyChanging("CODIGO");
                    _CODIGO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CODIGO");
                    OnCODIGOChanged();
                }
            }
        }
        private global::System.Int32 _CODIGO;
        partial void OnCODIGOChanging(global::System.Int32 value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LOGRADOURO
        {
            get
            {
                return _LOGRADOURO;
            }
            set
            {
                OnLOGRADOUROChanging(value);
                ReportPropertyChanging("LOGRADOURO");
                _LOGRADOURO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LOGRADOURO");
                OnLOGRADOUROChanged();
            }
        }
        private global::System.String _LOGRADOURO;
        partial void OnLOGRADOUROChanging(global::System.String value);
        partial void OnLOGRADOUROChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> NUMERO
        {
            get
            {
                return _NUMERO;
            }
            set
            {
                OnNUMEROChanging(value);
                ReportPropertyChanging("NUMERO");
                _NUMERO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NUMERO");
                OnNUMEROChanged();
            }
        }
        private Nullable<global::System.Int32> _NUMERO;
        partial void OnNUMEROChanging(Nullable<global::System.Int32> value);
        partial void OnNUMEROChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BAIRRO
        {
            get
            {
                return _BAIRRO;
            }
            set
            {
                OnBAIRROChanging(value);
                ReportPropertyChanging("BAIRRO");
                _BAIRRO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("BAIRRO");
                OnBAIRROChanged();
            }
        }
        private global::System.String _BAIRRO;
        partial void OnBAIRROChanging(global::System.String value);
        partial void OnBAIRROChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CIDADE
        {
            get
            {
                return _CIDADE;
            }
            set
            {
                OnCIDADEChanging(value);
                ReportPropertyChanging("CIDADE");
                _CIDADE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CIDADE");
                OnCIDADEChanged();
            }
        }
        private global::System.String _CIDADE;
        partial void OnCIDADEChanging(global::System.String value);
        partial void OnCIDADEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ESTADO
        {
            get
            {
                return _ESTADO;
            }
            set
            {
                OnESTADOChanging(value);
                ReportPropertyChanging("ESTADO");
                _ESTADO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ESTADO");
                OnESTADOChanged();
            }
        }
        private global::System.String _ESTADO;
        partial void OnESTADOChanging(global::System.String value);
        partial void OnESTADOChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "FK_CLIENTE_ENDERECO", "CLIENTE")]
        public EntityCollection<CLIENTE> CLIENTEs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CLIENTE>("GRC.Model.FK_CLIENTE_ENDERECO", "CLIENTE");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CLIENTE>("GRC.Model.FK_CLIENTE_ENDERECO", "CLIENTE", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GRC.Model", Name="PEDIDO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PEDIDO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PEDIDO object.
        /// </summary>
        /// <param name="cODIGO">Initial value of the CODIGO property.</param>
        /// <param name="cODIGO_CLIENTE">Initial value of the CODIGO_CLIENTE property.</param>
        /// <param name="dATA">Initial value of the DATA property.</param>
        public static PEDIDO CreatePEDIDO(global::System.Int32 cODIGO, global::System.Int32 cODIGO_CLIENTE, global::System.DateTime dATA)
        {
            PEDIDO pEDIDO = new PEDIDO();
            pEDIDO.CODIGO = cODIGO;
            pEDIDO.CODIGO_CLIENTE = cODIGO_CLIENTE;
            pEDIDO.DATA = dATA;
            return pEDIDO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO
        {
            get
            {
                return _CODIGO;
            }
            set
            {
                if (_CODIGO != value)
                {
                    OnCODIGOChanging(value);
                    ReportPropertyChanging("CODIGO");
                    _CODIGO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CODIGO");
                    OnCODIGOChanged();
                }
            }
        }
        private global::System.Int32 _CODIGO;
        partial void OnCODIGOChanging(global::System.Int32 value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO_CLIENTE
        {
            get
            {
                return _CODIGO_CLIENTE;
            }
            set
            {
                OnCODIGO_CLIENTEChanging(value);
                ReportPropertyChanging("CODIGO_CLIENTE");
                _CODIGO_CLIENTE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CODIGO_CLIENTE");
                OnCODIGO_CLIENTEChanged();
            }
        }
        private global::System.Int32 _CODIGO_CLIENTE;
        partial void OnCODIGO_CLIENTEChanging(global::System.Int32 value);
        partial void OnCODIGO_CLIENTEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DATA
        {
            get
            {
                return _DATA;
            }
            set
            {
                OnDATAChanging(value);
                ReportPropertyChanging("DATA");
                _DATA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DATA");
                OnDATAChanged();
            }
        }
        private global::System.DateTime _DATA;
        partial void OnDATAChanging(global::System.DateTime value);
        partial void OnDATAChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "FK_PEDIDO_CLIENTE", "CLIENTE")]
        public CLIENTE CLIENTE
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CLIENTE>("GRC.Model.FK_PEDIDO_CLIENTE", "CLIENTE").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CLIENTE>("GRC.Model.FK_PEDIDO_CLIENTE", "CLIENTE").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CLIENTE> CLIENTEReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CLIENTE>("GRC.Model.FK_PEDIDO_CLIENTE", "CLIENTE");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CLIENTE>("GRC.Model.FK_PEDIDO_CLIENTE", "CLIENTE", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "PEDIDO_ITEM", "PRODUTO")]
        public EntityCollection<PRODUTO> PRODUTOes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PRODUTO>("GRC.Model.PEDIDO_ITEM", "PRODUTO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PRODUTO>("GRC.Model.PEDIDO_ITEM", "PRODUTO", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GRC.Model", Name="PRODUTO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PRODUTO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PRODUTO object.
        /// </summary>
        /// <param name="cODIGO">Initial value of the CODIGO property.</param>
        /// <param name="dESCRICAO">Initial value of the DESCRICAO property.</param>
        /// <param name="vALOR">Initial value of the VALOR property.</param>
        public static PRODUTO CreatePRODUTO(global::System.Int32 cODIGO, global::System.String dESCRICAO, global::System.Decimal vALOR)
        {
            PRODUTO pRODUTO = new PRODUTO();
            pRODUTO.CODIGO = cODIGO;
            pRODUTO.DESCRICAO = dESCRICAO;
            pRODUTO.VALOR = vALOR;
            return pRODUTO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CODIGO
        {
            get
            {
                return _CODIGO;
            }
            set
            {
                if (_CODIGO != value)
                {
                    OnCODIGOChanging(value);
                    ReportPropertyChanging("CODIGO");
                    _CODIGO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CODIGO");
                    OnCODIGOChanged();
                }
            }
        }
        private global::System.Int32 _CODIGO;
        partial void OnCODIGOChanging(global::System.Int32 value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DESCRICAO
        {
            get
            {
                return _DESCRICAO;
            }
            set
            {
                OnDESCRICAOChanging(value);
                ReportPropertyChanging("DESCRICAO");
                _DESCRICAO = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DESCRICAO");
                OnDESCRICAOChanged();
            }
        }
        private global::System.String _DESCRICAO;
        partial void OnDESCRICAOChanging(global::System.String value);
        partial void OnDESCRICAOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal VALOR
        {
            get
            {
                return _VALOR;
            }
            set
            {
                OnVALORChanging(value);
                ReportPropertyChanging("VALOR");
                _VALOR = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VALOR");
                OnVALORChanged();
            }
        }
        private global::System.Decimal _VALOR;
        partial void OnVALORChanging(global::System.Decimal value);
        partial void OnVALORChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GRC.Model", "PEDIDO_ITEM", "PEDIDO")]
        public EntityCollection<PEDIDO> PEDIDOes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PEDIDO>("GRC.Model.PEDIDO_ITEM", "PEDIDO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PEDIDO>("GRC.Model.PEDIDO_ITEM", "PEDIDO", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
