using INZFS.MVC;
using INZFS.MVC.Models;
using INZFS.MVC.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace INZFS.MVC.Drivers
{
    public class EligilityCreiteriaDriver : ContentPartDisplayDriver<EligibilityCreiteria>
    {
        public override IDisplayResult Display(EligibilityCreiteria part, BuildPartDisplayContext context) =>
            Initialize<EligilityCreiteriaViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel))
                .Location("Detail", "Content:1")
                .Location("Summary", "Content:1");

        public override IDisplayResult Edit(EligibilityCreiteria part, BuildPartEditorContext context) =>
            Initialize<EligilityCreiteriaViewModel>(GetEditorShapeType(context), viewModel => PopulateViewModel(part, viewModel));

        public override async Task<IDisplayResult> UpdateAsync(EligibilityCreiteria part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new EligilityCreiteriaViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.TechnologyAndInnovation = viewModel.TechnologyAndInnovation;
            part.Timing = viewModel.Timing;
            part.MatchFunding = viewModel.MatchFunding;
            part.SubsidyCategory = viewModel.SubsidyCategory;

            return await EditAsync(part, context);
        }

        private static void PopulateViewModel(EligibilityCreiteria part, EligilityCreiteriaViewModel viewModel)
        {
            viewModel.EligibilityCreiteria = part;

            viewModel.TechnologyAndInnovation = part.TechnologyAndInnovation;
            viewModel.Timing = part.Timing;
            viewModel.MatchFunding = part.MatchFunding;
            viewModel.SubsidyCategory = part.SubsidyCategory;
        }
    }
}
