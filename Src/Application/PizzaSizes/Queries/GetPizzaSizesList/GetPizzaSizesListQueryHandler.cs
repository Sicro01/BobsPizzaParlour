using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BobsPizzaParlour.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BobsPizzaParlour.Application.PizzaSizes.Queries.GetPizzaSizesList
{
    public class GetPizzaSizesListQueryHandler : IRequestHandler<GetPizzaSizesListQuery, PizzaSizesListVm>
    {
        private readonly IBobsPizzaParlourDbContext _context;
        private readonly IMapper _mapper;

        public GetPizzaSizesListQueryHandler(IBobsPizzaParlourDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PizzaSizesListVm> Handle(GetPizzaSizesListQuery request, CancellationToken cancellationToken)
        {
            var pizzaSizes = await _context.PizzaSizes
                .ProjectTo<PizzaSizeLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new PizzaSizesListVm
            {
                PizzaSizes = pizzaSizes
            };

            return vm;
        }
    }
}
