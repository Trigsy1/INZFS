
using INZFS.MVC.Models;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INZFS.MVC.Migrations
{
    public class EligibilityCreiteriaMigration : DataMigration
    {
        public readonly IContentDefinitionManager _contentDefinitionManager;
        public EligibilityCreiteriaMigration(IContentDefinitionManager contentDefinitionManager) => _contentDefinitionManager = contentDefinitionManager;

        public int Create()
        {
            _contentDefinitionManager.AlterTypeDefinition(nameof(EligibilityCreiteria), type => type
               .Creatable()
               .Listable()

               // We attach parts by specifying their name. For our own parts we use nameof(): This is not mandatory
               // but serves great if we change the part's name during development.
               .WithPart(nameof(EligibilityCreiteria))
           );

            return 1;
        }
    }
}
