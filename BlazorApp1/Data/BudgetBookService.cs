namespace BudgetBook.Data
{
    public class BudgetBookService
    {
        public int MyProperty { get; set; }
        private static List<Entry> mockDb = new List<Entry>();
       
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

        public async Task<bool> DeleteEntry(Entry entryToDelete)
        {
            try
            {
                // Assuming mockDb is a collection that supports Remove() method, otherwise, adjust accordingly.
                mockDb.Remove(entryToDelete);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
            return await Task.FromResult(true);
        }
    }
}
