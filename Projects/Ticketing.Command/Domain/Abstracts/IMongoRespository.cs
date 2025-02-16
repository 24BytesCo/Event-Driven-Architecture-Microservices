using MongoDB.Driver;

namespace Ticketing.Command.Domain.Abstracts
{
    /// <summary>
    /// Interfaz que define las operaciones de repositorio para documentos de MongoDB.
    /// Hereda de ISesion para la gestión de sesiones y transacciones.
    /// </summary>
    /// <typeparam name="TDocument">El tipo de documento que se va a manipular.</typeparam>
    public interface IMongoRespository<TDocument> : ISesion where TDocument : class
    {
        /// <summary>
        /// Obtiene un IQueryable para realizar consultas LINQ sobre la colección de documentos.
        /// </summary>
        /// <returns>Un IQueryable que se puede utilizar para construir consultas.</returns>
        IQueryable<TDocument> AsQueryable();

        /// <summary>
        /// Inserta un documento en la colección de forma asíncrona.
        /// </summary>
        /// <param name="document">El documento que se va a insertar.</param>
        /// <param name="clientSessionHandle">La sesión de MongoDB en la que se realiza la inserción.
        ///  Puede ser nula si no se requiere una transacción.</param>
        /// <param name="cancellationToken">Token de cancelación para la operación.</param>
        /// <returns>Una tarea que representa la operación asíncrona de inserción.</returns>
        Task InsertOneAsync(TDocument document, IClientSessionHandle? clientSessionHandle, CancellationToken cancellationToken);

    }
}