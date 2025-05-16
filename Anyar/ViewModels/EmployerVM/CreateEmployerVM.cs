using Microsoft.AspNetCore.Http;

namespace Anyar.ViewModels
{
    public class CreateEmployerVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IFormFile Imgae { get; set; }
        public int PrefossionId { get; set; }
        public string Description { get; set; }
    }
}
