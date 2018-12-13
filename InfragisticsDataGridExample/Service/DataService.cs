using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using InfragisticsDataGridExample.Data;

namespace InfragisticsDataGridExample.Service
{
    // This class acts as data service, but merely stubs out the needed data using AutoFixture
    public class DataService
    {
        public List<Dto> GetData()
        {
            var fixture = new Fixture();
            return fixture.CreateMany<Dto>(100).ToList();
        }
    }
}
