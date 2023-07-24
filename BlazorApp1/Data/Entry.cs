using System.ComponentModel.DataAnnotations;

namespace BudgetBook.Data
{
    public class Entry
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="กรุณาเพิ่มรายการ")] public string? Description { get; set; }
        //public double Amount { get; set; }
        public bool IsChecked { get; set; }
    }
}