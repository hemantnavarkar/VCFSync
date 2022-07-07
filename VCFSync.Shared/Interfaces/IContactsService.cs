using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace VCFSync.Interfaces
{
    /// <summary>
    /// Service contract responsible for performing operations on the contacts from mobile phone storage.
    /// </summary>
    interface IContactsService
    {
        /// <summary>
        /// Retrives the contacts from phone storage.
        /// </summary>
        /// <returns>Contacts</returns>
        Task<IReadOnlyCollection<Contact>> GetAllContact();
    }
}
