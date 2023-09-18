namespace Domain.Entities.Base
{
    public class EditableEntity : NonEditableEntity
    {
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        protected EditableEntity() 
        {
        }
    }
}