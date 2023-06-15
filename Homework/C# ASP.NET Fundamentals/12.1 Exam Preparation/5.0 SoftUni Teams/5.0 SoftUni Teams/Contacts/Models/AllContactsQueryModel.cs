namespace Contacts.Models
{
    public class AllContactsQueryModel
    {
        public AllContactsQueryModel()
        {
            this.Contacts = new HashSet<ContactViewModel>();
        }

        public IEnumerable<ContactViewModel> Contacts { get; set; }
           
    }

}
