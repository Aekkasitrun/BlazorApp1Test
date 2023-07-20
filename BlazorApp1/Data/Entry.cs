using System.ComponentModel.DataAnnotations;

namespace BudgetBook.Data
{
    public class Entry
    {
        //public int Id { get; set; }
        [Required] public string Description { get; set; }
        public double Amount { get; set; }
    }
}