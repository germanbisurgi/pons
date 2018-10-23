using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pons_Translator.DB;
using System.Data;

namespace Pons_Translator.models
{
    public class Word
    {
        public int id;
        public int categoryId;
        public int count;
        public string name;
        public string language;
        public string translation;

        public Word()
        {

        }

        public Word(int id, int categoryId, int count, string name, string language, string translation)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.count = count;
            this.name = name;
            this.language = language;
            this.translation = translation;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.name);
        }

        // Creates a word entry if this does not yet exist.
        public static void Create(int categoryId, int count, string name, string language, string translation)
        {
            Word existingWord = Word.FindOne(name);
            if (existingWord == null && name != "")
            {
                string sql = string.Format(@"INSERT INTO word(categoryId, count, name, language, translation) VALUES({0}, {1}, '{2}', '{3}', '{4}'); ", categoryId, count, name, language, translation);
                DBConnection.db.Adapter.Insert(sql);
            }
        }

        // Finds all words in the db.
        public static List<Word> FindAll()
        {
            List<Word> words = new List<Word>();
            string sql = "SELECT * FROM word";
            DataTable table = DBConnection.db.Adapter.GetDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                Word word = new Word();
                word.id = int.Parse(row["id"].ToString());
                word.categoryId = int.Parse(row["categoryId"].ToString());
                word.count = int.Parse(row["count"].ToString());
                word.name = row["name"].ToString();
                word.language = row["language"].ToString();
                word.translation = row["translation"].ToString();
                words.Add(word);
            }
            return words;
        }

        // finds one category by name.
        public static Word FindOne(string name)
        {
            List<Word> words = new List<Word>();
            string sql = string.Format(@"SELECT * FROM word WHERE name = '{0}'", name);
            DataTable tale = DBConnection.db.Adapter.GetDataTable(sql);
            foreach (DataRow row in tale.Rows)
            {
                Word word = new Word();
                word.id = int.Parse(row["id"].ToString());
                word.categoryId = int.Parse(row["categoryId"].ToString());
                word.count = int.Parse(row["count"].ToString());
                word.name = row["name"].ToString();
                word.language = row["language"].ToString();
                word.translation = row["translation"].ToString();
                words.Add(word);
            }
            if (words.Count == 0)
            {
                return null;
            }
            return words[0];
        }

        // Updates a word row by ID.
        public static void Update(int id, int categoryId, int count, string name, string language, string translation)
        {
            string sql = string.Format(@"UPDATE word SET categoryId = {1}, count = {2}, name = '{3}', language = '{4}', translation = '{5}'  WHERE id = {0};", id, categoryId, count, name, language, translation);
            DBConnection.db.Adapter.ExecuteSQL(sql);
        }

        // Deletes a word row by ID.
        public static void Delete(string id)
        {
            string sql = string.Format(@"DELETE FROM word WHERE id = {0}", id);
            DBConnection.db.Adapter.ExecuteSQL(sql);
        }
    }
}
