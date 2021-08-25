using mmt.PetShop.Core.IServices;

namespace PetMenu
{
    public class PetMenu
    {
        private readonly IPetService _petService;

        public PetMenu(IPetService petService)
        {
            _petService = petService;
        }
    }
}