using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ticketing.Command.Domain.Common
{
    /// <summary>
    /// Clase base para todos los documentos en la base de datos MongoDB.
    /// Implementa la interfaz IDocument y proporciona la propiedad Id.
    /// </summary>
    public class Document : IDocument
    {
        /// <summary>
        /// Identificador único del documento en MongoDB.
        /// Se almacena como un string en lugar del tipo ObjectId nativo.
        /// </summary>
        [BsonRepresentation(BsonType.String)] // Especifica que el ObjectId se representará como un string.
        public ObjectId Id { get; set; } // Propiedad para el ID del documento.
    }
}