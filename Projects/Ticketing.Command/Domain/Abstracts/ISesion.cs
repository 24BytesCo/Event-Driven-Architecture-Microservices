using MongoDB.Driver;

namespace Ticketing.Command.Domain.Abstracts
{
    /// <summary>
    /// Interfaz que define las operaciones para la gestión de sesiones y transacciones
    /// con la base de datos MongoDB.
    /// </summary>
    public interface ISesion
    {
        /// <summary>
        /// Inicia una nueva sesión asíncrona con MongoDB.
        /// </summary>
        /// <param name="cancellationToken">Token de cancelación para la operación.</param>
        /// <returns>Una tarea que representa la operación asíncrona y devuelve un objeto IClientSessionHandle
        /// que representa la sesión iniciada.</returns>
        Task<IClientSessionHandle> BeginSessionAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Inicia una transacción dentro de la sesión especificada.
        /// </summary>
        /// <param name="session">La sesión en la que se inicia la transacción.</param>
        void BeginTransaction(IClientSessionHandle session);

        /// <summary>
        /// Confirma los cambios realizados dentro de la transacción asociada a la sesión especificada
        /// de forma asíncrona.
        /// </summary>
        /// <param name="session">La sesión cuya transacción se va a confirmar.</param>
        /// <param name="cancellationToken">Token de cancelación para la operación.</param>
        /// <returns>Una tarea que representa la operación asíncrona de confirmación de la transacción.</returns>
        Task CommitTransactionAsync(IClientSessionHandle session, CancellationToken cancellationToken);

        /// <summary>
        /// Revierte los cambios realizados dentro de la transacción asociada a la sesión especificada
        /// de forma asíncrona.
        /// </summary>
        /// <param name="session">La sesión cuya transacción se va a revertir.</param>
        /// <param name="cancellationToken">Token de cancelación para la operación.</param>
        /// <returns>Una tarea que representa la operación asíncrona de reversión de la transacción.</returns>
        Task RollbackTransactionAsync(IClientSessionHandle session, CancellationToken cancellationToken);

        /// <summary>
        /// Libera los recursos asociados a la sesión especificada.
        /// </summary>
        /// <param name="session">La sesión que se va a liberar.</param>
        void DisposeSession(IClientSessionHandle session);
    }
}