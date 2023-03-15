using HomeWork3_FacadeAndAAA.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork3_FacadeAndAAA.DataModels;                                                                                                                                                                                                                                                                                                                                                        ///CREATED BY JUSTIN SALAZAR :)
using System.Diagnostics;

namespace HomeWork3_FacadeAndAAA.Test.GenerateTestData
{
    public class PetDataGenerate
    {
        public static petModels addPets()
        {

            //adding tags data                                                                                                                                                                                                                                                                                              ///CREATED BY JUSTIN SALAZAR :)
            List<CategoryT> tags = new List<CategoryT>
            {
                new CategoryT()
                {
                    Id = 1,
                    Name = "chihuahua brown"
                },

                new CategoryT()
                {
                    Id = 2,
                    Name = "chihuahua white"
                }                                                                                                                                                                                                                                                                                                         ///CREATED BY JUSTIN SALAZAR :)                                                      
            };
            //note: I changed the way I created the data and the objects to make it simplier
            //object creation   
            petModels petObjects = new petModels()                                                                                                                                                                                                                                                                                                                                                  ///CREATED BY JUSTIN SALAZAR :)
            {
                Id = 1919,
                Category = new Category()
                {
                    Id = 1,
                    Name = "House Pet"
                },
                Name = "Harvey",
                PhotoUrls = new List<string> {"petUrl1", "petURL2", "petURL3"},                                                                                                                                                                                                                                                                                                                                                 ///CREATED BY JUSTIN SALAZAR :)
                Tags = tags,
                Status = "Available"
            };

            return petObjects;
        }
        
    }
}
