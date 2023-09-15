namespace Domain.Entities.Base
{
    public class EditableEntity : NonEditableEntity
    {
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        protected EditableEntity() 
        {
        }
    }
}