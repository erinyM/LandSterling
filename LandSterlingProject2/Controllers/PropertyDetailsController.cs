using LandSterlingProject2.Helpers;
using LandSterlingProject2.Models;
using LandSterlingProject2.Models.models_ado;
using LandSterlingProject2.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandSterlingProject2.Controllers
{
    public class PropertyDetailsController : Controller
    {
        // GET: PropertyDetails
        public ActionResult Index(string Id = "")
        {
            if (!ValidLicense())
            {
                return View("UpdateRequired");
            }
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.Parameters.AddWithValue("@RecordId", Id);
            
                DBT.CMD.CommandText = @" select '' PostHandover,u.Record_Id,u.Remarks as Description,u.Property_Name+', Ref# '+u.Ref_No as Name,U.Floor,pm.Record_Id AS property_record_Id,
                                         Replace(Replace((select top 1 Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath1, 
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 1 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath2, 
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 2 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath3,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 3 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath4,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 4 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath5,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 5 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath6,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 6 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath7,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 7 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath8,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 8 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath9,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 9 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath10,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 10 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath11,
                                         Replace(Replace((select Url from tbUnit_Image  ui where ui.Ref_No=u.Ref_No order by Record_Id asc OFFSET 11 Rows FETCH  Next 1 Rows ONLY),'\','/'),'C:/inetpub/wwwroot/CRM/','https://crm.landsterling.belsio.io/') ImagePath12,                                  
                                         pm.Longitude,pm.Latitude,u.Adv_Remarks2 VideoUrl,Replace(Replace(U.Unit_Class,'Rent','For Rent'),'Buy','For Sale') as Type,pm.City+', '+pm.Community_No as Location,pm.Community_No as Address,U.Created_On,pm.Developer,
                                         replace(u.Total_Value,'.00','') as Price,replace(u.Total_Value,'.00','') as PriceTo,REPLACE(u.Total_Area,'.00','') as Size,REPLACE(u.Total_Area,'.00','') as SizeTo,u.Exp1 as MarketingText,u.Adv_Remarks1 as Image360,u.Bedrooms as Rooms,u.Floor,
                                         (SELECT STRING_AGG (uf.Description, '$&#') AS Description FROM tbUnit_Feature uf where uf.Ref_No=u.Ref_No) as Features,
                                         (SELECT STRING_AGG (pf.Description, '$&#') AS Description FROM tbProperty_Feature pf where pf.Property_No=u.Property_No) as Features2,
                                          pm.Exp6 CompletionDate
                                          from tbUnit_Master u,tbProperty_Master pm where pm.Property_No=u.Property_No and u.Record_Id=@RecordId ;";
           
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            if (DBT.TBL.Rows.Count > 0)
            {

                Property obj = new Property();
              
                    string recId = DBT.TBL.Rows[0]["property_record_Id"].ToString();

                    if (DBT.TBL.Rows[0]["ImagePath1"].ToString() == "")
                    {
                        obj = GetImages(recId);
                    }
                    else
                    {

                        obj.ImagePath1 = DBT.TBL.Rows[0]["ImagePath1"].ToString();
                        obj.ImagePath2 = DBT.TBL.Rows[0]["ImagePath2"].ToString();
                        obj.ImagePath3 = DBT.TBL.Rows[0]["ImagePath3"].ToString();
                        obj.ImagePath4 = DBT.TBL.Rows[0]["ImagePath4"].ToString();
                        obj.ImagePath5 = DBT.TBL.Rows[0]["ImagePath5"].ToString();
                        obj.ImagePath6 = DBT.TBL.Rows[0]["ImagePath6"].ToString();
                        obj.ImagePath7 = DBT.TBL.Rows[0]["ImagePath7"].ToString();
                        obj.ImagePath8 = DBT.TBL.Rows[0]["ImagePath8"].ToString();
                        obj.ImagePath9 = DBT.TBL.Rows[0]["ImagePath9"].ToString();
                        obj.ImagePath10 = DBT.TBL.Rows[0]["ImagePath10"].ToString();
                        obj.ImagePath11 = DBT.TBL.Rows[0]["ImagePath11"].ToString();
                        obj.ImagePath12 = DBT.TBL.Rows[0]["ImagePath12"].ToString();
                    }
                   


                


                Property property = new Property
                {
                    Address = DBT.TBL.Rows[0]["Address"].ToString(),
                    CreatedOn = Convert.ToDateTime(DBT.TBL.Rows[0]["Created_On"]).ToString("dd/MMM/yyyy", new CultureInfo("en-US")),
                    Developer = DBT.TBL.Rows[0]["Developer"].ToString() == "0" ? "" : DBT.TBL.Rows[0]["Developer"].ToString(),
                    Floor = DBT.TBL.Rows[0]["Floor"].ToString(),
                    Location = DBT.TBL.Rows[0]["Location"].ToString(),
                    Price = DBT.TBL.Rows[0]["Price"].ToString().KiloFormat(),
                    Rooms = DBT.TBL.Rows[0]["Rooms"].ToString(),
                    Size = DBT.TBL.Rows[0]["Size"].ToString(),
                    SizeTo = DBT.TBL.Rows[0]["SizeTo"].ToString(),
                    PriceTo = DBT.TBL.Rows[0]["PriceTo"].ToString().KiloFormat(),
                    Image360 = DBT.TBL.Rows[0]["Image360"].ToString(),
                    MarketingText = DBT.TBL.Rows[0]["MarketingText"].ToString(),
                    PostHandover = DBT.TBL.Rows[0]["PostHandover"].ToString(),
                    Type = DBT.TBL.Rows[0]["Type"].ToString(),
                    Name = DBT.TBL.Rows[0]["Name"].ToString(),
                    RecordId = DBT.TBL.Rows[0]["Record_Id"].ToString(),
                    Description = DBT.TBL.Rows[0]["Description"].ToString(),
                    Features = DBT.TBL.Rows[0]["Features"].ToString(),
                    ImagePath1 = obj.ImagePath1 == null ? DBT.TBL.Rows[0]["ImagePath1"].ToString() : obj.ImagePath1,
                    ImagePath2 = obj.ImagePath2 == null ? DBT.TBL.Rows[0]["ImagePath2"].ToString() : obj.ImagePath2,
                    ImagePath3 = obj.ImagePath3 == null ? DBT.TBL.Rows[0]["ImagePath3"].ToString() : obj.ImagePath3,
                    ImagePath4 = obj.ImagePath4 == null ? DBT.TBL.Rows[0]["ImagePath4"].ToString() : obj.ImagePath4,
                    ImagePath5 = obj.ImagePath5 == null ? DBT.TBL.Rows[0]["ImagePath5"].ToString() : obj.ImagePath5,
                    ImagePath6 = obj.ImagePath6 == null ? DBT.TBL.Rows[0]["ImagePath6"].ToString() : obj.ImagePath6,
                    ImagePath7 = obj.ImagePath7 == null ? DBT.TBL.Rows[0]["ImagePath7"].ToString() : obj.ImagePath7,
                    ImagePath8 = obj.ImagePath8 == null ? DBT.TBL.Rows[0]["ImagePath8"].ToString() : obj.ImagePath8,
                    ImagePath9 = obj.ImagePath9 == null ? DBT.TBL.Rows[0]["ImagePath9"].ToString() : obj.ImagePath9,
                    ImagePath10 = obj.ImagePath10 == null ? DBT.TBL.Rows[0]["ImagePath10"].ToString() : obj.ImagePath10,
                    ImagePath11 = obj.ImagePath11 == null ? DBT.TBL.Rows[0]["ImagePath11"].ToString() : obj.ImagePath11,
                    ImagePath12 = obj.ImagePath12 == null ? DBT.TBL.Rows[0]["ImagePath12"].ToString() : obj.ImagePath12,

                    Latitude = DBT.TBL.Rows[0]["Latitude"].ToString(),
                    Longitude = DBT.TBL.Rows[0]["Longitude"].ToString(),
                  
                    CompletionDate = DBT.TBL.Rows[0]["CompletionDate"].ToString()
                };
                ViewBag.Property = property;

                List<string> Features = new List<string>();
                Features.AddRange(property.Features.Split(new string[] { "$&#" }, StringSplitOptions.None));
                ViewBag.ProjectNameList = LoadProjects();
                ViewBag.Rooms = LoadBedrooms();
                ViewBag.Cities = LoadCities();
                ViewBag.Developers = LoadDevelopers();
                Feature[] features = LoadFeatures();
                ViewBag.Features = Features.Distinct().ToArray();
            }


            
            return View();
        }
        private City[] LoadCities()
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.CommandText = "select City_Desc Name,Record_Id RecordId from eCountryCity_Master where Country_Desc = 'United Arab Emirates' order by City_Desc";
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            City[] cities = new City[DBT.TBL.Rows.Count];
            if (DBT.TBL.Rows.Count > 0)
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    cities[i] = new City
                    {
                        Name = DBT.TBL.Rows[i]["Name"].ToString(),
                        RecordId = DBT.TBL.Rows[i]["RecordId"].ToString(),
                    };
                }
            }
            return cities;
        }
        private City[] LoadProjects()
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.CommandText = "select Record_Id,Description from tbProperty_Master where Exp4='Yes' order by Description asc";
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            City[] cities = new City[DBT.TBL.Rows.Count];
            if (DBT.TBL.Rows.Count > 0)
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    cities[i] = new City
                    {
                        Name = DBT.TBL.Rows[i]["Description"].ToString(),
                        RecordId = DBT.TBL.Rows[i]["Record_Id"].ToString(),
                    };
                }
            }
            return cities;
        }
        private City[] LoadBedrooms()
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.CommandText = "select * from eBedroom_Master order by Bedrooms desc;";
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            City[] cities = new City[DBT.TBL.Rows.Count];
            if (DBT.TBL.Rows.Count > 0)
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    cities[i] = new City
                    {
                        Name = DBT.TBL.Rows[i]["Bedrooms"].ToString(),
                        RecordId = DBT.TBL.Rows[i]["Record_Id"].ToString(),
                    };
                }
            }
            return cities;
        }
        private City[] LoadDevelopers()
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.CommandText = "select * from Developer order by Name asc;";
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            City[] cities = new City[DBT.TBL.Rows.Count];
            if (DBT.TBL.Rows.Count > 0)
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    cities[i] = new City
                    {
                        Name = DBT.TBL.Rows[i]["Name"].ToString(),
                        RecordId = DBT.TBL.Rows[i]["RecordId"].ToString(),
                    };
                }
            }
            return cities;
        }
        private Feature[] LoadFeatures()
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT.CMD.CommandText = "select Description Name,Record_Id RecordId from tbUnitFeatures_Master order by Description asc";
            DBT.TBL.Load(DBT.CMD.ExecuteReader());
            Feature[] features = new Feature[DBT.TBL.Rows.Count];
            if (DBT.TBL.Rows.Count > 0)
            {
                for (int i = 0; i < features.Length; i++)
                {
                    features[i] = new Feature
                    {
                        Name = DBT.TBL.Rows[i]["Name"].ToString(),
                        RecordId = DBT.TBL.Rows[i]["RecordId"].ToString(),
                    };
                }
            }
            return features;
        }
        public Property GetImages(string Id)
    {
        DataBaseTools DBT = new DataBaseTools();
        Property property = new Property();
        DBT.CMD.Parameters.AddWithValue("@Record_Id", Id);
        DBT.CMD.CommandText = $@"select  Replace(Replace((select top 1 Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath1,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id  asc OFFSET 1 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath2,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 2 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath3,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 3 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath4,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 4 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath5,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 5 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath6,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 6 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath7,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 7 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath8,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 8 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath9,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 9 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath10,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 10 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath11,
                                        Replace(Replace((select Url from tbProperty_Image  pi where pi.Ref_No=pm.Property_No order by Record_Id asc OFFSET 11 Rows FETCH  Next 1 Rows ONLY),'\','/'),'" + Settings.Default.FolderPath + @"','" + Settings.Default.CRMLink + @"') ImagePath12
                                        from tbProperty_Master pm where pm.Record_Id=@Record_Id ;";
        DBT.TBL.Load(DBT.CMD.ExecuteReader());
            List<string> imgs = new List<string>();
        if (DBT.TBL.Rows.Count > 0)
        {

            property.ImagePath1 = DBT.TBL.Rows[0]["ImagePath1"].ToString();
            property.ImagePath2 = DBT.TBL.Rows[0]["ImagePath2"].ToString();
            property.ImagePath3 = DBT.TBL.Rows[0]["ImagePath3"].ToString();
            property.ImagePath4 = DBT.TBL.Rows[0]["ImagePath4"].ToString();
            property.ImagePath5 = DBT.TBL.Rows[0]["ImagePath5"].ToString();
            property.ImagePath6 = DBT.TBL.Rows[0]["ImagePath6"].ToString();
            property.ImagePath7 = DBT.TBL.Rows[0]["ImagePath7"].ToString();
            property.ImagePath8 = DBT.TBL.Rows[0]["ImagePath8"].ToString();
            property.ImagePath9 = DBT.TBL.Rows[0]["ImagePath9"].ToString();
            property.ImagePath10 = DBT.TBL.Rows[0]["ImagePath10"].ToString();
            property.ImagePath11 = DBT.TBL.Rows[0]["ImagePath11"].ToString();
            property.ImagePath12 = DBT.TBL.Rows[0]["ImagePath12"].ToString();
        };
        return property;

    }
        private bool ValidLicense()
        {
            return true;
        }
        public ActionResult SendEmail(Emailmodel emailmodel )
        {
            DataBaseTools DBT = new DataBaseTools();
            DBT = new DataBaseTools();
            DBT.CMD.CommandText = "msdb.dbo.sp_send_dbmail @profile_name='SendPaymentValueEmail',@recipients='"+emailmodel.Email+ "',@subject='ePMS FM',@body='the mothely payment"+ emailmodel.MonthlyPayment+" and total invest value "+emailmodel.InvestmentValue+"';--,@body_format ='HTML';";
            
            DBT.CMD.ExecuteReader();
            return View();
        }
        public ActionResult ContactUs(ContactUs contact)
        {
            try
            {

                
                ViewBag.IsSent = false;
                DataBaseTools DBT = new DataBaseTools();
                DBT.CMD.Parameters.AddWithValue("@FullName", contact.FullName);
                DBT.CMD.Parameters.AddWithValue("@Email", contact.Email);
                DBT.CMD.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber != null ? contact.PhoneNumber : "");
                DBT.CMD.Parameters.AddWithValue("@Message", string.IsNullOrEmpty(contact.Message) ? "" : contact.Message);
              
                DBT.CMD.CommandText = "insert into eCC_ClientLeads(FullName,Email,PhoneNumber,Exp1) values(@FullName,@Email,@PhoneNumber,@Message)";
                DBT.CMD.ExecuteNonQuery();
                ViewBag.IsSent = true;
                ModelState.Clear();
            }
            catch (Exception ex)
            {
                ViewBag.IsSent = false;
            }
          
            return View("index");
        }
    }
}
