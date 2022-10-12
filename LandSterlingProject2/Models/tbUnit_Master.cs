//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandSterlingProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUnit_Master
    {
        public long Record_Id { get; set; }
        public string Property_No { get; set; }
        public string Property_Name { get; set; }
        public string Unit_No { get; set; }
        public string Ref_No { get; set; }
        public Nullable<long> Unit_Sr_No { get; set; }
        public string RERA_STR_No { get; set; }
        public string Street_No { get; set; }
        public string Street_Name { get; set; }
        public string Unit_Option { get; set; }
        public string Category_Mix { get; set; }
        public string Permitted_Use { get; set; }
        public string Unit_Type { get; set; }
        public string Unit_Category { get; set; }
        public string Unit_Style { get; set; }
        public string Unit_Model { get; set; }
        public string Unit_Zone { get; set; }
        public string BuildingName { get; set; }
        public string Plot_No { get; set; }
        public string Plot_Size { get; set; }
        public string Block { get; set; }
        public string Floor { get; set; }
        public string Unit_View { get; set; }
        public Nullable<decimal> CurrentMarketRate { get; set; }
        public string Completion_Date { get; set; }
        public string Unit_Class { get; set; }
        public string LivingRooms { get; set; }
        public string Bedrooms { get; set; }
        public string StoreRooms { get; set; }
        public string Parking { get; set; }
        public string Facilities { get; set; }
        public string Status { get; set; }
        public string Payment_Plan { get; set; }
        public string Broker_Id { get; set; }
        public string Broker_Name { get; set; }
        public string Seller_Id { get; set; }
        public string Seller_Name { get; set; }
        public Nullable<long> RequirementId { get; set; }
        public Nullable<bool> Adv_Listing { get; set; }
        public Nullable<bool> Adv_NewsPaper { get; set; }
        public Nullable<bool> Adv_Web { get; set; }
        public Nullable<bool> Adv_OpenHouse { get; set; }
        public Nullable<bool> Adv1 { get; set; }
        public Nullable<bool> Adv2 { get; set; }
        public Nullable<bool> Adv3 { get; set; }
        public string Adv_Remarks1 { get; set; }
        public string Adv_Remarks2 { get; set; }
        public string Adv_Remarks3 { get; set; }
        public string Remarks { get; set; }
        public string InternalRemarks { get; set; }
        public string OtherSpace1 { get; set; }
        public string OtherSpace2 { get; set; }
        public string Bathrooms { get; set; }
        public string Kitchen { get; set; }
        public string Balcony { get; set; }
        public string Terrace { get; set; }
        public Nullable<decimal> Total_Area { get; set; }
        public Nullable<decimal> Measured_Area { get; set; }
        public Nullable<decimal> Sqft_Rate { get; set; }
        public Nullable<decimal> Purchase_Value { get; set; }
        public Nullable<decimal> Total_Value { get; set; }
        public Nullable<decimal> Measured_Value { get; set; }
        public Nullable<decimal> RoundOff_Value { get; set; }
        public Nullable<decimal> Parking_Price { get; set; }
        public Nullable<decimal> All_In_Price { get; set; }
        public Nullable<decimal> Premium { get; set; }
        public Nullable<decimal> Premium_Percent { get; set; }
        public Nullable<decimal> Seller_Commission { get; set; }
        public Nullable<decimal> Seller_Commission_Percent { get; set; }
        public Nullable<decimal> Buyer_Commission { get; set; }
        public Nullable<decimal> Buyer_Commission_Percent { get; set; }
        public Nullable<decimal> Seller_TransferFee { get; set; }
        public Nullable<decimal> Seller_TransferFee_Percent { get; set; }
        public Nullable<decimal> Buyer_TransferFee { get; set; }
        public Nullable<decimal> Buyer_TransferFee_Percent { get; set; }
        public Nullable<decimal> Admin_Fees { get; set; }
        public Nullable<decimal> Admin_Fees_Percent { get; set; }
        public Nullable<decimal> Other_Fees { get; set; }
        public Nullable<decimal> Other_Fees_Percent { get; set; }
        public string Other_Fees_Remarks { get; set; }
        public Nullable<decimal> Seller_Paid { get; set; }
        public Nullable<decimal> Seller_Paid_Percent { get; set; }
        public Nullable<decimal> Developer_Due { get; set; }
        public Nullable<decimal> Developer_Due_Percent { get; set; }
        public Nullable<decimal> Rent_Per_Annum { get; set; }
        public Nullable<decimal> Short_Term_Rent { get; set; }
        public string Short_Term_Period { get; set; }
        public Nullable<decimal> Rent_Per_Day { get; set; }
        public Nullable<decimal> Security_Deposit { get; set; }
        public Nullable<decimal> Advance_Deposit { get; set; }
        public Nullable<decimal> Tenant_Commission { get; set; }
        public Nullable<decimal> Landlord_Commission { get; set; }
        public Nullable<decimal> Maintenance_Fee { get; set; }
        public Nullable<decimal> ReferralCommission { get; set; }
        public Nullable<decimal> All_In_Rent { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<decimal> VAT_Percent { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> Tax_Percent { get; set; }
        public Nullable<int> Tax_Code { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Discount_Percent { get; set; }
        public Nullable<bool> Negotiable { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> CMA_Range1 { get; set; }
        public Nullable<decimal> CMA_Range2 { get; set; }
        public Nullable<int> Installments { get; set; }
        public string RentPayableTo { get; set; }
        public string RentBankName { get; set; }
        public string RentBankAcNo { get; set; }
        public string SecDepPayableTo { get; set; }
        public string SecDepBankName { get; set; }
        public string SecDepBankAcNo { get; set; }
        public string ComPayableTo { get; set; }
        public string ComBankName { get; set; }
        public string ComBankAcNo { get; set; }
        public string Key_Status { get; set; }
        public Nullable<int> NoofKeys { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string PublishStatus { get; set; }
        public string ServiceCharge { get; set; }
        public Nullable<bool> OwnerOccupied { get; set; }
        public Nullable<bool> Leased { get; set; }
        public Nullable<decimal> LeaseAmount { get; set; }
        public Nullable<System.DateTime> LeaseExpiry { get; set; }
        public string Mandate { get; set; }
        public Nullable<bool> FinanceOffered { get; set; }
        public string FinanceCompany { get; set; }
        public Nullable<bool> Mortgaged { get; set; }
        public string MortgageCompany { get; set; }
        public Nullable<bool> PropertyRegistered { get; set; }
        public Nullable<System.DateTime> RegisteredDate { get; set; }
        public Nullable<bool> ForSale { get; set; }
        public Nullable<System.DateTime> Adv_Listing_Date { get; set; }
        public Nullable<System.DateTime> Adv_NewsPaper_Date { get; set; }
        public Nullable<System.DateTime> Adv_Web_Date { get; set; }
        public Nullable<System.DateTime> Adv_OpenHouse_Date { get; set; }
        public Nullable<System.DateTime> Adv1_Date { get; set; }
        public Nullable<System.DateTime> Adv2_Date { get; set; }
        public Nullable<System.DateTime> Adv3_Date { get; set; }
        public string Portfolio { get; set; }
        public string PortfolioManager { get; set; }
        public string PropertyAdministrator { get; set; }
        public Nullable<bool> CanView { get; set; }
        public Nullable<bool> Upcoming { get; set; }
        public string PropertyType { get; set; }
        public string ReferredTo { get; set; }
        public Nullable<System.DateTime> ReferredOn { get; set; }
        public Nullable<System.DateTime> UnpublishedDate { get; set; }
        public string Factor { get; set; }
        public string Common { get; set; }
        public string CP { get; set; }
        public string GSA { get; set; }
        public string NSA { get; set; }
        public string Effeciency { get; set; }
        public Nullable<decimal> TotalValueUSD { get; set; }
        public Nullable<decimal> ListingPriceUSD { get; set; }
        public Nullable<decimal> AllInPriceUSD { get; set; }
        public Nullable<decimal> RentPerAnnumUSD { get; set; }
        public Nullable<decimal> AllInRentUSD { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public Nullable<decimal> Repayment { get; set; }
        public Nullable<decimal> MonthlyIncome { get; set; }
        public Nullable<decimal> AnnualIncome { get; set; }
        public string EURights { get; set; }
        public Nullable<decimal> EURightsAmount { get; set; }
        public string USP { get; set; }
        public string Exp1 { get; set; }
        public string Exp2 { get; set; }
        public string Exp3 { get; set; }
        public string Exp4 { get; set; }
        public string Exp5 { get; set; }
        public string Exp6 { get; set; }
        public string Exp7 { get; set; }
        public string Exp8 { get; set; }
        public string Exp9 { get; set; }
        public string Exp10 { get; set; }
        public string TempId { get; set; }
        public string Refered_By { get; set; }
        public Nullable<System.DateTime> Refered_On { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
    }
}
