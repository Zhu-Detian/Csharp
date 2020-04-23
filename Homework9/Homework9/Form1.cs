using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        private List<PageInfo> pages = new List<PageInfo> { };
        Crawler crawler = new Crawler();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            pageBindingSource.DataSource = pages;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void Crawler_CrawlerStopped(Crawler sender)
        {
            Action action = () => lblCrawlerStatus.Text = "Crawler Stopped.";

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string status)
        {
            PageInfo newPage = new PageInfo(pages.Count + 1, url, status);
            Action action = () =>
            {
                pages.Add(newPage);
                pageBindingSource.ResetBindings(false);
            };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pages.Clear();
            pageBindingSource.ResetBindings(false);
            crawler.StartURL = txtStartUrl.Text;

            if (thread != null) thread.Abort();
            thread = new Thread(crawler.Crawl);
            thread.Start();

            lblCrawlerStatus.Text = "Crawling ...";
        }
    }
}
