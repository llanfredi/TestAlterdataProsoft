namespace Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }

        protected BaseEntity() 
        { 
        }
    }
}
