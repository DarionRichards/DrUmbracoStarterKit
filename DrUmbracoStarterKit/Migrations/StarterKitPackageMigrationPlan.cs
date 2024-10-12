using System;
using Umbraco.Cms.Core.Packaging;

namespace DrUmbracoStarterKit.Migrations
{
    public class StarterKitPackageMigrationPlan : PackageMigrationPlan
    {
        public StarterKitPackageMigrationPlan()
            : base("DrUmbracoStarterKit")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("3B9BC73F-5116-4664-917E-A59015C749ED"));
        }
    } 
}