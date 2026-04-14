using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Inventory
    {
        [Key]
        public string? Code { get; set; }

        [Column("ITEMS DESCRIPTIONS")]
        public string? ITEMS_DESCRIPTIONS { get; set; }

        [Column("COST_PRICE")]
        public double? COST_PRICE { get; set; }

        [Column("Tax _%")]
        public string? Tax_Percentage { get; set; }

        [Column("Tax _Amount")]
        public double? Tax_Amount { get; set; }

        [Column("Cost_With_Tax")]
        public double? Cost_With_Tax { get; set; }

        [Column("SALE _PRICE")]
        public double? SALE_PRICE { get; set; }

        [Column("MKT_PRICE")]
        public double? MKT_PRICE { get; set; }

        [Column("CLASS")]
        public string? CLASS { get; set; }

        [Column("SUPPLIER NAME")]
        public string? SUPPLIER_NAME { get; set; }

        [Column("MARGIN_COST %")]
        public string? MARGIN_COST { get; set; }

        [Column("branch")]
        public string? Branch { get; set; }   // 👈 Capital B

        [Column("brand")]
        public string? brand { get; set; }
    }
}
