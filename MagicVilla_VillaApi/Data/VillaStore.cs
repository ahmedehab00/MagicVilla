using MagicVilla_VillaApi.Model.DTO;

namespace MagicVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
                new VillaDto{Id=1,Name="Pool View",Occupancy=10000,Sqft=3},
                new VillaDto{Id=2,Name="Beach View",Occupancy=20000,Sqft=4}
        };
    }
}
