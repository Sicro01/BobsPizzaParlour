using AutoMapper;
using BobsPizzaParlour.Application.Common.Mappings;
using BobsPizzaParlour.Domain.Entities;

namespace BobsPizzaParlour.Application.PizzaSizes.Queries.GetPizzaSizesList
{
    public class PizzaSizeLookupDto : IMapFrom<PizzaSize>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PizzaSize, PizzaSizeLookupDto>();
        }
    }
}
