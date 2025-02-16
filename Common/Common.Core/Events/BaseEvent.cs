using Common.Core.Messages;

namespace Common.Core.Events
{
    /// <summary>
    /// Clase abstracta base para todos los eventos en el sistema.
    /// Hereda de Message y añade propiedades específicas de los eventos.
    /// </summary>
    public abstract class BaseEvent : Message
    {
        /// <summary>
        /// Constructor para la clase BaseEvent.
        /// Requiere el tipo del evento.
        /// </summary>
        /// <param name="type">El tipo del evento.</param>
        public BaseEvent(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Versión del evento.  Se utiliza para manejar cambios
        /// en la estructura del evento a lo largo del tiempo.
        /// Inicializada a 1 en el constructor.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Tipo del evento.  Describe la naturaleza del evento.
        /// </summary>
        public string Type { get; set; }

    }
}