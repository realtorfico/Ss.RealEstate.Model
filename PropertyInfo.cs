namespace Ss.RealEstate.Model
{
    public class PropertyInfo
    {
        public uint PropertyId { get; set; }
        public uint ListedPrice { get; set; }
        public uint DesirabilityScore { get; set; }
        public uint ZAmount { get; set; }
        public uint ZRent { get; set; }
        public string HomeType { get; set; }
        public string SaleType { get; set; }
        public uint YearBuilt { get; set; }
        public uint LotSize { get; set; }
        public uint FinishedSize { get; set; }
        public double Bathrooms { get; set; }
        public uint Bedrooms { get; set; }
        public uint Hoa { get; set; }
        public uint MlsNumber { get; set; }
        public uint PricePerSqft { get; set; }
        public uint Stories { get; set; }
        public uint UnitCount { get; set; }

        public string HomeDetailsLink { get; set; }
        public string RedfinLink { get; set; }

        public string LastSoldDate { get; set; }
        public uint LastSoldPrice { get; set; }
        public uint LastRemodelYear { get; set; }

        public uint ElementarySchoolRating { get; set; }
        public uint MiddleSchoolRating { get; set; }
        public uint HighSchoolRating { get; set; }

        public AddressInfo Address { get; set; }

        public string FipsCountyCode { get; set; }
        public string ZAmountLastUpdated { get; set; }
        public string ZRentLastUpdated { get; set; }
    }
}
