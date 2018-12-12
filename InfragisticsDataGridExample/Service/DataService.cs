using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using InfragisticsDataGridExample.Data;

namespace InfragisticsDataGridExample.Service
{
    public class DataService
    {
        public List<Dto> GetData()
        {
            var fixture = new Fixture();
            return fixture.CreateMany<Dto>(100).ToList();
        }
    }
}
