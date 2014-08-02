using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity;
namespace CATS_Interview.Model
{
    public class DatabaseContextInitialiser:DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {   
            //Populate business description lookup table
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PainterAndDecorators, BusinessDescriptionOptionText = "Painter And Decorators" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Florists, BusinessDescriptionOptionText = "Florists" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Builders, BusinessDescriptionOptionText = "Builders" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Landscapers, BusinessDescriptionOptionText = "Landscapers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Electricians, BusinessDescriptionOptionText = "Electricians" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.DeliveryAndCollection, BusinessDescriptionOptionText = "Delivery And Collection" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.HotelsAndInns, BusinessDescriptionOptionText = "Hotels And Inns" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PrintersAndLithographers, BusinessDescriptionOptionText = "Printers And Lithographers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Butchers, BusinessDescriptionOptionText = "Butchers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.OffLicences, BusinessDescriptionOptionText = "Off Licences" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Pharmacies, BusinessDescriptionOptionText = "Pharmacies" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.CourierServices, BusinessDescriptionOptionText = "Courier Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.AutomotiveServices, BusinessDescriptionOptionText = "Automotive Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Glaziers, BusinessDescriptionOptionText = "Glaziers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Caterers, BusinessDescriptionOptionText = "Caterers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Dairies, BusinessDescriptionOptionText = "Dairies" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Fishmongers, BusinessDescriptionOptionText = "Fishmongers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Fridge, BusinessDescriptionOptionText = "Fridge" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Plumbers, BusinessDescriptionOptionText = "Plumbers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown, BusinessDescriptionOptionText = "Unknown" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Abattoirs, BusinessDescriptionOptionText = "Abattoirs" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.AgriculturalContractors, BusinessDescriptionOptionText = "Agricultural Contractors" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.AntiqueDealer, BusinessDescriptionOptionText = "Antique Dealer" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.SecuritySystems, BusinessDescriptionOptionText = "Security Systems" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.CleaningServices, BusinessDescriptionOptionText = "Cleaning Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.GardenCentres, BusinessDescriptionOptionText = "Garden Centres" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.KitchenInstallation, BusinessDescriptionOptionText = "Kitchen Installation" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PropertyManagement, BusinessDescriptionOptionText = "Property Management" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.SecurityServices, BusinessDescriptionOptionText = "Security Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.FencingServices, BusinessDescriptionOptionText = "Fencing Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PlantAndMachinery, BusinessDescriptionOptionText = "Plant And Machinery" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.CarpetServices, BusinessDescriptionOptionText = "Carpet Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.TreeWork, BusinessDescriptionOptionText = "Tree Work" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.FlooringServices, BusinessDescriptionOptionText = "Flooring Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Bakers, BusinessDescriptionOptionText = "Bakers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.UtilitySector, BusinessDescriptionOptionText = "Utility Sector" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PetServices, BusinessDescriptionOptionText = "Pet Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.FoodManufacture, BusinessDescriptionOptionText = "Food Manufacture" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Manufacturing, BusinessDescriptionOptionText = "Manufacturing" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Mining, BusinessDescriptionOptionText = "Mining" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Retail, BusinessDescriptionOptionText = "Retail" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Construction, BusinessDescriptionOptionText = "Construction" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.LeisureAndEntertainment, BusinessDescriptionOptionText = "Leisure And Entertainment" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Carpentry, BusinessDescriptionOptionText = "Carpentry" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Engineering, BusinessDescriptionOptionText = "Engineering" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Computing, BusinessDescriptionOptionText = "Computing" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Joinery, BusinessDescriptionOptionText = "Joinery" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.RoofingContractors, BusinessDescriptionOptionText = "Roofing Contractors" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Plasterers, BusinessDescriptionOptionText = "Plasterers" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.PropertyDevelopment, BusinessDescriptionOptionText = "Property Development" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.CountyCouncil, BusinessDescriptionOptionText = "County Council" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Locksmith, BusinessDescriptionOptionText = "Locksmith" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Blacksmith, BusinessDescriptionOptionText = "Blacksmith" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.TilingServices, BusinessDescriptionOptionText = "Tiling Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Logistics, BusinessDescriptionOptionText = "Logistics" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.BeautyTherapy, BusinessDescriptionOptionText = "BeautyTherapy" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.BathroomInstallation, BusinessDescriptionOptionText = "Bathroom Installation" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Maintenance, BusinessDescriptionOptionText = "Maintenance" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.BusinessServices, BusinessDescriptionOptionText = "Business Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.HeatingServices, BusinessDescriptionOptionText = "Heating Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.VentilationServices, BusinessDescriptionOptionText = "Ventilation Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.ConditioningServices, BusinessDescriptionOptionText = "Conditioning Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.DesignServices, BusinessDescriptionOptionText = "Design Services" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Distribution, BusinessDescriptionOptionText = "Distribution" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.TimberMerchants, BusinessDescriptionOptionText = "Timber Merchants" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Fabrication, BusinessDescriptionOptionText = "Fabrication" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Medical, BusinessDescriptionOptionText = "Medical" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.RemovalsAndStorage, BusinessDescriptionOptionText = "Removals And Storage" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Haulage, BusinessDescriptionOptionText = "Haulage" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Horticulture, BusinessDescriptionOptionText = "Horticulture" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.LocalAuthority, BusinessDescriptionOptionText = "Local Authority" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.VehicleRental, BusinessDescriptionOptionText = "Vehicle Rental" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.WasteManagement, BusinessDescriptionOptionText = "Waste Management" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.BlueLight, BusinessDescriptionOptionText = "Blue Light" });
            context.BusinessDescriptionOptions.Add(new BusinessDescriptionOption { BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.FreightForwarding, BusinessDescriptionOptionText = "Freight Forwarding" });
            

