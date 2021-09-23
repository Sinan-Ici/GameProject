using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class ValidationManager : IValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationaltyId == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
