﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    class Crawler
    {
        private string getUrlRegex = @"[Hh][Rr][Ee][Ff][]*=[]*[""'](?<url>[^""'#>]+)[""']";
        private string parseUrlRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";

        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;

        private Hashtable urlTable = Hashtable.Synchronized(new Hashtable());
        private ConcurrentQueue<string> urlQueue = new ConcurrentQueue<string>();
        private int maxPages;
        public string StartURL { get; set; }
        private string HostFilter
        {
            get
            {
                Match match = Regex.Match(StartURL, parseUrlRegex);
                string host = match.Groups["host"].Value;
                return "^" + host + "$";
            }
        }
        private string FileFilter
        {
            get { return ".html?$"; }
        }

        public Crawler(int maxpages = 100)
        {
            maxPages = maxpages;
        }

        private void queueClear()
        {
            string result = "";
            while (urlQueue.TryDequeue(out result)) ;
        }

        public void Crawl()
        {
            urlTable.Clear();
            queueClear();
            urlQueue.Enqueue(StartURL);
            urlTable[StartURL] = false;

            
            while (urlTable.Count < maxPages )
            {
                List<string> urls = new List<string> { };
                string current = "";
                while (urlQueue.TryDequeue(out current))
                {
                    if ((bool)urlTable[current]) continue;
                    urls.Add(current);
                }

                Parallel.For(0, urls.Count, (i) => Solve(urls[i]));

                if (!urlQueue.TryDequeue(out current)) break;
                Thread.Sleep(500);
            }
            
            CrawlerStopped(this);
        }

        private void Solve(string current)
        {
            try
            {
                string html = Download(current);
                urlTable[current] = true;
                PageDownloaded(this, current, "success");
                Parse(current, html);
                //return true;
            }
            catch (Exception e)
            {
                PageDownloaded(this, current, e.Message);
                //return false;
            }
        }

        private void Parse(string currentURL, string subhtml)
        {
            MatchCollection matches = new Regex(getUrlRegex).Matches(subhtml);
            foreach (Match match in matches)
            {
                string newURL = match.Groups["url"].Value;
                if (newURL == null || newURL == "") continue;
                newURL = ConvertToAbsolutePath(newURL, currentURL);

                Match newURLMatch = Regex.Match(newURL, parseUrlRegex);
                string host = newURLMatch.Groups["host"].Value;
                string file = newURLMatch.Groups["file"].Value;
                if (file == null || file == "") file = "index.html";

                if (!Regex.IsMatch(host, HostFilter) || !Regex.IsMatch(file, FileFilter)) continue;
                if (urlTable[newURL] == null)
                {
                    urlQueue.Enqueue(newURL);
                    urlTable[newURL] = false;
                }
            }
        }

        private string ConvertToAbsolutePath(string newURL, string currentURL)
        {
            if (newURL.Contains("://")) return newURL;
            if (newURL.Contains("//")) return "http:" + newURL;
            if (newURL.StartsWith("/"))
            {
                Match match = Regex.Match(currentURL, parseUrlRegex);
                string site = match.Groups["site"].Value;
                return site.EndsWith("/") ? site + newURL.Substring(1) : site + newURL;
            }
            if (newURL.StartsWith("./")) return ConvertToAbsolutePath(newURL.Substring(2), currentURL);
            int lastIndex = currentURL.LastIndexOf('/');
            if (newURL.StartsWith("../")) return ConvertToAbsolutePath(newURL.Substring(3), currentURL.Substring(0, lastIndex));

            return currentURL.Substring(0, lastIndex) + "/" + newURL;
        }

        private string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = urlTable.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

    }
}
