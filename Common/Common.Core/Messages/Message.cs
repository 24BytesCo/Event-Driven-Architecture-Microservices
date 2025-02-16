using MongoDB.Bson.Serialization.Attributes;

namespace Common.Core.Messages
{
    /// <summary>
    /// Clase abstracta base para todos los mensajes en el sistema.
    /// Define propiedades comunes que comparten todos los mensajes.
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// Constructor predeterminado sin parámetros.
        /// Se utiliza para la deserialización y otras operaciones.
        /// </summary>
        public Message()
        {
        }

        /// <summary>
        /// Identificador único del mensaje.
        /// Se utiliza como clave primaria en la base de datos MongoDB.
        /// El atributo [BsonId] indica que esta propiedad se debe mapear al campo "_id" en MongoDB.
        /// </summary>
        [BsonId]
        public string Id { get; set; } = string.Empty; // Inicialización para evitar valores nulos.

    }
}