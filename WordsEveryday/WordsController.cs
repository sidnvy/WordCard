using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WordsEveryday
{
    public class WordsController
    {
        public string connString;

        public WordsController(string DBName)
        {
            connString = string.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\{0};Integrated Security=True;Connect Timeout=30", DBName);
        }

        /// <summary>
        /// Get words from DB
        /// </summary>
        /// <param name="want_batch">Number of words needed</param>
        /// <param name="status">Status in DB</param>
        /// <param name="review">Whether in review mode</param>
        /// <param name="back_batch">actual number get from DB</param>
        /// <returns>A word list</returns>
        public List<Word> GetBatchofWords(int want_batch, int status, bool Review, out int back_batch)
        {
            SqlConnection conn = new SqlConnection(this.connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(connString, conn);
            if (!Review)
            {
                cmd.CommandText = string.Format(
                        "SELECT TOP {0} * FROM   Word  WHERE (WordStatus = {1}) ORDER BY NEWID();",
                        want_batch, status);
            }
            else
            {
                cmd.CommandText = string.Format(
                       "SELECT * FROM   Word  WHERE (WordStatus = {0});", status);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            //int i = 0;
            //Word[] words = new Word[want_batch];
            List<Word> words = new List<Word>();
            while (reader.Read())
            {
                Word w = new Word();
                w.english = reader["Word"].ToString();
                w.chinese = reader["Chinese"].ToString();
                w.learnTime = (int)reader["LearnTime"];
                w.wordStatus = (int)reader["WordStatus"];
                //words[i] = w;
                //i += 1;
                words.Add(w);
            }
            reader.Close();
            conn.Close();
            back_batch = words.Count;
            return words;
        }

        /// <summary>
        /// Save words to DB
        /// </summary>
        /// <param name="words">Words will save</param>
        /// <param name="batch">Number of words</param>
        public int SaveBatchofWords(List<Word> words, int batch)
        {
            SqlConnection conn = new SqlConnection(this.connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(connString, conn);
            int affectedRow = 0;
            for (int i = 0; i < batch; i++)
            {
                cmd.CommandText = string.Format("UPDATE Word SET WordStatus = {0}, LearnTime = {1} WHERE Word = '{2}';", words[i].wordStatus, words[i].learnTime, words[i].english);
                affectedRow += cmd.ExecuteNonQuery();
            }
            conn.Close();
            return affectedRow;
        }

        //public void 
    }
}
