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

<<<<<<< HEAD
        public async Task<bool> DeleteEntry(Entry entryToDelete)
=======
        public async Task<bool> DeleteEntry(Entry newEntry)
>>>>>>> develop
        {
            try
            {
                // Assuming mockDb is a collection that supports Remove() method, otherwise, adjust accordingly.
<<<<<<< HEAD
                mockDb.Remove(entryToDelete);
=======
                mockDb.Remove(newEntry);
>>>>>>> develop
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
            return await Task.FromResult(true);
        }
    }
}
