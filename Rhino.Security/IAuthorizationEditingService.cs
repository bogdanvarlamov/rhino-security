namespace Rhino.Security
{
    /// <summary>
    /// Allows to edit the security information of the 
    /// system
    /// </summary>
    public interface IAuthorizationEditingService
    {
        /// <summary>
        /// Creates a new users group.
        /// </summary>
        /// <param name="name">The name of the new group.</param>
        UsersGroup CreateUsersGroup(string name);

        /// <summary>
        /// Creates a new entities group.
        /// </summary>
        /// <param name="name">The name of the new group.</param>
        EntitiesGroup CreateEntitiesGroup(string name);

        /// <summary>
        /// Gets the associated users group for the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        UsersGroup[] GetAssociatedUsersGroupFor(IUser user);

        /// <summary>
        /// Gets the users group by its name
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        UsersGroup GetUsersGroupByName(string groupName);

        /// <summary>
        /// Gets the entities group by its name
        /// </summary>
        /// <param name="groupName">The name of the group.</param>
        EntitiesGroup GetEntitiesGroupByName(string groupName);

        /// <summary>
        /// Gets the groups the specified entity is associated with
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        EntitiesGroup[] GetAssociatedEntitiesGroupsFor<TEntity>(TEntity entity) where TEntity : class;


        /// <summary>
        /// Associates the entity with a group with the specified name
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="groupName">Name of the group.</param>
        void AssociateEntityWith<TEntity>(TEntity entity, string groupName) where TEntity : class;

        /// <summary>
        /// Associates the user with a group with the specified name
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="groupName">Name of the group.</param>
        void AssociateUserWith(IUser user, string groupName);

        /// <summary>
        /// Creates the operation with the given name
        /// </summary>
        /// <param name="operationName">Name of the operation.</param>
        /// <returns></returns>
        Operation CreateOperation(string operationName);

        /// <summary>
        /// Gets the operation by the specified name
        /// </summary>
        /// <param name="operationName">Name of the operation.</param>
        /// <returns></returns>
        Operation GetOperationByName(string operationName);
    }
}