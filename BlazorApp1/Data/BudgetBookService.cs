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

        public async Task<bool> DeleteEntry(Entry newEntry)
        {
            try
            {
                // Assuming mockDb is a collection that supports Remove() method, otherwise, adjust accordingly.
                mockDb.Remove(newEntry);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> AddOrUpdateEntry(Entry entryToUpdate)
        {
            try
            {
                // Check if the entry exists in the mockDb.
                var existingEntry = mockDb.FirstOrDefault(e => e.Description == entryToUpdate.Description);

                if (existingEntry != null)
                {
                    // If the entry exists, update its properties with the new values.
                    existingEntry.Description = entryToUpdate.Description;
                    //existingEntry.Amount = entryToUpdate.Amount;
                    // Update other properties as needed.
                }
                else
                {
                    // If the entry does not exist, add the new entry to the mockDb.
                    mockDb.Add(entryToUpdate);
                }
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
        public void DeleteAllEntries()
        {
            // Assuming mockDb is a collection that supports Clear() method, otherwise, adjust accordingly.
            mockDb.Clear();
        }

        public async Task<bool> AddOrUpdateCheckBoxEntry(Entry entryToUpdate)
        {
            try
            {
                // Check if the entry exists in the mockDb.
                var existingEntry = mockDb.FirstOrDefault(e => e.IsChecked == entryToUpdate.IsChecked);

                if (existingEntry != null)
                {
                    // If the entry exists, update its properties with the new values.
                    existingEntry.IsChecked = entryToUpdate.IsChecked;
                    //existingEntry.Amount = entryToUpdate.Amount;
                    // Update other properties as needed.
                }
                else
                {
                    // If the entry does not exist, add the new entry to the mockDb.
                    mockDb.Add(entryToUpdate);
                }
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

    }
}