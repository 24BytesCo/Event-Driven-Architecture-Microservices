using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ticketing.Command.Domain.Common
{
    /// <summary>
    /// Interfaz para marcar clases como documentos en la base de datos MongoDB.
    /// Define la propiedad Id común a todos los documentos.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Identificador único del documento en MongoDB.
        /// Se almacena como un string en lugar del tipo ObjectId nativo.
        /// </summary>
        [BsonId] // Indica que esta propiedad es el ID del documento.
        [BsonRepresentation(BsonType.String)] // Especifica que el ObjectId se representará como un string.
        ObjectId Id { get; set; } // Propiedad para el ID del documento.
    }
}