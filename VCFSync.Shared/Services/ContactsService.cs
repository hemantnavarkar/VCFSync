using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCFSync.Interfaces;
using Xamarin.Essentials;


namespace VCFSync.Services
{
    /// <summary>
    /// Service contract responsible for performing operations on the contacts from mobile phone storage.
    /// </summary>
    public class ContactsService : IContactsService
    {
        /// <summary>
        /// Retrives the contacts from phone storage.
        /// </summary>
        /// <returns>Contacts</returns>
        public async Task<IReadOnlyCollection<Contact>> GetAllContact()
        {
            var contacts = await Contacts.GetAllAsync();
            return contacts.ToList().AsReadOnly();
        }
    }
}
