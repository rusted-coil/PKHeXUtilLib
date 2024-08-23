using System.Text.Json;

namespace PKHeXUtilLib.Infrastructure.Internal
{
    internal sealed class Serializer
    {
        /*
        // ファイル読み込み
        public static T Deserialize<T>(string filePath)
            where T : new()
        {
            string content;
            try
            {
                content = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new T();
            }

            var nullable = JsonSerializer.Deserialize<T>(content);
            if (nullable != null)
            {
                return nullable;
            }
            return new T();
        }

        // ファイル保存
        public static bool Serialize<T>(string filePath, T data)
        {
            string content = JsonSerializer.Serialize(data);

            try
            {
                var directoryName = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                File.WriteAllText(filePath, content);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }
        */
    }
}
