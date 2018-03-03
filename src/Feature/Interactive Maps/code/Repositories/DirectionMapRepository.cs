using Hackathon.Feature.InteractiveMaps.Repositories;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Hackathon.Feature.InteractiveMaps.Models
{
    public class DirectionMapRepository : ModelRepository, IDirectionMapRepository
    {

        public override IRenderingModelBase GetModel()

        {

            DirectionMapModel model = new DirectionMapModel();

            FillBaseProperties(model);

            model.Key = GetKey();

            return model;

        }

        private string GetKey()

        {

            return PageContext.Current[Sitecore.Feature.InteractiveMaps.Templates.InteractiveMaps.Fields.Key];

        }
    }
}