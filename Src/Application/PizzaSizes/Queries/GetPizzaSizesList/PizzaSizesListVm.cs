using System;
using System.Collections.Generic;
using System.Text;

namespace BobsPizzaParlour.Application.PizzaSizes.Queries.GetPizzaSizesList
{
    public class PizzaSizesListVm
    {
        public IList<PizzaSizeLookupDto> PizzaSizes { get; set; }
    }
}
