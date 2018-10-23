using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pons_Translator.DB;
using System.Data;

namespace Pons_Translator.models
{
    public class Category
    {
        public long id;
        public string name;

        public Category()
        {
        }

        // Used to print category objects into lists.
        public override string ToString()
        {
            return string.Format("{0}", this.name);
        }

        // Creates a category entry if this does not yet exist.
        public static void Create(string name)
        {
            Category existingCategory = Category.FindOne(name);
            if (existingCategory == null && name != "")
            {
                string sql = string.Format(@"INSERT INTO category(name) VALUES('{0}'); ", name);
                DBConnection.db.Adapter.Insert(sql);
            }
        }

        // Finds all categories in the db.
        public static List<Category> FindAll()
        {
            List<Category> categories = new List<Category>();
            string sql = "SELECT * FROM category";
            DataTable table = DBConnection.db.Adapter.GetDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                Category category = new Category();
                category.id = long.Parse(row["id"].ToString());
                category.name = row["name"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        // finds one category by name.
        public static Category FindOne(string name)
        {
            List<Category> categories = new List<Category>();
            string sql = string.Format(@"SELECT * FROM category WHERE name = '{0}'", name);
            DataTable tale = DBConnection.db.Adapter.GetDataTable(sql);
            foreach (DataRow row in tale.Rows)
            {
                Category category = new Category();
                category.id = long.Parse(row["id"].ToString());
                category.name = row["name"].ToString();
                categories.Add(category);
            }
            if (categories.Count == 0)
            {
                return null;
            }
            return categories[0];
        }

        // Updates a category row by ID.
        public static void Update(string id, string newName)
        {
            string sql = string.Format(@"UPDATE category SET name = '{0}' WHERE id = {1};", newName, id);
            DBConnection.db.Adapter.ExecuteSQL(sql);
        }

        // Deletes a category row by ID.
        public static void Delete(string id)
        {
            string sql = string.Format(@"DELETE FROM category WHERE id = {0}", id);
            DBConnection.db.Adapter.ExecuteSQL(sql);
        }
    }
}
