using JoeAbpMpa.Entities;
using JoeAbpMpa.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace JoeAbpMpa.Migrations.SeedData
{
    class DefaultAssetCategoryCreator
    {
        private readonly JoeAbpMpaDbContext _context;
        private readonly List<AssetCategory> _assetCategories;


        public DefaultAssetCategoryCreator(JoeAbpMpaDbContext context)
        {
            _context = context;
            _assetCategories = new List<AssetCategory> {
                new AssetCategory(){ Id=1, Category ="Computer"},
                new AssetCategory(){ Id=2, Category ="Server"},
                new AssetCategory(){ Id=3, Category ="Printer"}
            };
        }

        public void Create()
        {
            foreach (var item in _assetCategories)
            {
                AddCategoryIfNotExists(item);
            }
        }

        private void AddCategoryIfNotExists(AssetCategory assetCategory)
        {
            if (_context.AssetCategories.Any(c => c.Category == assetCategory.Category && c.Id == assetCategory.Id))
            {
                return;
            }
            _context.AssetCategories.Add(assetCategory);
            _context.SaveChanges();
        }

    }
}
