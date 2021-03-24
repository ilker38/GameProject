using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız Doğrulama Başarısız Oldu");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Dekete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
