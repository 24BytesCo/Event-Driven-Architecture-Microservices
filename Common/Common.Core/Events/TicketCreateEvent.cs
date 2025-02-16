namespace Common.Core.Events
{
    /// <summary>
    /// Evento que se genera cuando se crea un nuevo ticket.
    /// Hereda de BaseEvent y contiene información específica sobre la creación del ticket.
    /// </summary>
    public class TicketCreateEvent : BaseEvent
    {
        /// <summary>
        /// Constructor para el evento TicketCreateEvent.
        /// Llama al constructor de la clase base y establece el tipo del evento.
        /// </summary>
        public TicketCreateEvent() : base(nameof(TicketCreateEvent))
        {
        }

        /// <summary>
        /// Nombre del usuario que creó el ticket.  Este campo es obligatorio.
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// Tipo de error, si ocurrió alguno durante la creación del ticket.  Este campo es opcional.
        /// </summary>
        public string? TypeError { get; set; }

        /// <summary>
        /// Detalles del error, si ocurrió alguno durante la creación del ticket. Este campo es obligatorio.
        /// </summary>
        public required string DetailError { get; set; }

    }
}