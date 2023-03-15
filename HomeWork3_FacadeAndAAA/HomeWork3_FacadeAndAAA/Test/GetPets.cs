using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HomeWork3_FacadeAndAAA.DataModels;
using HomeWork3_FacadeAndAAA.Helpers;
using HomeWork3_FacadeAndAAA.Resources;
using RestSharp;

namespace HomeWork3_FacadeAndAAA.Test
{
    [TestClass]
    public class GetPets : PetBaseTests
    {                                                                       
        private static List<petModels> petCleanup = new List<petModels>();                                                                                                                                                                                                                                                                                                                                                                                                          ///CREATED BY JUSTIN SALAZAR :)

        [TestInitialize]
        public async Task TestInitialize()
        {
            petDetails = await PetHelpers.AddNewPets(RestClient);
        }

        [TestMethod]

        public async Task GetPetsList()
        {
            //implementing AAA                                                                                                                                                                                                                                                                                                                                                                  ///CREATED BY JUSTIN SALAZAR :)                                            
            //Arrange
            var getpetlistrequest = new RestRequest(PetResources.GetPetbyID((int)petDetails.Id));
            petCleanup.Add(petDetails);

            //Act
            var getPetResponse = await RestClient.ExecuteGetAsync<petModels>(getpetlistrequest);
                                                                                                                                                                                                                                                                                                                                                                                                ///CREATED BY JUSTIN SALAZAR :)
            //Assert
            Assert.AreEqual(HttpStatusCode.OK, getPetResponse.StatusCode, "Status Code is not equal to 200");
            Assert.AreEqual(petDetails.Name, getPetResponse.Data.Name, "Pet Name doesn't match");
            Assert.AreEqual(petDetails.Category.Id, getPetResponse.Data.Category.Id, "Category ID doesn't match");
            Assert.AreEqual(petDetails.Category.Name, getPetResponse.Data.Category.Name, "Category Name doesn't match");
            Assert.AreEqual(petDetails.PhotoUrls[0], getPetResponse.Data.PhotoUrls[0], "PhotoURLS doesn't match");
            Assert.AreEqual(petDetails.Tags[0].Id, getPetResponse.Data.Tags[0].Id, "Tags ID doesn't match");
            Assert.AreEqual(petDetails.Tags[0].Name, getPetResponse.Data.Tags[0].Name, "Tag Name doesn't match");
            Assert.AreEqual(petDetails.Status, getPetResponse.Data.Status, "Status doesn't match");
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanup)
            {
                var deletePetRequest = new RestRequest(PetResources.DeletePetByID(data.Id));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }
    }
}
