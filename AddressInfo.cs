namespace Ss.RealEstate.Model
{
    public class AddressInfo
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string FullAddress { get; set; }
        public string DetailsLink { get; set; }

        public void Copy(AddressInfo address)
        {
            Address1 = address.Address1;
            City = address.City;
            State = address.State;
            Zip = address.Zip;
            Latitude = address.Latitude;
            Longitude = address.Longitude;
        }
    }
}
