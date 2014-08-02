using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using CATS_Interview.Model;

namespace CATS_Interview.View_Models
{
    public class VehicleElementViewModel
    {
        public string ElementWeight { get; set; }
        public int ElementWeightId { get; set; }
        public IEnumerable<SelectListItem> ElementList { get; set; }
        public int[] SelectedElements { get; set; }
        public ElementEnum ElementEnum { get; set; }
        public string SelectedElement { get; set; }

        //static to reduce database hits when querying for list of bodies
        private static IEnumerable<SelectListItem> _bodies;

        public IEnumerable<SelectListItem> ElementOptions  
        {
            get
            {
                var db = new DatabaseContext();

                switch (ElementEnum)
                {
                    case ElementEnum.Body:

                        if (_bodies != null) return DefaultItem.Concat(_bodies);

                        _bodies =
                            db.BodyTypes.OrderBy(b=>b.BodyTypeValue).AsEnumerable().Select(
                                b =>
                                new SelectListItem
                                    {
                                        Value = b.BodyTypeId.ToString(CultureInfo.InvariantCulture),
                                        Text = b.BodyTypeValue
                                    });

                        return DefaultItem.Concat(_bodies);

                    case ElementEnum.Chassis:

                        //Limit chassis to chassis available at weight
                        var chassisByWeight = db.ChassisMakesByWeights.Where(c => c.WeightValueId == ElementWeightId).Select(u=>u.ChassisMakeValueId).ToList();

                        var chassisAtWeight =
                            db.ChassisMakes.Where(c => chassisByWeight.Contains(c.ChassisMakeId));
                        
                        var chassis=
                            chassisAtWeight.OrderBy(c=>c.ChassisMakeValue).AsEnumerable().Select(
                                b =>
                                new SelectListItem
                                    {
                                        Value = b.ChassisMakeId.ToString(CultureInfo.InvariantCulture),
                                        Text = b.ChassisMakeValue
                                    });

                        return DefaultItem.Concat(chassis);
                }
                return null;
            }
        }

        private IEnumerable<SelectListItem> DefaultItem
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                    {
                        Value = "0",
                        Text = "",
                        Selected = true
                    },1);
            }
        }

        public VehicleElementViewModel()
        {
        }

        public VehicleElementViewModel(ElementEnum element, string weight, byte weightId)
        {
            ElementEnum = element;
            ElementWeight = weight;
            ElementWeightId = weightId;
        }
    }
}