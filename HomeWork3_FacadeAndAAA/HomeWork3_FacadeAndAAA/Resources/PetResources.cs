using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork3_FacadeAndAAA.Helpers;
using HomeWork3_FacadeAndAAA.Resources;
using HomeWork3_FacadeAndAAA.Test;

namespace HomeWork3_FacadeAndAAA.Resources
{
    public class PetResources
    {                                                                                                                                                                                                                                                                                                                                                                                                       ///CREATED BY JUSTIN SALAZAR :)
        public const string petBaseURL = "https://petstore.swagger.io/v2";
        public static string GetPetbyID(long petID) => $"{petBaseURL}/pet/{petID}";
        public static string postPet() => $"{petBaseURL}/pet";
        public static string DeletePetByID(long petIDdel) => $"{petBaseURL}/pet/{petIDdel}";                                                                                                                                                                                                                                                                                    ///CREATED BY JUSTIN SALAZAR :)

    }
}
