namespace Abp.Application.Services.Dto
{
    /// <summary>
    /// This <see cref="IInputDto"/> can be used to send Id of an entity to an <see cref="IApplicationService"/> method.
    /// </summary>
    public class EntityRequestInput : EntityRequestInput<int>, IEntityDto
    {

    }
}