            //Populate workshop lookup table
            context.WorkshopOptions.Add(new WorkshopOption { WorkshopOptionId = (byte) WorkshopEnum.Unknown, WorkshopOptionText = "Unknown"});
            context.WorkshopOptions.Add(new WorkshopOption { WorkshopOptionId = (byte)WorkshopEnum.Yes, WorkshopOptionText = "Yes" });
            context.WorkshopOptions.Add(new WorkshopOption { WorkshopOptionId = (byte)WorkshopEnum.No, WorkshopOptionText = "No" });

            //Populate used trucks or trailers table
            context.UsedTrucksOrTrailersOptions.Add(new UsedTrucksOrTrailersOption { UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown, UsedTrucksOrTrailersOptionText = "Unknown" });
            context.UsedTrucksOrTrailersOptions.Add(new UsedTrucksOrTrailersOption { UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.No, UsedTrucksOrTrailersOptionText = "No" });
            context.UsedTrucksOrTrailersOptions.Add(new UsedTrucksOrTrailersOption { UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.YesBoth, UsedTrucksOrTrailersOptionText = "Yes Both" });
            context.UsedTrucksOrTrailersOptions.Add(new UsedTrucksOrTrailersOption { UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.YesTrailers, UsedTrucksOrTrailersOptionText = "Yes Trailers" });
            context.UsedTrucksOrTrailersOptions.Add(new UsedTrucksOrTrailersOption { UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.YesTrucks, UsedTrucksOrTrailersOptionText = "Yes Trucks" });

