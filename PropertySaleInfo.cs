namespace Ss.RealEstate.Model
{
    public class PropertySaleInfo
    {
        public AddressInfo Address { get; set; }
        public string Status { get; set; }
        public string AgentName { get; set; }
        public string BrokerageName { get; set; }
        public string PostingType { get; set; }
        public string LastUpdateDate { get; set; }
        public string MlsNumber { get; set; }
        public uint Price { get; set; }
        public string HomeType { get; set; }
        public uint Bedrooms { get; set; }
        public uint Bathrooms { get; set; }
        public uint FinishedSize { get; set; }
        public uint LotSize { get; set; }
        public uint YearBuilt { get; set; }
        public uint NumberOfFloor { get; set; }
        public string Basement { get; set; }
        public string RoofType { get; set; }
        public string View { get; set; }
        public string ParkingType { get; set; }
        public string HeatingSources { get; set; }
        public string HeatingSystem { get; set; }
        public string Appliances { get; set; }
        public string FloorCovering { get; set; }
        public uint NumberOfRooms { get; set; }
        public string HomeDescription { get; set; }
        public string Neighborhood { get; set; }
        public string SchoolDistrict { get; set; }
        public string ElementarySchool { get; set; }
        public string MiddleSchool { get; set; }
    }
}
