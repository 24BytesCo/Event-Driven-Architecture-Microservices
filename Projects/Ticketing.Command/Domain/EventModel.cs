using Common.Core.Events;
using MongoDB.Bson.Serialization.Attributes;
using Ticketing.Command.Domain.Common;

namespace Ticketing.Command.Domain
{
    /// <summary>
    /// Modelo base para representar un evento en el sistema.
    /// Esta clase se utiliza para almacenar eventos en la base de datos MongoDB.
    /// </summary>
    [BsonCollection("eventStores")] // Especifica la colección en MongoDB donde se almacenarán los eventos.
    public class EventModel : Document // Hereda de la clase Document, que define propiedades comunes como Id.
    {
        /// <summary>
        /// Fecha y hora en que ocurrió el evento.
        /// </summary>
        [BsonElement("timestamp")] // Especifica el nombre del campo en el documento MongoDB.
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Identificador único del agregado al que pertenece este evento.
        /// </summary>
        [BsonElement("aggregateIdentifier")] // Especifica el nombre del campo en el documento MongoDB.
        public required string AggregateIdentifier { get; set; } // 'required' indica que esta propiedad es obligatoria.

        /// <summary>
        /// Tipo del agregado al que pertenece este evento.
        /// </summary>
        [BsonElement("aggregateType")] // Especifica el nombre del campo en el documento MongoDB.
        public string AggregateType { get; set; } = string.Empty;

        /// <summary>
        /// Versión del evento. Se utiliza para el control de concurrencia y el ordenamiento de eventos.
        /// </summary>
        [BsonElement("version")] // Especifica el nombre del campo en el documento MongoDB.
        public int Version { get; set; }

        /// <summary>
        /// Tipo específico del evento.  Describe la acción que ocurrió (ej: "TicketCreated", "TicketAssigned").
        /// </summary>
        [BsonElement("eventType")] // Especifica el nombre del campo en el documento MongoDB.
        public string EventType { get; set; } = string.Empty;

        /// <summary>
        /// Datos específicos del evento.
        /// </summary>
        public BaseEvent? EventData { get; set; }  // Propiedad de tipo BaseEvent, que contiene los datos específicos del evento.
        
    }
}