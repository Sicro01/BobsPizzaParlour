using BobsPizzaParlour.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BobsPizzaParlour.Application.Common.Interfaces
{
    public interface IBobsPizzaParlourDbContext
    {
        DbSet<PizzaSize> PizzaSizes { get; set; }
    }
}
