using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Feature.InteractiveMaps.Repositories
{

    public interface IDirectionMapRepository
    {
        //IEnumerable<MapPoint> GetAll(Data.Items.Item contextItem);

        IRenderingModelBase GetModel();
    }
}