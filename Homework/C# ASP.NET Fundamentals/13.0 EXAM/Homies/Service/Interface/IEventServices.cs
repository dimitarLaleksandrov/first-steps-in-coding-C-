using Homies.Models;

namespace Homies.Service.Interface
{
    public interface IEventServices
    {
        Task<AddEventFormModel> GetAddEventFormModelAsync();


        Task AddEventAsync(AddEventFormModel eventModel, string userId);

        Task<AddEventFormModel?> GetEventByIdForEditAsync(int id);

        Task EdiEventAsync(int id, AddEventFormModel model);

        Task<IEnumerable<AddEventFormModel>> GetAllEventsAsync();

        Task Join(string userId, int eventId);


 
    }
}
