using EmlpoyeeMgt.Models;

namespace EmlpoyeeMgt.ViewModels
{
    public class EmployeeEditViewModel:EmployeeCreateModel
    {
        
        
        public int Id { get; set; }
        
        public string ExistingPhotoPath { get; set; }
    }
}