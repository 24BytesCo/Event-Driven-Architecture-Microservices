namespace Ticketing.Command.Domain.Common
{
    /// <summary>
    /// Atributo para especificar el nombre de la colección de MongoDB a la que pertenece un documento.
    /// Se utiliza para mapear clases de dominio con colecciones en la base de datos.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)] // Indica que este atributo se puede aplicar a clases y no es heredable.
    public class BsonCollectionAttribute : Attribute
    {
        /// <summary>
        /// Constructor del atributo.
        /// </summary>
        /// <param name="collectionName">Nombre de la colección en MongoDB.</param>
        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }

        /// <summary>
        /// Nombre de la colección en MongoDB.
        /// </summary>
        public string CollectionName { get; set; }
    }
}