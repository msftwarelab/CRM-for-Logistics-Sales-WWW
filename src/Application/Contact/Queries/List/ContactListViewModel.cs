using Application.Contact.Common;

namespace Application.Contact.Queries.List
{
    public class ContactListViewModel
    {
        public ContactListViewModel()
        {
            Contacts = new List<ContactDto>();
        }

        public List<ContactDto> Contacts { get; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int Records { get; set; }
    }
}
