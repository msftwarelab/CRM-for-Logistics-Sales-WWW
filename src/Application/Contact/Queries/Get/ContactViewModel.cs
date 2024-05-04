using Application.Common.Dtos;
using Application.Contact.Common;

namespace Application.Contact.Queries.Get
{
    public class ContactViewModel
    {
        public ContactViewModel(ContactDto contact, DocumentDto? profilePicture)
        {
            Contact = contact;
            ProfilePicture = profilePicture;
        }

        public ContactDto Contact { get; }
        public DocumentDto? ProfilePicture { get; }
    }
}
