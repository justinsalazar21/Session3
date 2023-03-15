using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using HomeWork3_FacadeAndAAA.Resources;
using HomeWork3_FacadeAndAAA.Helpers;
using HomeWork3_FacadeAndAAA.Test;
using HomeWork3_FacadeAndAAA.DataModels;
using System.Net;
using HomeWork3_FacadeAndAAA.Test.GenerateTestData;

namespace HomeWork3_FacadeAndAAA.Helpers
{
    public class PetHelpers
    {
        public static async Task<petModels> AddNewPets(RestClient client)
        { 
            var newPetData = PetDataGenerate.addPets();
            var postRequest = new RestRequest(PetResources.postPet());

            //Send Post Request to add new pet
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<petModels>(postRequest);                                                                                                                                                                                                                                                                                                               ///CREATED BY JUSTIN SALAZAR :)

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
