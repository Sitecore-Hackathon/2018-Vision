using Hackathon.Feature.InteractiveMaps.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Feature.InteractiveMaps.Controllers
{
    public class InteractiveMapsController : StandardController
    {
        protected readonly IDirectionMapRepository DirectionMapRepository;

        public InteractiveMapsController(IDirectionMapRepository directionMapRepository)
        {
            this.DirectionMapRepository = directionMapRepository;
        }


        protected override object GetModel()
        {
            return DirectionMapRepository.GetModel();
        }
    }
}