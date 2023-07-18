namespace BudgetBook.Data
{
    public class BudgetBookService
    {
        public int MyProperty { get; set; }
        private static List<Entry> mockDb = new List<Entry>()
        {
            new Entry(){Description="Test",Amount=4.99m}
        };
        public async Task<bool> AddEntry(Entry newEntry)
        {
            try
            {
                mockDb.Add(newEntry);

            }
            catch (Exception)
            {
                return await Task.FromResult(false);
                
            }
            return await Task.FromResult(true);
        }
        public async Task<List<Entry>> GetAllEntries()
        {
            return await Task.FromResult(mockDb);
        }
    }
}
