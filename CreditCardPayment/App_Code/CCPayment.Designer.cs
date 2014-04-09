﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 3/16/2014 6:29:19 PM
namespace CreditCardPaymentModel
{
    
    /// <summary>
    /// There are no comments for CreditCardPaymentModel.CardDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// card_num
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CreditCardPaymentModel", Name="CardDetail")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class CardDetail : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new CardDetail object.
        /// </summary>
        /// <param name="card_num">Initial value of card_num.</param>
        /// <param name="balance">Initial value of balance.</param>
        /// <param name="cvv">Initial value of cvv.</param>
        /// <param name="expiration_dt">Initial value of expiration_dt.</param>
        /// <param name="card_name">Initial value of card_name.</param>
        /// <param name="card_type">Initial value of card_type.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static CardDetail CreateCardDetail(string card_num, decimal balance, int cvv, global::System.DateTime expiration_dt, string card_name, string card_type)
        {
            CardDetail cardDetail = new CardDetail();
            cardDetail.card_num = card_num;
            cardDetail.balance = balance;
            cardDetail.cvv = cvv;
            cardDetail.expiration_dt = expiration_dt;
            cardDetail.card_name = card_name;
            cardDetail.card_type = card_type;
            return cardDetail;
        }
        /// <summary>
        /// There are no comments for property card_num in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string card_num
        {
            get
            {
                return this._card_num;
            }
            set
            {
                this.Oncard_numChanging(value);
                this.ReportPropertyChanging("card_num");
                this._card_num = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("card_num");
                this.Oncard_numChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _card_num;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_numChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_numChanged();
        /// <summary>
        /// There are no comments for property balance in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this.OnbalanceChanging(value);
                this.ReportPropertyChanging("balance");
                this._balance = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("balance");
                this.OnbalanceChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private decimal _balance;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnbalanceChanging(decimal value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnbalanceChanged();
        /// <summary>
        /// There are no comments for property cvv in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int cvv
        {
            get
            {
                return this._cvv;
            }
            set
            {
                this.OncvvChanging(value);
                this.ReportPropertyChanging("cvv");
                this._cvv = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("cvv");
                this.OncvvChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _cvv;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncvvChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncvvChanged();
        /// <summary>
        /// There are no comments for property expiration_dt in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime expiration_dt
        {
            get
            {
                return this._expiration_dt;
            }
            set
            {
                this.Onexpiration_dtChanging(value);
                this.ReportPropertyChanging("expiration_dt");
                this._expiration_dt = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("expiration_dt");
                this.Onexpiration_dtChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _expiration_dt;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onexpiration_dtChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onexpiration_dtChanged();
        /// <summary>
        /// There are no comments for property card_name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string card_name
        {
            get
            {
                return this._card_name;
            }
            set
            {
                this.Oncard_nameChanging(value);
                this.ReportPropertyChanging("card_name");
                this._card_name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("card_name");
                this.Oncard_nameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _card_name;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_nameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_nameChanged();
        /// <summary>
        /// There are no comments for property addrress1 in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string addrress1
        {
            get
            {
                return this._addrress1;
            }
            set
            {
                this.Onaddrress1Changing(value);
                this.ReportPropertyChanging("addrress1");
                this._addrress1 = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("addrress1");
                this.Onaddrress1Changed();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _addrress1;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onaddrress1Changing(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onaddrress1Changed();
        /// <summary>
        /// There are no comments for property addrress2 in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string addrress2
        {
            get
            {
                return this._addrress2;
            }
            set
            {
                this.Onaddrress2Changing(value);
                this.ReportPropertyChanging("addrress2");
                this._addrress2 = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("addrress2");
                this.Onaddrress2Changed();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _addrress2;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onaddrress2Changing(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onaddrress2Changed();
        /// <summary>
        /// There are no comments for property email in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this.OnemailChanging(value);
                this.ReportPropertyChanging("email");
                this._email = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("email");
                this.OnemailChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _email;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnemailChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnemailChanged();
        /// <summary>
        /// There are no comments for property country in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string country
        {
            get
            {
                return this._country;
            }
            set
            {
                this.OncountryChanging(value);
                this.ReportPropertyChanging("country");
                this._country = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("country");
                this.OncountryChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _country;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncountryChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncountryChanged();
        /// <summary>
        /// There are no comments for property card_type in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string card_type
        {
            get
            {
                return this._card_type;
            }
            set
            {
                this.Oncard_typeChanging(value);
                this.ReportPropertyChanging("card_type");
                this._card_type = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("card_type");
                this.Oncard_typeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _card_type;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_typeChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_typeChanged();
    }
    /// <summary>
    /// There are no comments for CreditCardPaymentModel.Tran in the schema.
    /// </summary>
    /// <KeyProperties>
    /// trans_num
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CreditCardPaymentModel", Name="Tran")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Tran : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Tran object.
        /// </summary>
        /// <param name="trans_num">Initial value of trans_num.</param>
        /// <param name="trans_amt">Initial value of trans_amt.</param>
        /// <param name="trans_dt">Initial value of trans_dt.</param>
        /// <param name="card_num">Initial value of card_num.</param>
        /// <param name="email_message">Initial value of email_message.</param>
        /// <param name="acc_num">Initial value of acc_num.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Tran CreateTran(int trans_num, int trans_amt, global::System.DateTime trans_dt, string card_num, string email_message, int acc_num)
        {
            Tran tran = new Tran();
            tran.trans_num = trans_num;
            tran.trans_amt = trans_amt;
            tran.trans_dt = trans_dt;
            tran.card_num = card_num;
            tran.email_message = email_message;
            tran.acc_num = acc_num;
            return tran;
        }
        /// <summary>
        /// There are no comments for property trans_num in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int trans_num
        {
            get
            {
                return this._trans_num;
            }
            set
            {
                this.Ontrans_numChanging(value);
                this.ReportPropertyChanging("trans_num");
                this._trans_num = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("trans_num");
                this.Ontrans_numChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _trans_num;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_numChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_numChanged();
        /// <summary>
        /// There are no comments for property trans_amt in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int trans_amt
        {
            get
            {
                return this._trans_amt;
            }
            set
            {
                this.Ontrans_amtChanging(value);
                this.ReportPropertyChanging("trans_amt");
                this._trans_amt = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("trans_amt");
                this.Ontrans_amtChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _trans_amt;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_amtChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_amtChanged();
        /// <summary>
        /// There are no comments for property trans_dt in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime trans_dt
        {
            get
            {
                return this._trans_dt;
            }
            set
            {
                this.Ontrans_dtChanging(value);
                this.ReportPropertyChanging("trans_dt");
                this._trans_dt = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("trans_dt");
                this.Ontrans_dtChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _trans_dt;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_dtChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontrans_dtChanged();
        /// <summary>
        /// There are no comments for property card_num in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string card_num
        {
            get
            {
                return this._card_num;
            }
            set
            {
                this.Oncard_numChanging(value);
                this.ReportPropertyChanging("card_num");
                this._card_num = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("card_num");
                this.Oncard_numChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _card_num;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_numChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Oncard_numChanged();
        /// <summary>
        /// There are no comments for property email_message in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string email_message
        {
            get
            {
                return this._email_message;
            }
            set
            {
                this.Onemail_messageChanging(value);
                this.ReportPropertyChanging("email_message");
                this._email_message = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("email_message");
                this.Onemail_messageChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _email_message;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onemail_messageChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onemail_messageChanged();
        /// <summary>
        /// There are no comments for property acc_num in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int acc_num
        {
            get
            {
                return this._acc_num;
            }
            set
            {
                this.Onacc_numChanging(value);
                this.ReportPropertyChanging("acc_num");
                this._acc_num = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("acc_num");
                this.Onacc_numChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _acc_num;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onacc_numChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onacc_numChanged();
    }
    /// <summary>
    /// There are no comments for CreditCardPaymentEntities in the schema.
    /// </summary>
    public partial class CreditCardPaymentEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new CreditCardPaymentEntities object using the connection string found in the 'CreditCardPaymentEntities' section of the application configuration file.
        /// </summary>
        public CreditCardPaymentEntities() : 
                base("name=CreditCardPaymentEntities", "CreditCardPaymentEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CreditCardPaymentEntities object.
        /// </summary>
        public CreditCardPaymentEntities(string connectionString) : 
                base(connectionString, "CreditCardPaymentEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CreditCardPaymentEntities object.
        /// </summary>
        public CreditCardPaymentEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "CreditCardPaymentEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for CardDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<CardDetail> CardDetails
        {
            get
            {
                if ((this._CardDetails == null))
                {
                    this._CardDetails = base.CreateQuery<CardDetail>("[CardDetails]");
                }
                return this._CardDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<CardDetail> _CardDetails;
        /// <summary>
        /// There are no comments for Trans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Tran> Trans
        {
            get
            {
                if ((this._Trans == null))
                {
                    this._Trans = base.CreateQuery<Tran>("[Trans]");
                }
                return this._Trans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Tran> _Trans;
        /// <summary>
        /// There are no comments for CardDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToCardDetails(CardDetail cardDetail)
        {
            base.AddObject("CardDetails", cardDetail);
        }
        /// <summary>
        /// There are no comments for Trans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToTrans(Tran tran)
        {
            base.AddObject("Trans", tran);
        }
    }
}
