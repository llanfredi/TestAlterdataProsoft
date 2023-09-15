namespace Domain.Entities.Base
{
    public class NonEditableEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        protected NonEditableEntity() 
        {
        }
    }
}
