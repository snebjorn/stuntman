namespace RimDev.Stuntman.Core
{
    using System;
    using System.IO;
    using System.Net.Http;

    public class StuntmanOptionsRetriever
    {
        public virtual string GetStringFromLocalFile(Uri uri)
        {
            return File.ReadAllText(uri.AbsolutePath);
        }

        public virtual string GetStringUsingWebClient(Uri uri)
        {
            using (var httpClient = new HttpClient())
            {
                return httpClient.GetStringAsync(uri).Result;
            }
        }
    }
}
