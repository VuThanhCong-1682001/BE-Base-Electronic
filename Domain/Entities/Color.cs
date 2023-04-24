using Domain.Common;

namespace Domain.Entities
{
    public class Color:BaseTableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
    }
}
