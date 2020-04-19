﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldWideImportersEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WideWorldImportersDWEntities : DbContext
    {
        public WideWorldImportersDWEntities()
            : base("name=WideWorldImportersDWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payment_Method> Payment_Methods { get; set; }
        public virtual DbSet<Stock_Item> Stock_Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Transaction_Type> Transaction_Types { get; set; }
        public virtual DbSet<Movement> Movements { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Stock_Holding> Stock_Holdings { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<City_Staging> City_Staging { get; set; }
        public virtual DbSet<Customer_Staging> Customer_Staging { get; set; }
        public virtual DbSet<Employee_Staging> Employee_Staging { get; set; }
        public virtual DbSet<ETL_Cutoff> ETL_Cutoffs { get; set; }
        public virtual DbSet<Lineage> Lineages { get; set; }
        public virtual DbSet<Movement_Staging> Movement_Staging { get; set; }
        public virtual DbSet<Order_Staging> Order_Staging { get; set; }
        public virtual DbSet<PaymentMethod_Staging> PaymentMethod_Staging { get; set; }
        public virtual DbSet<Purchase_Staging> Purchase_Staging { get; set; }
        public virtual DbSet<Sale_Staging> Sale_Staging { get; set; }
        public virtual DbSet<StockHolding_Staging> StockHolding_Staging { get; set; }
        public virtual DbSet<StockItem_Staging> StockItem_Staging { get; set; }
        public virtual DbSet<Supplier_Staging> Supplier_Staging { get; set; }
        public virtual DbSet<Transaction_Staging> Transaction_Staging { get; set; }
        public virtual DbSet<TransactionType_Staging> TransactionType_Staging { get; set; }
    
        [DbFunction("WideWorldImportersDWEntities", "GenerateDateDimensionColumns")]
        public virtual IQueryable<GenerateDateDimensionColumns_Result> GenerateDateDimensionColumns(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GenerateDateDimensionColumns_Result>("[WideWorldImportersDWEntities].[GenerateDateDimensionColumns](@Date)", dateParameter);
        }
    
        public virtual int Configuration_ApplyPartitionedColumnstoreIndexing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyPartitionedColumnstoreIndexing");
        }
    
        public virtual int Configuration_ApplyPolybase()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyPolybase");
        }
    
        public virtual int Configuration_ConfigureForEnterpriseEdition()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ConfigureForEnterpriseEdition");
        }
    
        public virtual int Configuration_EnableInMemory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_EnableInMemory");
        }
    
        public virtual int Configuration_PopulateLargeSaleTable(Nullable<long> estimatedRowsFor2012)
        {
            var estimatedRowsFor2012Parameter = estimatedRowsFor2012.HasValue ?
                new ObjectParameter("EstimatedRowsFor2012", estimatedRowsFor2012) :
                new ObjectParameter("EstimatedRowsFor2012", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_PopulateLargeSaleTable", estimatedRowsFor2012Parameter);
        }
    
        public virtual int Configuration_ReseedETL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ReseedETL");
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> GetLastETLCutoffTime(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("GetLastETLCutoffTime", tableNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetLineageKey(string tableName, Nullable<System.DateTime> newCutoffTime)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var newCutoffTimeParameter = newCutoffTime.HasValue ?
                new ObjectParameter("NewCutoffTime", newCutoffTime) :
                new ObjectParameter("NewCutoffTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetLineageKey", tableNameParameter, newCutoffTimeParameter);
        }
    
        public virtual int MigrateStagedCityData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedCityData");
        }
    
        public virtual int MigrateStagedCustomerData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedCustomerData");
        }
    
        public virtual int MigrateStagedEmployeeData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedEmployeeData");
        }
    
        public virtual int MigrateStagedMovementData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedMovementData");
        }
    
        public virtual int MigrateStagedOrderData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedOrderData");
        }
    
        public virtual int MigrateStagedPaymentMethodData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedPaymentMethodData");
        }
    
        public virtual int MigrateStagedPurchaseData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedPurchaseData");
        }
    
        public virtual int MigrateStagedSaleData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedSaleData");
        }
    
        public virtual int MigrateStagedStockHoldingData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedStockHoldingData");
        }
    
        public virtual int MigrateStagedStockItemData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedStockItemData");
        }
    
        public virtual int MigrateStagedSupplierData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedSupplierData");
        }
    
        public virtual int MigrateStagedTransactionData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedTransactionData");
        }
    
        public virtual int MigrateStagedTransactionTypeData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MigrateStagedTransactionTypeData");
        }
    
        public virtual int PopulateDateDimensionForYear(Nullable<int> yearNumber)
        {
            var yearNumberParameter = yearNumber.HasValue ?
                new ObjectParameter("YearNumber", yearNumber) :
                new ObjectParameter("YearNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PopulateDateDimensionForYear", yearNumberParameter);
        }
    
        public virtual int ReseedAllSequences()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReseedAllSequences");
        }
    
        public virtual int ReseedSequenceBeyondTableValues(string sequenceName, string schemaName, string tableName, string columnName)
        {
            var sequenceNameParameter = sequenceName != null ?
                new ObjectParameter("SequenceName", sequenceName) :
                new ObjectParameter("SequenceName", typeof(string));
    
            var schemaNameParameter = schemaName != null ?
                new ObjectParameter("SchemaName", schemaName) :
                new ObjectParameter("SchemaName", typeof(string));
    
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnNameParameter = columnName != null ?
                new ObjectParameter("ColumnName", columnName) :
                new ObjectParameter("ColumnName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReseedSequenceBeyondTableValues", sequenceNameParameter, schemaNameParameter, tableNameParameter, columnNameParameter);
        }
    }
}
