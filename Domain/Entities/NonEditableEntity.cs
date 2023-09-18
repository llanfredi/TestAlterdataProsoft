namespace Domain.Entities.Base
{
    public class NonEditableEntity : BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        protected NonEditableEntity() 
        {
        }
    }
}