            //Populate weights lookup table
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs, WeightValue = "7500Kgs"});
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs, WeightValue = "8000-16000Kgs"});
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs, WeightValue = "18000Kgs"});
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs, WeightValue = "26000Kgs"});
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs, WeightValue = "32000Kgs"});
            context.TruckWeights.Add(new TruckWeight{WeightValueId = (byte) TruckWeightEnum.WeightTractor, WeightValue = "Tractor"});

            //Populate body types lookup table
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.AnimalTransporter, BodyTypeValue = "Animal Transporter"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.BeaverTail, BodyTypeValue = "Beaver Tail"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Box, BodyTypeValue = "Box"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Bulker, BodyTypeValue = "Bulker"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.CarTransporter, BodyTypeValue = "Car Transporter"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Coach, BodyTypeValue = "Coach"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Curtainsider, BodyTypeValue = "Curtainsider"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Demount, BodyTypeValue = "Demount"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Dropside, BodyTypeValue = "Dropside"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.FireFightingVehicles, BodyTypeValue = "Fire Fighting Vehicles"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Flat, BodyTypeValue = "Flat"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Fridge, BodyTypeValue = "Fridge"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.HighRoof, BodyTypeValue = "High Roof"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Lowloader, BodyTypeValue = "Low Loader"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Luton, BodyTypeValue = "Luton"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Mixer, BodyTypeValue = "Mixer"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Other, BodyTypeValue = "Other"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Panel, BodyTypeValue = "Panel"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.PickUp, BodyTypeValue = "PickUp"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.RecoveryVehicle, BodyTypeValue = "Recovery Vehicle"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.RollonRollOff, BodyTypeValue = "Rollon Roll Off"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Skeletal, BodyTypeValue = "Skeletal"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Skip, BodyTypeValue = "Skip"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Standard, BodyTypeValue = "Standard"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Tanker, BodyTypeValue = "Tanker"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Tilt, BodyTypeValue = "Tilt"});
            context.BodyTypes.Add(new BodyType {BodyTypeId = (byte) BodyTypeEnum.Tipper, BodyTypeValue = "Tipper"});

            //Populate chassis makes lookup table
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Dennis, ChassisMakeValue = "Dennis"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Daewoo, ChassisMakeValue = "Daewoo"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Daf, ChassisMakeValue = "Daf"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Erf, ChassisMakeValue = "Erf"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Foden, ChassisMakeValue = "Foden"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Hino, ChassisMakeValue = "Hino"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Isuzu, ChassisMakeValue = "Isuzu"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Iveco, ChassisMakeValue = "Iveco"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Man, ChassisMakeValue = "Man"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Mercedes, ChassisMakeValue = "Mercedes"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Mitsubishi, ChassisMakeValue = "Mitsubishi"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Renault, ChassisMakeValue = "Renault"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Scania, ChassisMakeValue = "Scania"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.SeddonAtkinson, ChassisMakeValue = "SeddonAtkinson"});
            context.ChassisMakes.Add(new ChassisMake{ChassisMakeId = (byte) ChassisMakeEnum.Volvo, ChassisMakeValue = "Volvo"});


            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.BuyOutright, FinanceMethodOptionText = "Buy Outright"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.ContractHire, FinanceMethodOptionText = "Contract Hire"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.FinanceLease, FinanceMethodOptionText = "Finance Lease"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.HirePurchase, FinanceMethodOptionText = "Hire Purchase"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.OperatingLease, FinanceMethodOptionText = "Operating Lease"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.Rental, FinanceMethodOptionText = "Rental"});
            context.FinanceMethodOptions.Add(new FinanceMethodOption
                {FinanceMethodOptionId = (byte) FinanceMethodEnum.DontKnow, FinanceMethodOptionText = "Don't Know"});

            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.TwoOne, AxleCombinationOptionText = "2+1"});
            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.TwoTwo, AxleCombinationOptionText = "2+2"});
            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.TwoThree, AxleCombinationOptionText = "2+3"});
            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.ThreeTwo, AxleCombinationOptionText = "3+2"});
            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.ThreeThree, AxleCombinationOptionText = "3+3"});
            context.AxleCombinationValues.Add(new AxleCombinationOption
                {AxleCombinationOptionId = (byte) AxleCombinationEnum.DontKnow, AxleCombinationOptionText = "Don't Know"});

            //Populate ChassisMakesByWeights
            //Daewoo
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Daewoo,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });

            //DAF
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Daf, WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Daf,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Daf, WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Daf, WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Daf, WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Daf, WeightValueId = (byte) TruckWeightEnum.WeightTractor});

            //Dennis
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Dennis,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Dennis,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });

            //ERF
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Erf, WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Erf, WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Erf, WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Erf, WeightValueId = (byte) TruckWeightEnum.WeightTractor});

            //Foden
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Foden,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Foden,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Foden,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Foden,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            //Hino
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Hino,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Hino,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Hino, WeightValueId = (byte) TruckWeightEnum.WeightTractor});

            //Isuzu
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Isuzu,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Isuzu,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Isuzu,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });

            //Iveco
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Iveco,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            //MAN
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Man, WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Man,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Man, WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Man, WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Man, WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs});
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {ChassisMakeValueId = (byte) ChassisMakeEnum.Man, WeightValueId = (byte) TruckWeightEnum.WeightTractor});

            //Mercedes
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mercedes,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            //Mitsubishi
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Mitsubishi,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });

            //Renault
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Renault,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            //Scania
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Scania,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Scania,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Scania,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Scania,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Scania,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });


            //SeddonAtkinson
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.SeddonAtkinson,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.SeddonAtkinson,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.SeddonAtkinson,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.SeddonAtkinson,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            //Volvo
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.Weight800016000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.Weight18000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs
                });
            context.ChassisMakesByWeights.Add(new ChassisMakeByWeight
                {
                    ChassisMakeValueId = (byte) ChassisMakeEnum.Volvo,
                    WeightValueId = (byte) TruckWeightEnum.WeightTractor
                });

            context.ContactPositions.Add(new ContactPosition
            {
                    ContactPositionId = 8, ContactPositionText = "Senior Executive"
            });

            context.ContactPositions.Add(new ContactPosition
            {
                ContactPositionId = 9,
                ContactPositionText = "Transport Manager"
            });

            context.ContactPositions.Add(new ContactPosition
            {
                ContactPositionId = 10,
                ContactPositionText = "Financial Director"
            });

            context.ContactPositions.Add(new ContactPosition
            {
                ContactPositionId = 11,
                ContactPositionText = "Fleet Engineer"
            });

            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 7,
                    CallOutcomeText = "Ceased trading"
                });
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 9,
                    CallOutcomeText = "Target requested removal"
                });
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 18,
                    CallOutcomeText = "Duplicate record"
                });
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 4,
                    CallOutcomeText = "Telephone number incorrect"
                });   
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 10,
                    CallOutcomeText = "Target refused interview"
                });
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 11,
                    CallOutcomeText = "Target does not run trucks"
                });
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 12,
                    CallOutcomeText = "Completed interview"
                });       
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 1,
                    CallOutcomeText = "Call back target busy"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 2,
                    CallOutcomeText = "Call back line engaged"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 3,
                    CallOutcomeText = "Call back answer machine"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 15,
                    CallOutcomeText = "Call back telephone not answered"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 20,
                    CallOutcomeText = "Call back target off site"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 22,
                    CallOutcomeText = "Target requested fax interview"
                });      
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 23,
                    CallOutcomeText = "Target requested mail interview"
                });                          
            context.CallOutcomes.Add(new CallOutcome
                {
                    CallOutcomeId = 24,
                    CallOutcomeText = "Target requested email interview"
                });                          
            /*--------------------------------------------------*/
            //save all lookup tables to database
            /*--------------------------------------------------*/
            context.SaveChanges();
            /*--------------------------------------------------*/
            
            
            var op = new Operator
            {
                OperatorId = 1,
                GroupId=202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "SCANIA GB LTD",
                Address2 = "ALTENS INDUSTRIAL ESTATE",
                County = "ABERDEEN",
                Postcode = "AB12 3LH",
                LicenceTrucks = 6,
                LicenceTrailers = 12,
                ApplyingAddress=true,
                InUse=false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId=(byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op2 = new Operator
            {
                OperatorId = 2,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "JOHN G RUSSELL TPT",
                Address2 = "NEEDLEFIELD RAIL YARD OFF LONGMAN ROAD",
                County = "INVERNESS",
                Postcode = "IV1 1RY",
                LicenceTrucks = 8,
                LicenceTrailers = 15,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op3 = new Operator
            {
                OperatorId = 3,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "U D V (LEVEN)",
                Address2 = "BANBEATH INDUSTRIAL ESTATE",
                Town = "WINDYGATES",
                County = "LEVEN",
                Postcode = "KY8 5HD",
                LicenceTrucks = 8,
                LicenceTrailers = 20,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op4 = new Operator
            {
                OperatorId = 4,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "GOIL AVENUE",
                Address2 = "RIGHEAD INDUSTRIAL ESTATE",
                Town = "BELLSHILL",
                County = "LANARKSHIRE",
                Postcode = "ML4 3LQ",
                LicenceTrucks = 36,
                LicenceTrailers = 105,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op5 = new Operator
            {
                OperatorId = 5,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "U D V (HURLFORD)",
                Address2 = "MAUCHLINE ROAD",
                Town = "HURLFORD",
                County = "KILMARNOCK",
                Postcode = "KA1 5JJ",
                LicenceTrucks = 4,
                LicenceTrailers = 10,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op6 = new Operator
            {
                OperatorId = 6,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "U D V (SHIELDHALL)",
                Address2 = "500 RENFREW ROAD",
                County = "GLASGOW",
                Postcode = "G51 4SA",
                LicenceTrucks = 5,
                LicenceTrailers = 15,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op8 = new Operator
            {
                OperatorId = 7,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "DAVENTRY INTERNATIONAL",
                Address2 = "RAILPORT APPROACH",
                Address3 = "DAVENTRY RAIL FREIGHT TERMINAL",
                County = "NORTHAMPTON",
                Postcode = "NN6 7JZ",
                LicenceTrucks = 6,
                LicenceTrailers = 8,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op7 = new Operator
            {
                OperatorId = 8,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "FIFE WAREHOUSING CO LTD",
                Address2 = "FRANCES INDUSTRIAL PARK",
                Address3 = "WEMYSS ROAD",
                Town = "DYSART",
                County = "KIRKCALDY",
                Postcode = "KY1 2XZ",
                LicenceTrucks = 6,
                LicenceTrailers = 8,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };
            var op9 = new Operator
            {
                OperatorId = 9,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "JOHN G RUSSELL TRANSPORT LTD",
                Address2 = "CONTAINERBASE",
                Address3 = "GARTSHERRIE ROAD",
                Town = "COATBRIDGE",
                Postcode = "ML5 2DS",
                LicenceTrucks = 50,
                LicenceTrailers = 150,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op10 = new Operator
            {
                OperatorId = 10,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "THE GOODS YARD",
                Address2 = "DALLAM LANE",
                Address3 = "",
                Town = "WARRINGTON",
                County = "Lancashire",
                Postcode = "WA2 8NR",
                LicenceTrucks = 15,
                LicenceTrailers = 30,
                ApplyingAddress = false,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            var op11 = new Operator
            {
                OperatorId = 11,
                GroupId = 202,
                CompanyName = "JOHN G RUSSELL (TRANSPORT) LIMITED",
                Address1 = "RUSSELL",
                Address2 = "DEANSIDE ROAD",
                Address3 = "",
                Town = "",
                County = "GLASGOW",
                Postcode = "G52 4XB",
                LicenceTrucks = 31,
                LicenceTrailers = 98,
                ApplyingAddress = true,
                InUse = false,
                WorkshopOptionId = (byte)WorkshopEnum.Unknown,
                UsedTrucksOrTrailersOptionId = (byte)UsedTruckOrTrailersEnum.Unknown,
                BusinessDescriptionOptionId = (byte)BusinessDescriptionEnum.Unknown
            };

            op.Trucks = new Collection<Truck>
                {
                    new Truck {WeightValueId = (byte) TruckWeightEnum.Weight26000Kgs, Count = 12},
                    new Truck {WeightValueId = (byte) TruckWeightEnum.Weight7500Kgs, Count = 64},
                    new Truck {WeightValueId = (byte) TruckWeightEnum.Weight32000Kgs, Count = 3},
                    new Truck {WeightValueId = (byte) TruckWeightEnum.WeightTractor, Count = 2}
                };

            var truck = op.Trucks.First(weight => weight.WeightValueId == (byte) TruckWeightEnum.Weight7500Kgs);

            truck.Bodies = new Collection<Body>
                {
                    new Body {BodyTypeId = (byte) BodyTypeEnum.Tipper},
                    new Body {BodyTypeId = (byte) BodyTypeEnum.Curtainsider}
                };

            truck.Chassis = new Collection<Chassis>
                {
                    new Chassis {ChassisMakeId = (byte) ChassisMakeEnum.Iveco},
                    new Chassis {ChassisMakeId = (byte) ChassisMakeEnum.Mitsubishi},
                };

            truck = op.Trucks.First(weight => weight.WeightValueId == (byte) TruckWeightEnum.Weight32000Kgs);

            truck.Bodies = new Collection<Body>
                {
                    new Body {BodyTypeId = (byte) BodyTypeEnum.CarTransporter},
                    new Body {BodyTypeId = (byte) BodyTypeEnum.Tanker},
                    new Body {BodyTypeId = (byte) BodyTypeEnum.Curtainsider},
                    new Body {BodyTypeId = (byte) BodyTypeEnum.Tipper}
                };

            truck.Chassis = new Collection<Chassis>
                {
                    new Chassis {ChassisMakeId = (byte) ChassisMakeEnum.Mercedes},
                    new Chassis {ChassisMakeId = (byte) ChassisMakeEnum.Scania},
                };

            op.FinanceMethods = new Collection<FinanceMethod>
                {
                    new FinanceMethod {FinanceMethodOptionId = (byte) FinanceMethodEnum.FinanceLease}
                };

            op.AxleCombinations = new Collection<AxleCombination>
                {
                    new AxleCombination {AxleCombinationOptionId = (byte) AxleCombinationEnum.ThreeThree},
                    new AxleCombination {AxleCombinationOptionId = (byte) AxleCombinationEnum.TwoThree}
                };

            op.Contacts = new Collection<Contact> {
                new Contact {Title = "Mr", Initial = "L", Surname = "Ward", ContactPositionId = (byte) ContactPositionEnum.SeniorExecutive},
                new Contact { Title = "Mr", Initial = "S", Surname = "Porter", ContactPositionId = (byte) ContactPositionEnum.FleetEngineer}
            };

            op.Calls = new Collection<Call>();

            for (var i = 0; i < 5; i++)
            {
                op.Calls.Add(new Call
                    {
                        CallBackDate = Convert.ToDateTime(11+i + "/04/2014 14:00"),
                        Operative = "Louise",
                        Notes = "Test some notes - " + i,
                        InterviewStart = Convert.ToDateTime(1+i + "/04/2014 14:00"),
                        InterviewEnd = Convert.ToDateTime("09/04/2014 14:06"),
                        CallOutcomeId = (byte)CallOutcomeEnum.CompletedInterview
                    });
            }
            op.Calls.OrderByDescending(d => d.InterviewStart).First().CurrentCall = true;
            context.Operators.Add(op);
            context.Operators.Add(op2);
            context.Operators.Add(op3);
            context.Operators.Add(op4);
            context.Operators.Add(op5);
            context.Operators.Add(op6);
            context.Operators.Add(op7);
            context.Operators.Add(op8);
            context.Operators.Add(op9);
            context.Operators.Add(op10);
            context.Operators.Add(op11);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}