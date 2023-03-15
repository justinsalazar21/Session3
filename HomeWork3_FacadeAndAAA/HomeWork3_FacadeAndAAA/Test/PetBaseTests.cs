using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using HomeWork3_FacadeAndAAA.DataModels;                                                                                                                                                                                                                                                                                                                                ///CREATED BY JUSTIN SALAZAR :)
using System.Security.Cryptography.X509Certificates;                                                                                                                                                                                                                                                                                                                    ///CREATED BY JUSTIN SALAZAR :)                                        

namespace HomeWork3_FacadeAndAAA.Test
{
    public class PetBaseTests
    {
        public RestClient RestClient { get; set; }

        public petModels petDetails {get; set; }

        [TestInitialize]
        public void Initialize()
        {
            RestClient = new RestClient();                                                                                                                                                                                                                                                                                                                                                                          ///CREATED BY JUSTIN SALAZAR :)
        }

        [TestCleanup]
        public void Cleanup() { }                   
    }
}
