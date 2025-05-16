namespace Anyar.ViewModels
{
    public class UpdateEmployerVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public IFormFile Photo { get; set; }

        public string Prefossion { get; set; }
        public string Description { get; set; }
    }
}
