using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreatePricingSchemeRequest
    {
        public string SchemeType { get; set; }
        public List<CreatePriceBracketRequest> PriceBrackets { get; set; }
        public int? Price { get; set; }
        public int? MinimumPrice { get; set; }
    }
} 