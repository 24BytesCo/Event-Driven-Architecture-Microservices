using Ticketing.Command.Domain.Abstracts;

namespace Ticketing.Command.Domain.EventModels
{
    /// <summary>
    /// Interfaz que define el repositorio para la colección de documentos EventModel en MongoDB.
    /// Hereda de IMongoRespository<EventModel> y, por lo tanto, proporciona acceso a las operaciones
    /// genéricas de repositorio, así como cualquier operación específica para EventModel.
    /// </summary>
    public interface IEventModelRepository : IMongoRespository<EventModel>
    {
    }
}